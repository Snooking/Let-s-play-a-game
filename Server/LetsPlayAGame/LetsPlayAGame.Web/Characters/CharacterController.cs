using LetsPlayAGame.BussinessLogic.Characters.QueryHandlers;
using LetsPlayAGame.Data;
using LetsPlayAGame.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LetsPlayAGame.Web.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly GetCharacterByIdQueryHandler _getCharacterById;

        public CharacterController(GetCharacterByIdQueryHandler getCharacterById)
        {
            _getCharacterById = getCharacterById;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _getCharacterById.Handle(id);

            if (!result.IsSuccess)
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok(result);
        }
    }
}
