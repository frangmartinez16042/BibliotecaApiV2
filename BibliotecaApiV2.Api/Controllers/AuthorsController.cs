using AutoMapper;
using BibliotecaApiV2.Core;
using BibliotecaApiV2.Core.Commands;
using BibliotecaApiV2.Core.Dtos.Inputs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace BibliotecaApiV2.Api.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AuthorsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Crea un nuevo <see cref="Author"/>
        /// </summary>
        /// <param name="creationData"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> CreateTransfer([FromBody] CreateAuthorData creationData)
        {
            CreateAuthor command = new CreateAuthor(creationData);
            await _mediator.Send(command);

            return Ok();
        }
    }
}
