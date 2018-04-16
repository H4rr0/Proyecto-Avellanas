using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.PerfilViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class PerfilController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PerfilController(ApplicationDbContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IndexViewModel modelo = new IndexViewModel();

            var persona = (from p in _context.Persona where p.Cedula == User.Identity.Name select p).FirstOrDefault();
            modelo.NombreCompleto = persona.NombreCompleto;
            modelo.Cedula = persona.Cedula;
            modelo.Carnet = persona.Carnet;
            modelo.Pais = persona.Pais;
            modelo.Correo = persona.Correo;
            modelo.Genero = persona.Genero;
            modelo.TipoPersona = (from p in _context.TipoPersona
                                  join per in _context.Persona on p.IdTipoPersona equals per.TipoPersonaId
                                  where per.Cedula == User.Identity.Name
                                  select p.Descripción).FirstOrDefault();
            
            return View(modelo);
        }


    }
}
