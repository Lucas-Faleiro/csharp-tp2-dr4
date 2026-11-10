using exercicio5.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio5.Pages
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