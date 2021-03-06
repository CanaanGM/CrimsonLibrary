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
using System.Linq;
using System.Threading.Tasks;

namespace CrimsonLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MangaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MangaController> _logger;
        private readonly IMapper _mapper;

        public MangaController(IUnitOfWork unitOFWork, ILogger<MangaController> logger, IMapper mapper)
        {
            _unitOfWork = unitOFWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromQuery] RequestParams requestParams)
{
            var manga = await _unitOfWork.Manga.GetAll(requestParams);
            var res = _mapper.Map<List<MangaDto>>(manga);
            if (manga == null) return NotFound();
            return Ok(res);
        }

        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(string name)
        {
            return !string.IsNullOrEmpty(name)
                ? Ok(_mapper.Map<List<AnimeDto>>(await _unitOfWork.Manga.GetAll(
                    expression: x => x.Name.Contains(name))))
                : NotFound();
        }


        [HttpGet("{id:Guid}", Name = "GetManga")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var manga = await _unitOfWork.Manga.Get(x => x.Id == id);
            var res = _mapper.Map<MangaDto>(manga);
            if (manga == null) return NotFound();
            return Ok(res);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] MangaCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(Create)}");
                return BadRequest();
            }
            var manga = _mapper.Map<Manga>(dto);
            await _unitOfWork.Manga.Insert(manga);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetManga", new { id = manga.Id }, manga);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(Guid id, [FromBody] MangaUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest(ModelState);
            }
            var manga = await _unitOfWork.Manga.Get(x => x.Id == id);
            if (manga == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(updateDto, manga);
            _unitOfWork.Manga.Update(manga);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var manga = await _unitOfWork.Manga.Get(x => x.Id == id);
            if (manga == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Delete)}");
                return NotFound();
            }
            await _unitOfWork.Manga.Delete(manga.Id);
            await _unitOfWork.Save();
            return NoContent();
        }

    }
}