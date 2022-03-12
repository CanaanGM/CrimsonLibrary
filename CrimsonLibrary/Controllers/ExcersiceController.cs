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
    public class ExcersiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ExcersiceController> _logger;
        private readonly IMapper _mapper;

        public ExcersiceController(IUnitOfWork unitOfWork, ILogger<ExcersiceController> logger, IMapper mapper)
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
            var exercises = await _unitOfWork.Exercises.GetAll(
                requestParams,
                includes: new List<string> { "Workouts" });
            return exercises != null ? Ok(_mapper.Map<List<ExerciseDto>>(exercises)) : NotFound();
        }

        [HttpGet("{id:Guid}", Name = "GetExercise")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(Guid id)
        {
            var exercises = await _unitOfWork.Exercises.Get(x => x.Id == id, new List<string> { "Workouts" });
            return exercises != null ? Ok(_mapper.Map<ExerciseDto>(exercises)) : NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateExercise([FromBody] ExerciseCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateExercise)}");
                return BadRequest();
            }

            var exercise = _mapper.Map<Exercise>(dto);
            await _unitOfWork.Exercises.Insert(exercise);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetExercise", new { id = exercise.Id }, exercise);
        }

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateExercise(Guid id, [FromBody] ExerciseUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(UpdateExercise)}");
                return BadRequest(ModelState);
            }

            var exercise = await _unitOfWork.Exercises.Get(x => x.Id == id);
            if (exercise == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(UpdateExercise)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(updateDto, exercise);
            _unitOfWork.Exercises.Update(exercise);
            await _unitOfWork.Save();
            return NoContent();
        }


        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var exercise = await _unitOfWork.Exercises.Get(x => x.Id == id);
            if (exercise == null)
            {
                _logger.LogError($"Invalid PUT attempt in {nameof(Delete)}");
                return NotFound();
            }
            await _unitOfWork.Exercises.Delete(exercise.Id);
            await _unitOfWork.Save();
            return NoContent();
        }
    }
}