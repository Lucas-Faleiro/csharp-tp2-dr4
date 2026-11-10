using System.ComponentModel.DataAnnotations;

namespace exercicio6.Model
{
    public class InputModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string CountryName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Código é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Código precisa ter exatamente 2 caracteres")]
        public string CountryCode { get; set; } = string.Empty;
    }
}
