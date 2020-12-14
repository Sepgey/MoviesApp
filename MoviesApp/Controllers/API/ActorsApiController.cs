using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Services;
using MoviesApp.Services.Dto;
using MoviesApp.ViewModels;

namespace MoviesApp.Controllers
{
    [Route("api/actors")]
    [ApiController]
    public class ActorsApiController : ControllerBase
    {
        private readonly IActorService _service;

        public ActorsApiController(IActorService service)
        {
            _service = service;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ActorDto>))]
        [ProducesResponseType(404)]
        public ActionResult<IEnumerable<ActorDto>> GetActors()
        {
            return Ok(_service.GetAllActors());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(ActorDto))]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var actor = _service.GetActor(id);
            if (actor == null) return NotFound();
            return Ok(actor);
        }

        [HttpPost]
        public ActionResult<ActorDto> PostActor(ActorDto inputDto)
        {
            var actor = _service.AddActor(inputDto);
            return CreatedAtAction("GetById", new {id = actor.Id}, actor);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateActor(ActorDto editDto)
        {
            var actor = _service.UpdateActor(editDto);
            if (actor == null) return BadRequest();

            return Ok(actor);
        }

        [HttpDelete("{id}")]
        public ActionResult<DeleteActorViewModel> DeleteActor(int id)
        {
            var actor = _service.DeleteActor(id);
            if (actor == null) return NotFound();
            return Ok(actor);
        }
    }
}