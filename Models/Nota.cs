using System.ComponentModel.DataAnnotations;


namespace Backend2.Models

{
    public class Nota
    {
      [Key]
      public int Id { get; set; }
      public string? Nombre { get; set; }
      public string? Descripcion { get; set; }
      public DateTime? FechaCreation { get; set; }
      public DateTime? HoraModificacion { get; set; }
      public string? Estado { get; set; }
      public string? id_Categoria { get; set; }


    

  }

}

