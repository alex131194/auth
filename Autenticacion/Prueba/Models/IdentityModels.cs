﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Nombre"), Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos"), Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Display(Name = "Mail de Contacto"), Required]
        [EmailAddress]
        public string MailContacto { get; set; }

        [Display(Name = "Nombre de la empresa"), Required]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        [Display(Name = "Servicio 24H"),Required]
        [StringLength(2)]
        public string ServicioT { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}