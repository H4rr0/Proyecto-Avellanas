using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.AulaViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class AulaController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AulaController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IndexViewModel modelo = new IndexViewModel();

            //var grupo = from g in _context.Grupos 

            //var cursos = from c in _context.Cursos 
            //             join p in _context.Persona on c.ip

            return View();
        }
    }
}
