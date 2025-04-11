using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDBF.models;

public class Premium
{
    [Key]
    [DisplayName]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o titulo")]
    [StringLength(50, ErrorMessage = "O titulo deve conter no maximo 50 caracteres")]
    [MinLength(10, ErrorMessage = "O titulo deve conter pelo menos 10 caracteres")]
    [DisplayName("Titulo")]
    public string Titulo { get; set; } = string.Empty;
    
    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Inicio")]
    public DateTime Inicio { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Termino")]
    public DateTime Termino { get; set; }
    
    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno invalido")]
    public int StudentId { get; set; }
    
    public Student? Student { get; set; }
}