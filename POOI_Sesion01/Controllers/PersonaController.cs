using POOI_Sesion01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_Sesion01.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            Persona objPersona = new Persona();
            objPersona.codigo = 100;
            objPersona.nombre = "Erick";
            objPersona.apellido = "Pariona";
            return View(objPersona);
        }

        public ActionResult Formulario()
        {
            return View(new Persona());
        }

        [HttpPost]
        public ActionResult Formulario(Persona persona)
        {
            Debug.WriteLine("Nombre : " + persona.nombre);
            Debug.WriteLine("Codigo : " + persona.codigo);
            ViewBag.sueldo = persona.getSueldoBruto();
            return View(persona);
        }






    }
}