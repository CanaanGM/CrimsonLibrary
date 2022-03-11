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
    public class WorkoutController : ControllerBase
    {
        private readonly IUnitOfWork _unitOFWork;
        private readonly ILogger<WorkoutController> _logger;
        private readonly IMapper _mapper;

        public WorkoutController(IUnitOfWork unitOFWork, ILogger<WorkoutController> logger, IMapper mapper)
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
            try
            {
                var workouts =await _unitOFWork.Workouts.GetAll();
                return workouts != null ? Ok( _mapper.Map<List<WorkoutDto>>(workouts) ) : NotFound();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in {nameof(Get)}");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {                                                                                                                       // has to match the domain prop
                var workout = await _unitOFWork.Workouts.Get(workout => workout.Id == id, new List<string> { "Excersises" });
                return workout != null ? Ok(_mapper.Map<WorkoutDto>(workout)) : NotFound();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in {nameof(Get)}");
                return BadRequest(ex.Message);
            }
        }
    }
}
