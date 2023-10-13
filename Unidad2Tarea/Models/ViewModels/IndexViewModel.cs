namespace Unidad2Tarea.Models.ViewModels
{
	public class IndexViewModel
	{
		public List<Raza> razas { get; set; } = null!;
	}

	public  class Raza
	{
		public int Id { get; set; }

		public string Nombre { get; set; } = null!;
	}

}
