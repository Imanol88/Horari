using System.Linq;
using System.Web.Mvc;

using Horari.Models;
using Horari.Models.ViewModels;


namespace Horari.Controllers
{
    public class DisponibilidadController : Controller
    {

        public ActionResult Index ( )
        {

            return View();
        }


        [HttpPost]
        public ActionResult GuardarDisponibilidad ( DisponibilidadModel model )
        {

            if (ModelState.IsValid)
            {

                using (horariEntities db = new horariEntities())
                {


                    long ultimo = (from d in db.disponibilidad
                                   select d.idHorario).FirstOrDefault();

                    string lunes = model.Lunes;
                    string martes = model.Martes;
                    string miercoles = model.Miercoles;
                    string jueves = model.Jueves;
                    string viernes = model.Viernes;

                    lunes = string.Concat(lunes.Where(c => c != ','));
                    martes = string.Concat(martes.Where(c => c != ','));
                    miercoles = string.Concat(miercoles.Where(c => c != ','));
                    jueves = string.Concat(jueves.Where(c => c != ','));
                    viernes = string.Concat(viernes.Where(c => c != ','));

                    if (lunes.Contains('l'))
                    {
                        disponibilidad disp = new disponibilidad
                        {
                            idHorario = ultimo + 1,
                            profesor = "21443",
                            dia = 2,
                            horas = lunes
                        };
                        _ = db.disponibilidad.Add(disp);
                        _ = db.SaveChanges();
                    }

                    ultimo = (from d in db.disponibilidad
                              select d.idHorario).FirstOrDefault();

                    if (martes.Contains('m'))
                    {
                        disponibilidad disp = new disponibilidad
                        {
                            idHorario = ultimo + 1,
                            profesor = "21443",
                            dia = 3,
                            horas = martes
                        };
                        _ = db.disponibilidad.Add(disp);
                        _ = db.SaveChanges();
                    }

                    ultimo = (from d in db.disponibilidad
                              select d.idHorario).FirstOrDefault();

                    if (miercoles.Contains('x'))
                    {
                        disponibilidad disp = new disponibilidad
                        {
                            idHorario = ultimo + 1,
                            profesor = "21443",
                            dia = 4,
                            horas = miercoles
                        };
                        _ = db.disponibilidad.Add(disp);
                        _ = db.SaveChanges();
                    }

                    ultimo = (from d in db.disponibilidad
                              select d.idHorario).FirstOrDefault();

                    if (jueves.Contains('j'))
                    {
                        disponibilidad disp = new disponibilidad
                        {
                            idHorario = ultimo + 1,
                            profesor = "21443",
                            dia = 5,
                            horas = jueves
                        };
                        _ = db.disponibilidad.Add(disp);
                        _ = db.SaveChanges();
                    }

                    ultimo = (from d in db.disponibilidad
                              select d.idHorario).FirstOrDefault();

                    if (viernes.Contains('v'))
                    {
                        disponibilidad disp = new disponibilidad
                        {
                            idHorario = ultimo + 1,
                            profesor = "21443",
                            dia = 6,
                            horas = viernes
                        };
                        _ = db.disponibilidad.Add(disp);
                        _ = db.SaveChanges();
                    }

                }

            }

            return View("Index", model);
        }



        public ActionResult DisponibilidadTodo ( )
        {
            // Codigo
            return PartialView();
        }

        public ActionResult DisponibilidadMatutino ( )
        {
            // Codigo
            return PartialView();
        }

        public ActionResult DisponibilidadVespertino ( )
        {
            // Codigo
            return PartialView();
        }


        public ActionResult DisponibilidadNocturno ( )
        {
            // Codigo
            return PartialView();
        }


    }

}