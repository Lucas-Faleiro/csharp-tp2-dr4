using exercicio12.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio12.Pages
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();
        public Country? SubmittedCountry { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Input.CountryName) && !string.IsNullOrEmpty(Input.CountryCode))
            {
                if (char.ToUpper(Input.CountryName[0]) != char.ToUpper(Input.CountryCode[0]))
                {
                    ModelState.AddModelError("Input.CountryCode", "O código deve começar com a mesma letra que o nome do país");
                }
            }

            if (!ModelState.IsValid)
            {
                return;
            }
            SubmittedCountry = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode,
            };
        }
    }
}