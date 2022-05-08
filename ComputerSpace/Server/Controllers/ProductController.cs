using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputerSpace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Lenovo ThinkBook 15 i5-1135G7/16GB/512/Win11P",
                Description = "Biznesowy laptop Lenovo ThinkBook 15 to styl i wydajność w klasie premium.",
                ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/10/pr_2021_10_26_17_34_34_784_00.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Dell Vostro 3510 i5-1135G7/16GB/512/Win11P",
                Description = "Laptop Dell Vostro 3510 znakomicie spisuje się zarówno w biurze, jak i poza nim.",
                ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2021/12/pr_2021_12_22_8_41_26_62_00.jpg",
                Price = 6.99m
            },
            new Product
            {
                Id = 3,
                Title = "HP Neverstop 1200w WiFi Mono USB LCD",
                Description = "HP Neverstop 1200w to idealne rozwiązanie, gdy musisz szybko wydrukować bądź skopiować dokumenty przed wyjściem albo prowadzisz małą firmę i potrzebujesz od czasu do czasu skorzystać ze skanera.",
                ImageUrl = "https://cdn.x-kom.pl/i/setup/images/prod/big/product-new-big,,2019/7/pr_2019_7_8_13_16_8_962_06.jpg",
                Price = 4.99m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
