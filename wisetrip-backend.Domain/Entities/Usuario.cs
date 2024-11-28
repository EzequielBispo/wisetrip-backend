using System;
using System.ComponentModel.DataAnnotations;

namespace wisetrip_backend.Entities;

public class Usuario
{
    [Key]
    [Required]
    int Id { get; set; }
    String Nome { get; set; }
    String Sobrenome { get; set; }

    [Required]
    String Email { get; set; }

    [Required]
    String Password { get; set; }

}