using DC_DentalCare.Models;
using Microsoft.AspNetCore.Mvc;

namespace DC_DentalCare.Controllers
{
    public class ReservaController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            //se declara la lista afuera para tener scope global, el signo de pregunta quiere decir que puede 
            //recibir valores nulos.-
            List<Fecha>? fechas = null;

            using (ReservaContext context = new())
            {
                //usamos la variable y listamos
                fechas = context.Fechas.ToList();
            }

            return View(fechas);
        }

        [HttpPost]
        public IActionResult GuardarFecha(Fecha Fecha)
        {
            using (ReservaContext context = new())
            {

                //guarda de forma lógica el cliente, no lo guarda en la base de datos
                context.Fechas.Add(Fecha);
                //esta última línea es la que guarda en la base de datos
                context.SaveChanges();
            }


            return RedirectToAction(nameof(Index),"Home");
        }




    }
}
