using DE.Application.DTOs.Request;
using DE.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DE.Api.Controllers
{
    [Route("api/identity-document-type")]
    [ApiController]
    public class IdentityDocumentTypeController : ControllerBase
    {
        private readonly IIdentityDocumentTypeService _identityDocumentTypeService;

        public IdentityDocumentTypeController(
            IIdentityDocumentTypeService identityDocumentTypeService
        )
        {
            _identityDocumentTypeService = identityDocumentTypeService;
        }

        [Authorize]
        [HttpGet()]
        public async Task<IActionResult> GetSupplier()
        {
            var response = await _identityDocumentTypeService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var response = await _identityDocumentTypeService.GetByIdAsync(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] IdentityDocumentTypeRequest model)
        {
            var response = await _identityDocumentTypeService.CreateAsync(model);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            [FromBody] IdentityDocumentTypeRequest model
        )
        {
            var response = await _identityDocumentTypeService.UpdateAsync(model, id);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _identityDocumentTypeService.DeleteAsync(id);
            return Ok(response);
        }

        [HttpGet("list-items")]
        public async Task<IActionResult> GetListItems()
        {
            var response = await _identityDocumentTypeService.GetSelectItem();
            return Ok(response);
        }
    }
}
