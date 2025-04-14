using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDBF.models;

public class Student
{
    [Key]
    [DisplayName]
    public int Id { get; set; } 
    
    [Required(ErrorMessage = "informe o nome")]
    [StringLength(50, ErrorMessage = "O nome deve conter no maximo 50 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter no minimo 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Nome { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Informe o email")]
    [EmailAddress(ErrorMessage = "E-mail invalido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();

}