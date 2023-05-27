
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Threading.Tasks;

namespace Livraria.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class livrariaController : ControllerBase
    {
        private readonly ToDoContext _context;

        public livrariaController(ToDoContext context)
        {
            _context = context;


            _context.todoProducts.Add(new Produto { ID = "1", Nome = " O Hobbit", Preco = 89.90, Quanti = 1, Categoria = "Fantasia", Img = "imgBilbo" });
            _context.todoProducts.Add(new Produto { ID = "2", Nome = " O Hobbit2", Preco = 89.90, Quanti = 3, Categoria = "Fantasia", Img = "imgBilbo2" });
            _context.todoProducts.Add(new Produto { ID = "3", Nome = " O Hobbit3", Preco = 89.90, Quanti = 5, Categoria = "Fantasia", Img = "imgBilbo3" });

            _context.SaveChanges();

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos() 
        {
            return await _context.todoProducts.ToListAsync();
        }
    }
}
