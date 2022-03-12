using AutoMapper;

using CrimsonLibrary.Data.IReopsitory;
using CrimsonLibrary.Data.Models;
using CrimsonLibrary.Data.Models.Domain;
using CrimsonLibrary.Data.Models.Dtos;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimsonLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<BookController> _logger;
        private readonly IMapper _mapper;

        public BookController(IUnitOfWork unitOfWork, ILogger<BookController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromQuery] RequestParams requestParams)
        {
            var books = await _unitOfWork.Books.GetAll(requestParams);
            return books != null ? Ok(_mapper.Map<List<BookDto>>(books)) : NotFound();
        }

        [HttpGet("{id:Guid}", Name = "GetBook")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var book = await _unitOfWork.Books.Get(x => x.Id == id);
            return book != null ? Ok(_mapper.Map<BookDto>(book)) : NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] BookCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(Create)}");
                return BadRequest();
            }

            var book = _mapper.Map<Book>(dto);
            await _unitOfWork.Books.Insert(book);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetBook", new { id = book.Id }, book);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(Guid id, [FromBody] BookUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest(ModelState);
            }

            var book = await _unitOfWork.Books.Get(x => x.Id == id);
            if (book == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(updateDto, book);
            _unitOfWork.Books.Update(book);
            await _unitOfWork.Save();
            return NoContent();
        }


        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var book = await _unitOfWork.Books.Get(x => x.Id == id);
            if (book == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Delete)}");
                return NotFound();
            }
            await _unitOfWork.Books.Delete(book.Id);
            await _unitOfWork.Save();
            return NoContent();
        }
    }
}