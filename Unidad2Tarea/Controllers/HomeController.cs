using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unidad2Tarea.Models.Entities;
using Unidad2Tarea.Models.ViewModels;

namespace Unidad2Tarea.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            PerrosContext context = new PerrosContext();
            var datos = context.Razas.OrderBy(x => x.Nombre).Select(x => new Raza
            {
                Id = (int)x.Id,
                Nombre = x.Nombre
            });

            return View(datos);
        }

        public IActionResult Pais()
        {
            PerrosContext context = new PerrosContext();
            var razasporpais = context.Razas.Include(x => x.IdPaisNavigation)
                .OrderBy(x => x.IdPais)
                .ToList();

            var PVM = razasporpais.GroupBy(x => x.IdPaisNavigation).Select
                (group => new PaisViewModel
                {
                    Id = group.Key.IdPais,
                    Nombre = group.Key.Nombre??"",
                    Razas = group.Select(raza => new Raza
                    {
                        Id = (int)raza.Id,
                        Nombre = raza.Nombre
                    }).ToList()
                }).ToList();

            return View(PVM);


        }
        public IActionResult Caracteristicas(string Id)
        {
            PerrosContext c = new PerrosContext();
            CaracteristicasViewModel viewModel = new CaracteristicasViewModel();

            
            Razas raza = c.Razas.Include(x => x.Estadisticasraza)
                               .Include(x => x.Caracteristicasfisicas)
                               .FirstOrDefault(x => x.Nombre == Id);

            if (raza != null)
            {

                viewModel.Perrros = raza;
                    }
            else
            {
               
                return View(Index); 
            }

            return View(viewModel);
        }


        
    }
}


    

