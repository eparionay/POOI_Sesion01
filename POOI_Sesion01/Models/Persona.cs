using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace POOI_Sesion01.Models
{
    public class Persona
    {
        [Display(Name ="IdPersona")]
        public int codigo { get; set; }

        [Display(Name="Nombres")]
        public string nombre { get; set; }

        [Display(Name ="Apellidos")]
        public string apellido { get; set; }

        [Display(Name ="Horas")]
        public int cantidadHoras { get; set; }

        [Display(Name = "Tarifa")]
        public double tarifa { get; set; }

        public Persona() {
            codigo = 0;
            nombre = "";
            apellido = "";
            cantidadHoras = 0;
            tarifa = 0;
        }

        public double getSueldoBruto()
        {
            return cantidadHoras * tarifa;
        }













    }
}