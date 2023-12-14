using CRUDApi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("ProductswithPriceGreaterthan20")]
        public List<Product> ProductswithPriceGreaterthan20()
        {
            List<Product> products = new List<Product>();
            Product product1=new Product();
            product1.ProductId = 1;
            product1.Product_Name = "Biscuit";
            product1.Price = 3;
            product1.Quantity = 10;
            product1.IsEdible = true;
            products.Add(product1);

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.Product_Name = "Shoes";
            product2.Price = 5;
            product2.Quantity = 16;
            product2.IsEdible = false;
            products.Add(product2);

            return products;
            
        }
        [HttpGet("ProductswithQuantityLessthan5")]
        public List<Product> ProductswithQuantityLessthan5()
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.Product_Name = "chips";
            product1.Price = 1;
            product1.Quantity = 4;
            product1.IsEdible = true;
            products.Add(product1);

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.Product_Name = "Rice";
            product2.Price = 15;
            product2.Quantity = 11;
            product2.IsEdible = true;
            products.Add(product2);

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.Product_Name = "Milk";
            product3.Price = 7;
            product3.Quantity = 3;
            product3.IsEdible = true;
            products.Add(product3);

            return products;

        }
        [HttpGet("ProductWhichareEdible")]
        public List<Product> ProductWhichareEdible()
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.Product_Name = "cakes";
            product1.Price = 1;
            product1.Quantity = 4;
            product1.IsEdible = true;
            products.Add(product1);

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.Product_Name = "Tshirt";
            product2.Price = 8;
            product2.Quantity = 18;
            product2.IsEdible = false;
            products.Add(product2);

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.Product_Name = "Peanuts";
            product3.Price = 6;
            product3.Quantity = 3;
            product3.IsEdible = true;
            products.Add(product3);

            return products;

        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
