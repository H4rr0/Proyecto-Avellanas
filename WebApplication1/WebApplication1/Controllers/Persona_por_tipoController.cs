using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.Persona_por_tipo;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class Persona_por_tipoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Persona_por_tipoController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            CrearViewModel modelo = new CrearViewModel();

            var personas = (from c in _context.Persona select c).ToList();

            var tipo_persona = (from c in _context.TipoPersona select c).ToList();

            modelo.Persona = personas;
            modelo.TipoPersona = tipo_persona;

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(CrearViewModel modelo)
        {

            if (ModelState.IsValid)
            {

                _context.PersonaXtipo.Add(new Models.PersonaXtipo
                {

                    IdPersona = modelo.PersonaSelecionada,
                    IdTipoPersona = modelo.TipoPersonaSelecionada

                });

                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                        new { controller = "Home", action = "Index" }));

            }

            var personas = (from c in _context.Persona select c).ToList();

            var tipo_persona = (from c in _context.TipoPersona select c).ToList();

            modelo.Persona = personas;
            modelo.TipoPersona = tipo_persona;

            return View(modelo);
        }

    }
}
