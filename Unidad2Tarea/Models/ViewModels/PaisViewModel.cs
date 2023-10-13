using Unidad2Tarea.Models.Entities;

namespace Unidad2Tarea.Models.ViewModels
{
    public class PaisViewModel
    {

       
        public int Id { get;  set; }
        public string Nombre { get; set; } = null!; 
           public List <Raza>  Razas { get; set; }=null!;
    } 

}
