using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using apirest.Domain.Entities;
using apirest.Domain.Handlers.Produto.Create;
using apirest.Domain.Handlers.Produto.Remove;
using apirest.Domain.Handlers.Produto.Read;
using apirest.Domain.Handlers.Produto.Update;
using apirest.Domain.Handlers.Produto.List;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace apirest.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : LiquidControllerBase
    {
        public ProdutoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> GetById([FromRoute] Int64 id)
        {
            var response = await ExecuteAsync(new ReadProdutoQuery(id));

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var response = await ExecuteAsync(new ListProdutoQuery());

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] ProdutoEntity entity)
        {
            await ExecuteAsync(new CreateProdutoCommand(entity));

            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Put([FromBody] ProdutoEntity entity)
        {
            var response = await ExecuteAsync(new UpdateProdutoCommand(entity));

            if (response.Data == null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] Int64 id)
        {
            var response = await ExecuteAsync(new RemoveProdutoCommand(id));

            if (response.Data == null) return NotFound();

            return NoContent();
        }
    }
}