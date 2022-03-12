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
    public class WorkoutController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<WorkoutController> _logger;
        private readonly IMapper _mapper;

        public WorkoutController(IUnitOfWork unitOFWork, ILogger<WorkoutController> logger, IMapper mapper)
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
            var workouts = await _unitOfWork.Workouts.GetAll(requestParams);
            return workouts != null ? Ok(_mapper.Map<List<WorkoutDto>>(workouts)) : NotFound();
        }

        //[HttpGet("{date:string, cycleType:string, duration:double}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> Get(string date = null,string cycleType = null, double duration =0 )
        //{

        //    var workouts = await _unitOfWork.Workouts.GetAll();
        //    return workouts != null ? Ok(_mapper.Map<List<WorkoutDto>>(workouts)) : NotFound();
        //}

        [HttpGet("{id:Guid}", Name = "GetWorkout")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {                                                                                                                      // has to match the domain prop
            var workout = await _unitOfWork.Workouts.Get(workout => workout.Id == id, new List<string> { "Excersises" });
            return workout != null ? Ok(_mapper.Map<WorkoutDto>(workout)) : NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] WorkoutCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(Create)}");
                return BadRequest();
            }
            var workout = _mapper.Map<Workout_BodyBuilding>(dto);
            await _unitOfWork.Workouts.Insert(workout);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetWorkout", new { id = workout.Id }, workout);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(Guid id, [FromBody] WorkoutUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest(ModelState);
            }
            var workout = await _unitOfWork.Workouts.Get(x => x.Id == id);
            if (workout == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Update)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(updateDto, workout);
            _unitOfWork.Workouts.Update(workout);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var workout = await _unitOfWork.Workouts.Get(x => x.Id == id);
            if (workout == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Delete)}");
                return NotFound();
            }
            await _unitOfWork.Workouts.Delete(workout.Id);
            await _unitOfWork.Save();
            return NoContent();
        }
    }
}