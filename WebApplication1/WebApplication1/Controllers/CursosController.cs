using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.CursosViewModels;


namespace WebApplication1.Controllers
{
    public class CursosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CursosController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Cursos/Create
        public IActionResult Create()
        {
            CrearViewModel modelo = new CrearViewModel();
            var carreras = (from c in _context.Carreras select c).ToList();

            modelo.CarreraId = "Carrera1";
            modelo.CarrerasList = carreras;

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(CrearViewModel modelo)
        {

            var carreras = (from c in _context.Carreras select c).ToList();
            //if (modelo.CarreraId == null)
            //	{
            //	modelo.CarreraId = "Carrera1";
            //}

            modelo.CarrerasList = carreras;

            if (ModelState.IsValid)
            {
                var Curso = new Cursos
                {
                    IdCurso = modelo.IdCurso,
                    IdCarrera = modelo.CarreraId,
                    Descripcion = modelo.Descripcion,
                    //IdMateriarequerida = modelo.IdMateriarequerida,
                    Creditos = modelo.Creditos,
                    Estado = modelo.Estado,
                    Precio = modelo.Precio,
                    IdPersona = null

                };

                _context.Cursos.Add(Curso);
                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                              new { controller = "Home", action = "Index" }));

            }

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Search(EditViewModel modelo)
        {
            if (modelo.IdCurso.Trim() != "")
            {
                var cursos = (from p in _context.Cursos
                              where p.IdCurso == modelo.IdCurso
                              select new Models.Cursos
                              {
                                  Descripcion = p.Descripcion,
                                  Creditos = p.Creditos,
                                  Precio = p.Precio,
                                  IdCurso=p.IdCurso

                              }).ToList();

                if (cursos.Count() == 0)
                {
                    return RedirectToAction("Error", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                  new { controller = "Home", action = "Error" }));
                }

                EditViewModel modelo1 = new EditViewModel();


                foreach (var item in cursos)
                {
                    modelo1.Descripcion = item.Descripcion;
                    modelo1.Creditos = item.Creditos;
                    modelo1.Precio = item.Precio;
                    modelo1.IdCurso = item.IdCurso;
                    modelo1.IdCurso2 = item.IdCurso;
                }


                return View("~/Views/Cursos/Edit.cshtml", modelo1);
            }

            return View(modelo);
        }

        //[HttpPost]
        //public IActionResult Search1(DeleteViewModel modelo)
        //{
        //	if (modelo.IdCurso != null)
        //	{
        //		var cursos = (from p in _context.Cursos
        //					  where p.IdCurso == modelo.IdCurso
        //					  select new Models.Cursos
        //					  {
        //						  Descripcion = p.Descripcion,
        //						  Creditos = p.Creditos,
        //						  Precio = p.Precio
        //					  }).ToList();

        //		if (cursos.Count() == 0)
        //		{
        //			return RedirectToAction("Error", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
        //		  new { controller = "Home", action = "Error" }));
        //		}

        //		EditViewModel modelo1 = new EditViewModel();


        //		foreach (var item in cursos)
        //		{
        //			modelo1.Descripcion = item.Descripcion;
        //			modelo1.Creditos = item.Creditos;
        //			modelo1.Precio = item.Precio;
        //		}


        //		return View("~/Views/Cursos/Edit.cshtml", modelo1);
        //	}

        //	return View(modelo);

        //}
        public IActionResult Edit()
        {

            EditViewModel modelo = new EditViewModel();
            return View(modelo);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditViewModel modelo)
        {
            if (ModelState.IsValid)
            {

                var cursos = (from c in _context.Cursos where c.IdCurso == modelo.IdCurso2 select c).FirstOrDefault();

                cursos.Descripcion = modelo.Descripcion;
                cursos.Creditos = modelo.Creditos;
                cursos.Precio = modelo.Precio;

                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                        new { controller = "Home", action = "Index" }));

            }

            return View();
        }


        //[HttpPost]
        //public IActionResult Delete(DeleteViewModel modelo)
        //{
        //	if (modelo.IdCurso != null)
        //	{
        //		Models.Cursos x = _context.Cursos.Single(p => p.IdCurso == modelo.IdCurso);

        //		_context.Cursos.Remove(x);

        //		_context.SaveChanges();

        //		return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
        //			   new { controller = "Home", action = "Index" }));


        //	}
        //	return View(modelo);

        //}
    }


}
