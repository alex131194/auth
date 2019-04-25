using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Datos
{
    public class EditUser
    {


        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Display(Name = "Mail de Contacto")]
        [EmailAddress]
        public string MailContacto { get; set; }

        [Display(Name = "Nombre de la empresa")]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        [Display(Name = "Servicio 24H")]
        [StringLength(2)]
        public string ServicioT { get; set; }

        [Display(Name = "Categoría profesional")]
        public int CodCat { get; set; }
    }
}