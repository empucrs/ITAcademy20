using System.ComponentModel.DataAnnotations;
namespace _01_Controller.Models;

public class CEPViewModel
{
    [Required]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "CEP deve conter 8 dígitos numéricos, sem separadores")]
    public string CEP{get; set; }
    [StringLength(maximumLength:30, ErrorMessage="A string não pode conter mais do que 30 caracteres e não pode ter menos do que 3", MinimumLength=3) ]
    public string logradouro{get; set; }
    [StringLength(maximumLength:30, ErrorMessage="A string não pode conter mais do que 30 caracteres e não pode ter menos do que 3", MinimumLength=3) ]
    public string Cidade {get; set; }
    [StringLength(maximumLength:30, ErrorMessage="A string não pode conter mais do que 30 caracteres e não pode ter menos do que 3", MinimumLength=3) ]
    public string Bairro {get; set; }
    [Required]
    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Estado deve conter dois caracteres maiúsculos") ]
    public string Estado {get; set; }
    public DateTime? DataDoCadastro {get; set; }
    public int numeroQq {get; set; }
}
