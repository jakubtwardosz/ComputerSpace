using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputerSpace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductType>>>> GetProductTypes()
        {
            var response = await _productTypeService.GetProductTypes();
            return Ok(response);
        }
    }
}
