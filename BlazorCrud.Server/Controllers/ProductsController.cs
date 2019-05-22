using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Server.Data;
using BlazorCrud.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrud.Server.Controllers
{
    public class ProductsController : Controller
    {
        ProductDataAccessLayer objprod = new ProductDataAccessLayer();

        [HttpGet]
        [Route("api/Product/Index")]
        public IEnumerable<Product> Index()
        {
            return objprod.GetAllProducts();
        }

        [HttpPost]
        [Route("api/Product/Create")]
        public void Create([FromBody] Product product)
        {
            if (ModelState.IsValid)
            { 
                objprod.AddProduct(product);
            }
        }

        [HttpGet]
        [Route("api/Product/Details/{id}")]
        public Product Details(int id)
        {
            return objprod.GetProduct(id);
        }

        [HttpPut]
        [Route("api/Product/Edit")]
        public void Edit([FromBody] Product product)
        {
            objprod.UpdateProduct(product);
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public void Delete(int id)
        {
            objprod.DeleteProduct(id);
        }
    }
}