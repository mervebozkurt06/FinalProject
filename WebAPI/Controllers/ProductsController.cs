using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] //bu isteği yaparken insanlar nasıl ulaşacak (api/products(controllerının ismi))
    [ApiController] //Attribute-class hakkında bilgi verir(bu class bir controllerdır)
    public class ProductsController : ControllerBase
    {
        //IoC Container -- Inversion of Control 
        IProductService _productService;

        public ProductsController(IProductService productService) //sen bir IProductService bağımlısısın
        {                        //ProductManager verir constructor a
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            
            var result =_productService.GetAll();
            return result.Data;
        }
    }
}
