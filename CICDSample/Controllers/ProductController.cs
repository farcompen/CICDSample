using CICDSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICDSample.Controllers
{
    [Route("api/v1/Product/")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = new List<Product>() {

                new Product(){Id=1,Name="TV",Piece=20},
                new Product(){ Id=2,Name="PC",Piece=10}


            };
            return products;

        }
    }


}


