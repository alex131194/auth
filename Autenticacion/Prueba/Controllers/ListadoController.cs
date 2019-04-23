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
                    List<AspNetUsers> lista = db.AspNetUsers.ToList();
                    return View(lista);
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}