using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Data;
using WebApplication1.Models.CarrerasViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class CarrerasController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CarrerasController(ApplicationDbContext context)
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
            // SELEC DE SECUENCIAS DE LA BASE DE DATOS

            //EMPIEZA
            var db = (from c in _context.Secuencias where c.Descripcion == "Carreras" select c.Value).ToList();

            int Id = 0;
            foreach (var item in db)
            {
                Id = int.Parse(item.ToString());
            }

            //var persona = (from c in _context.PersonaXtipo where c.IdTipoPersona==1 select c.Value).ToList();

            //FINALIZA
            string id = "Carrera" + Id;

            modelo.CarreraId = id;

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(CrearViewModel modelo)
        {

            if (ModelState.IsValid)
            {
                //var carrera = (from c in _context.Carreras select c.IdCarrera);
                ////se ocupa generar una tabla secuencias donde se almacenan los ids de las entidades
                //string id = "Carrera02";

                var db = (from c in _context.Secuencias where c.Descripcion == "Carreras" select c.Value).ToList();

                int Id = 0;

                foreach (var item in db)
                {
                    Id = int.Parse(item.ToString());

                }

                var index = (from c in _context.Secuencias where c.Descripcion == "Carreras" select new { c.Value, c.Descripcion }).FirstOrDefault();

                //index.Value = index.Value + 1;

                //FINALIZA
                string id = "Carrera" + Id;


                _context.Carreras.Add(new Models.Carreras
                {
                    NombreCarrera = modelo.NombreCarrera,
                    Cursos = null,
                    IdCarrera = id,
                    IdPersona = modelo.PersonaAsignada
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

            //cargar el select items de la carrera

            var carreras = (from c in _context.Carreras
                            select new Models.Carreras
                            {
                                IdCarrera = c.IdCarrera,
                                NombreCarrera = c.NombreCarrera
                            }).ToList();

            //modelo.Cod_Carrera = "Carrera0001";

            //var cursos = (from cur in _context.Cursos join car in _context.Carreras on cur.IdCarrera equals car.IdCarrera
            //              where car.IdCarrera == modelo.Cod_Carrera select new Model.Cursos
            //              { IdCurso = cur.IdCurso, Descripcion = cur.Descripcion }).ToList();


            modelo.Carreras = carreras;
            //modelo.Cursos = cursos;


            return View(modelo);
        }

        public JsonResult GetSubCategories(EditarViewModel modelo, string id)
        {

            var cursos = (from cur in _context.Cursos
                          join car in _context.Carreras on cur.IdCarrera equals car.IdCarrera
                          where car.IdCarrera == id
                          select new Models.Cursos
                          { IdCurso = cur.IdCurso, Descripcion = cur.Descripcion }).ToList();




            return Json(new SelectList(cursos, "Value", "Text"));
        }



        [HttpPost]
        public IActionResult Search(EditarViewModel modelo)
        {
            if (modelo.Cod_Carrera != null && modelo.Cod_Carrera != " ")
            {
                var carrera = (from p in _context.Carreras
                               where p.IdCarrera == modelo.Cod_Carrera

                               select new Models.Carreras
                               {
                                   Cursos = p.Cursos,
                                   NombreCarrera = p.NombreCarrera,
                                   IdPersona = p.IdPersona

                               }).ToList();

                if (carrera.Count() == 0)
                {
                    return RedirectToAction("Error", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                  new { controller = "Home", action = "Error" }));
                }

                EditarViewModel modelo1 = new EditarViewModel();


                //donde el tipo sea decano 
                modelo1.Personas = (from c in _context.Persona where c.TipoPersonaId == "Persona2" select c).ToList();


                foreach (var item in carrera)
                {

                    modelo1.NombreCarrera = item.NombreCarrera;
                    modelo1.IdPersona = item.IdPersona;
                    modelo1.Cursos = item.Cursos;
                    modelo1.Cod_Carrera = item.IdCarrera;

                }


                return View("~/Views/Registro/Edit.cshtml", modelo1);
            }

            return View(modelo);
        }



        [HttpPost]
        public IActionResult Edit(EditarViewModel modelo)
        {
            if (ModelState.IsValid)
            {



            }

            return View(modelo);
        }

    }
}
