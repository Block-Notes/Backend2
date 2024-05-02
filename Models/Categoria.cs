using System.ComponentModel.DataAnnotations;


namespace Backend2.Models

{
    public class Categoria
    {
      [Key]
      public int Id { get; set; }
      public string? Nombre { get; set; }


    

  }

}