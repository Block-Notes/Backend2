using System.ComponentModel.DataAnnotations;


namespace Backend2.Models

{
    public class Nota
    {
      [Key]
      public int id { get; set; }
      public string? Titulo { get; set; }
      public string? Descripcion { get; set; }
      public DateTime? FechaCreacion { get; set; }
      public DateTime? HoraModificacion { get; set; }
      public string? Estado { get; set; }
      public int? id_Categoria { get; set; }


    

  }

}

