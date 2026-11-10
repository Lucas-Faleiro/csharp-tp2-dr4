using exercicio7.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio7.Pages
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Input { get; set; } = new();
        public List<Country>? SubmittedCountries { get; set; } = new();
        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                Input.Add(new InputModel());
            }
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            foreach (var country in Input)
            {
                SubmittedCountries.Add(new Country
                {
                    CountryName = country.CountryName,
                    CountryCode = country.CountryCode,
                });
            }
        }
    }
}