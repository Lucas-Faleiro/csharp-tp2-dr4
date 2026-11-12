using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio9.Pages
{
    public class CitiesModel : PageModel
    {
        public List<string> Cities = ["Rio", "São Paulo", "Brasília"];
        public void OnGet()
        {
        }
    }
}
