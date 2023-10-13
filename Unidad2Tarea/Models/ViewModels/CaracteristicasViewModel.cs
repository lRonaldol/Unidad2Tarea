using Unidad2Tarea.Models.Entities;

namespace Unidad2Tarea.Models.ViewModels
{
    public class CaracteristicasViewModel
    { public Razas Perrros { get; set; } = null!;
        public List<Raza> Animales { get; set; } = null!;
        public Razas Raza { get; internal set; }
    }
}
