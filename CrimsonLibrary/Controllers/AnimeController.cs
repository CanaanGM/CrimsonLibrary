using AutoMapper;

using CrimsonLibrary.Data.IReopsitory;
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
    public class AnimeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOFWork;
        private readonly ILogger<AnimeController> _logger;
        private readonly IMapper _mapper;

        public AnimeController(IUnitOfWork unitOFWork, ILogger<AnimeController> logger, IMapper mapper)
        {
            _unitOFWork = unitOFWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var anime = await _unitOFWork.Anime.GetAll();
            var res = _mapper.Map<List<AnimeDto>>(anime);
            if (anime == null) return NotFound();
            return Ok(res);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var anime = await _unitOFWork.Anime.Get(x => x.Id == id);
            var res = _mapper.Map<AnimeDto>(anime);
            if (anime == null) return NotFound();
            return Ok(res);
        }
    }
}