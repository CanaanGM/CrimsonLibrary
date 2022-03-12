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
    public class BoughtItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<BoughtItemController> _logger;
        private readonly IMapper _mapper;

        public BoughtItemController(IUnitOfWork unitOFWork, ILogger<BoughtItemController> logger, IMapper mapper)
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
            var items = await _unitOfWork.BoughtItems.GetAll(requestParams);
            var res = _mapper.Map<List<BoughtItemDto>>(items);
            if (items == null) return NotFound();
            return Ok(res);
        }

        [HttpGet("{date}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByDate(DateTime date)
        {
            var items = await _unitOfWork.BoughtItems.GetAll(
                expression:x=>x.DateBought == date
                );
            var res = _mapper.Map<List<BoughtItemDto>>(items);
            if (items == null) return NotFound();
            return Ok(res);
        }

        [HttpGet("{id:Guid}", Name = "GetBoughtItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var item = await _unitOfWork.BoughtItems.Get(x => x.Id == id);
            var res = _mapper.Map<BoughtItemDto>(item);
            if (item == null) return NotFound();
            return Ok(res);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] BoughtItemCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(Create)}");
                return BadRequest();
            }
            var item = _mapper.Map<BoughtItem>(dto);
            await _unitOfWork.BoughtItems.Insert(item);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetBoughtItem", new { id = item.Id }, item);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(Guid id, [FromBody] BoughtItemUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest(ModelState);
            }
            var item = await _unitOfWork.BoughtItems.Get(x => x.Id == id);
            if (item == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(updateDto, item);
            _unitOfWork.BoughtItems.Update(item);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var item = await _unitOfWork.BoughtItems.Get(x => x.Id == id);
            if (item == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Delete)}");
                return NotFound();
            }
            await _unitOfWork.BoughtItems.Delete(item.Id);
            await _unitOfWork.Save();
            return NoContent();
        }

    }
}