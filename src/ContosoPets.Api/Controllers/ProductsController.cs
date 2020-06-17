using System.Collections.Generic;
using System.Linq;
using ContosoPets.Api.Data;
using ContosoPets.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPets.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ContosoPetsContext _context;

        public ProductsController(ContosoPetsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAll() =>
            _context.Products.ToList();

        // GET by ID action

        // POST action

        // PUT action

        // DELETE action
    }
}