using Microsoft.AspNetCore.Mvc;
using reqreslog.App.Models;

namespace reqreslog.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Product> GetByID(int id)
        {
            var product = new Product()
            {
                Id = id,
                Name = "RAZER Mamba Trådlös Gamingmus",
                Description = "Nya Mamba Wireless är en ny och förbättrad trådlös Mamba från Razer med bättre batteritid, Razer Chroma™belysning och ergonomisk högerhandsdesign."
            };

            return Ok(product);
        }
    }
}
