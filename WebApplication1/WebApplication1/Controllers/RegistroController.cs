using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.RegistroViewModels;
using WebApplication1.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Authorize]
    public class RegistroController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Models.ApplicationUser> _userManager;
        private readonly SignInManager<Models.ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;



        public RegistroController(ApplicationDbContext context,
             UserManager<Models.ApplicationUser> userManager,
            SignInManager<Models.ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<AccountController> logger)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            CrearViewModel modelo = new CrearViewModel();
            var tipos = (from c in _context.TipoPersona select c).ToList();
            var carne = (from ca in _context.Secuencias where ca.Descripcion == "Carnet" select ca).ToList();
            var carreras = (from c in _context.Carreras select c).ToList();
            var carne_valor = 0;
            foreach (var item in carne)
            {
                carne_valor = int.Parse(item.Value.ToString());
            }

            modelo.Carnet = "2018" + carne_valor;
            modelo.Tipos = tipos;
            //modelo.Carreras = carreras;

            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CrearViewModel modelo)
        {

            var tipos = (from c in _context.TipoPersona select c).ToList();



            var consulta_secuencia_carne = (from ca in _context.Secuencias where ca.Descripcion == "Carnet" select ca);
            var carne = (from ca in _context.Secuencias where ca.Descripcion == "Carnet" select ca).ToList();
            var carne_valor = 0;

            foreach (var item in carne)
            {
                carne_valor = int.Parse(item.Value.ToString());
            }

            modelo.Carnet = "2018" + carne_valor;

            modelo.Tipos = tipos;

            if (ModelState.IsValid)
            {
                if (modelo.IdPersona.Length < 9)
                {
                    return View(modelo);
                }
                if ((from p in _context.Persona where p.Cedula == modelo.IdPersona select p).ToList().Count > 0)
                {
                    return View("Error");
                }             
                
                int persona = (from p in _context.Persona
                               where p.Cedula == modelo.IdPersona
                               select p).Count();

                if (persona <= 0)
                {
                    if (modelo.Genero == "M" || modelo.Genero == "F" || modelo.Genero == "I")
                    {
                        //var password = "1234567qQwc4";

                        string pass = "1234567qQ";
                        List<Carreras> carrera = new List<Carreras>();

                        //if (modelo.IdTipoPersona == "1")
                        //{

                        //    //var consulta_carrera = (from car in _context.Carreras where car.IdCarrera == modelo.CarreraSeleccionada select car).FirstOrDefault();

                        //    //carrera.Add(new Carreras
                        //    //{
                        //    //    IdCarrera = "CAR_EST" + (from seq in _context.Secuencias
                        //    //                             where seq.Descripcion == "CAR_EST"
                        //    //                             select seq.Value).FirstOrDefault(),
                        //    //    NombreCarrera = consulta_carrera.NombreCarrera,
                        //    //    IdPersona = modelo.IdPersona
                        //    //});

                        //}
                        //else
                        //{
                        //    carrera = null;
                        //}


                        var user = new ApplicationUser
                        {
                            UserName = modelo.IdPersona,
                            Email = modelo.Correo,
                            NombreCompleto = modelo.Nombre + " " + modelo.Apellido1 + " " + modelo.Apellido2,
                            TipoPersonaId = modelo.IdTipoPersona,
                            Correo = modelo.Correo,
                            Genero = modelo.Genero,
                            Carnet = modelo.Carnet,
                            Pais = modelo.Pais,
                            Ciudad = modelo.Ciudad,
                            Password = pass,
                            Cedula = modelo.IdPersona,
                            Carreras = carrera
                        };

                        var result = await _userManager.CreateAsync(user, pass);

                        if (result.Succeeded)
                        {
                            _logger.LogInformation("User created a new account with password.");

                            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                            var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                            await _emailSender.SendEmailConfirmationAsync(modelo.Correo, callbackUrl);

                            await _signInManager.SignInAsync(user, isPersistent: false);
                            _logger.LogInformation("User created a new account with password.");

                            //actualiza la tabla de secuencias 
                            var secuencia = consulta_secuencia_carne.FirstOrDefault();

                            secuencia.Value = secuencia.Value + 1;

                            _context.SaveChanges();

                            return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                              new { controller = "Home", action = "Index" }));
                        }
                    }

                    return View(modelo);

                }
                return View(modelo);

            }

            return View(modelo);
        }

        public IActionResult Edit()
        {
            EditarViewModel modelo = new EditarViewModel();

            return View(modelo);
        }

        //buscar para esditar
        [HttpPost]
        public IActionResult Search(EditarViewModel modelo)
        {
            if (modelo.IdPersona.Trim() != "" || (from p in _context.Persona where p.Cedula == modelo.IdPersona select p).ToList().Count > 0)
            {
                var persona = (from p in _context.Persona
                               where p.Cedula == modelo.IdPersona
                               select new ApplicationUser
                               {
                                   Pais = p.Pais,
                                   NombreCompleto = p.NombreCompleto,
                                   Correo = p.Correo,
                                   Genero = p.Genero,
                                   Cedula=p.Cedula
                               }).ToList();

                if (persona.Count() == 0)
                {
                    return RedirectToAction("Error", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                  new { controller = "Home", action = "Error" }));
                }


                EditarViewModel modelo1 = new EditarViewModel();

                string genero = "";

                //string Nombre = "";
                //string Apellido1 = "";
                //string Apellido2 = "";
                //int controlador = 0;

                foreach (var item in persona)
                {
                    switch (item.Genero)
                    {

                        case "F":
                            genero = "Femenino";
                            break;

                        case "M":
                            genero = "Masculino";
                            break;

                        case "I":
                            genero = "Indefinido";
                            break;
                    }


                    modelo1.Nombre = item.NombreCompleto;
                    modelo1.Correo = item.Correo;
                    modelo1.Pais = item.Pais;
                    modelo1.Genero = genero;
                    modelo1.IdPersona2 = item.Cedula;
                }


                return View("~/Views/Registro/Edit.cshtml", modelo1);
            }

            return View("Error");
        }
        //buscar para eliminar
        [HttpPost]
        public IActionResult Search1(DeleteViewModel modelo)
        {

            if (modelo.IdPersona.Trim() != "" || (from p in _context.Persona where p.Cedula == modelo.IdPersona select p).ToList().Count > 0)
            {

                var persona = (from p in _context.Persona
                               where p.Cedula == modelo.IdPersona
                               select new ApplicationUser
                               {
                                   Pais = p.Pais,
                                   NombreCompleto = p.NombreCompleto,
                                   Correo = p.Correo,
                                   Genero = p.Genero
                               }).ToList();


                if (persona.Count() == 0)
                {
                    return RedirectToAction("Error", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                  new { controller = "Home", action = "Error" }));
                }


                DeleteViewModel modelo1 = new DeleteViewModel();

                string genero = "";

                //string Nombre = "";
                //string Apellido1 = "";
                //string Apellido2 = "";
                //int controlador = 0;

                foreach (var item in persona)
                {
                    switch (item.Genero)
                    {

                        case "F":
                            genero = "Femenino";
                            break;

                        case "M":
                            genero = "Masculino";
                            break;

                        case "I":
                            genero = "Indefinido";
                            break;
                    }


                    modelo1.Nombre = item.NombreCompleto;
                    modelo1.Correo = item.Correo;
                    modelo1.Pais = item.Pais;
                    modelo1.Genero = genero;
                    modelo1.IdTipoPersona = item.TipoPersonaId;

                }


                return View("~/Views/Registro/Delete.cshtml", modelo1);
            }

            return View("Error");
        }

        [HttpPost]
        public IActionResult Edit(EditarViewModel modelo)
        {
            if (ModelState.IsValid)
            {

                var persona = (from c in _context.Persona where c.Cedula == modelo.IdPersona2 select c).FirstOrDefault();

                persona.NombreCompleto = modelo.Nombre;
                persona.Genero = modelo.Genero;
                persona.Pais = modelo.Pais;
                modelo.Correo = modelo.Correo;


                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                        new { controller = "Home", action = "Index" }));

            }

            return View();
        }

        public IActionResult Delete()
        {
            DeleteViewModel modelo = new DeleteViewModel();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(DeleteViewModel modelo)
        {
            if (modelo.IdPersona.Trim() != "")
            {
                ApplicationUser x = _context.Persona.Single(p => p.Cedula == modelo.IdPersona);

                _context.Persona.Remove(x);

                _context.SaveChanges();

                return RedirectToAction("Index", new Microsoft.AspNetCore.Routing.RouteValueDictionary(
                       new { controller = "Home", action = "Index" }));


            }
            return View(modelo);

        }




    }
}
