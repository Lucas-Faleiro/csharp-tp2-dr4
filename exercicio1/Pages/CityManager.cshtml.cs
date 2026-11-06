using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio1.Pages
{
    public class CityManagerModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; } = string.Empty;
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
