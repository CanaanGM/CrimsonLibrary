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
    public class MusicTrackController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MusicTrackController> _logger;
        private readonly IMapper _mapper;

        public MusicTrackController(IUnitOfWork unitOfWork, ILogger<MusicTrackController> logger, IMapper mapper)
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
            var track = await _unitOfWork.MusicTracks.GetAll(requestParams);
            var res = _mapper.Map<List<MusicTrackDto>>(track);
            if (track == null) return NotFound();
            return Ok(res);
        }


        [HttpGet()]
        [Route("fav")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> willItWork()
        {
            var favs = _mapper.Map<List<MusicTrackDto>>(await _unitOfWork.MusicTracks.GetAll(
                    expression: x => x.IsFavorite == true));
            return favs != null
                ? Ok(favs)
                : NotFound();
        }


        [HttpGet("{id:Guid}", Name = "GetTrack")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var track = await _unitOfWork.MusicTracks.Get(x => x.Id == id);
            var res = _mapper.Map<MusicTrackDto>(track);
            if (track == null) return NotFound();
            return Ok(res);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] MusicTrackCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(Create)}");
                return BadRequest();
            }
            var track = _mapper.Map<MusicTrack>(dto);
            await _unitOfWork.MusicTracks.Insert(track);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetTrack", new { id = track.Id }, track);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(Guid id, [FromBody] MusicTrackUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest(ModelState);
            }
            var track = await _unitOfWork.MusicTracks.Get(x => x.Id == id);
            if (track == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(updateDto, track);
            _unitOfWork.MusicTracks.Update(track);
            await _unitOfWork.Save();
            return NoContent();
        }


        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var track = await _unitOfWork.MusicTracks.Get(x => x.Id == id);
            if (track == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Delete)}");
                return NotFound();
            }
            await _unitOfWork.MusicTracks.Delete(track.Id);
            await _unitOfWork.Save();
            return NoContent();
        }


    }
}
