using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace exercicio4.Pages
{
    public class CityManagerModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();
        public string? SubmittedCity { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            SubmittedCity = Input.CityName;
        }
    }

    public class InputModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        public string CityName { get; set; } = string.Empty;
    }
}
