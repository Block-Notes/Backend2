using System.ComponentModel.DataAnnotations;


namespace Backend2.Models

{
    public class Papeleria
    {
      [Key]
      public int Id { get; set; }
      public string? Nombre { get; set; }


    

  }

}