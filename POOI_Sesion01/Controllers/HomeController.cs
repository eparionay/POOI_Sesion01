using POOI_Sesion01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_Sesion01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bienvenido a POOI.";
            ViewBag.codigo  = "100";
            ViewBag.ciclo   = "III";
            return View();
        }

        public ActionResult Contact()
        {

            Persona objPersona = new Persona();
            objPersona.codigo = 1;
            objPersona.nombre = "Erick";
            objPersona.apellido = "Pariona";
            objPersona.tarifa = 10;
            objPersona.cantidadHoras = 20;

            ViewBag.Message = "Mis Datos Personales";
            ViewBag.nombre = objPersona.nombre;
            ViewBag.apellido = objPersona.apellido;
            ViewBag.tarifa = objPersona.tarifa;
            ViewBag.cantidadHoras = objPersona.cantidadHoras;
            ViewBag.sueldo = objPersona.getSueldoBruto();
            ViewBag.correo = "pericpar@cibertec.edu.pe";
            ViewBag.celular = "978882747";
            return View();
        }
    }
}