using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.TipoPersonaViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class Tipo_PersonaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Tipo_PersonaController(ApplicationDbContext context)
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

            modelo.IdTipoPersona = "TP001";

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(CrearViewModel modelo)
        {

            if (ModelState.IsValid)
            {
                //var carrera = (from c in _context.Carreras select c.IdCarrera);
                //se ocupa generar una tabla secuencias donde se almacenan los ids de las entidades
                string Id = "TP001";

                _context.TipoPersona.Add(new Models.TipoPersona
                {
                    IdTipoPersona = Id,
                    Descripción = modelo.TipoNombre,
                    Persona = null,
                    PersonaXtipo = null
                });

                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                        new { controller = "Home", action = "Index" }));

            }

            return View();
        }


        public IActionResult Edit()
        {
            EditarViewModel modelo = new EditarViewModel();


            var tipos = (from c in _context.TipoPersona select c).ToList();


            modelo.Tipos = tipos;

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Edit(EditarViewModel modelo)
        {

            if (ModelState.IsValid)
            {
                //SAMPLE HOW TO DO AN UPDATE

                //var cust =
                //    (from c in db.Customers
                //     where c.CustomerID == "ALFKI"
                //     select c).First();

                //// Change the name of the contact.
                //cust.ContactName = "New Contact";



                var tipo = (from c in _context.TipoPersona where c.IdTipoPersona == modelo.TipoId select c).FirstOrDefault();

                tipo.Descripción = modelo.TipoNombre;

                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                        new { controller = "Home", action = "Index" }));

            }

            return View(modelo);
        }

    }
}
