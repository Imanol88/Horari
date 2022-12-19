using System.Linq;
using System.Web.Mvc;

using Horari.Models;
using Horari.Models.ViewModels;

namespace Horari.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index ( )
        {
            return View();
        }




        [HttpPost]
        public ActionResult IniciarSesion ( LoginModel model )
        {

            if (ModelState.IsValid)
            {

                using (horariEntities db = new horariEntities())
                {
                    string password = (from d in db.profesor
                                       where d.control == model.Control
                                       select d.passwd).FirstOrDefault();

                    if (model.Passwd == password)
                    {
                        return Redirect("/Disponibilidad");
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error";
                    }

                }
            }
            return View("Index", model);
        }








    }
}