using Prueba.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class ListadoController : Controller
    {
        // GET: Listado
        public ActionResult Listar()
        {
            try
            {
                using (var db = new TonomEntities())
                {
                    var data = from a in db.AspNetUsers
                               join c in db.Categorias on a.CodCat equals c.Id
                               select new usersCP()
                               {
                                   Email = a.Email,
                                   Nombre = a.Nombre,
                                   Apellidos = a.Apellidos,
                                   UserName = a.UserName,
                                   MailContacto = a.MailContacto,
                                   NombreEmpresa = a.NombreEmpresa,
                                   ServicioT = a.ServicioT,
                                   Categoria = c.NombreCat
                               };
                    return View(data.ToList());
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}