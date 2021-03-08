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

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result =_productService.GetAll();
            if(result.Success)
            {
                return Ok(result); //Ok=200(başarılı) ->get requestlerde 200 ile çalışılır
            }
            return BadRequest(result); //BadRequest=400 ->işlem başarısızsa
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
