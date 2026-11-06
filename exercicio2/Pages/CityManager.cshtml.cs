using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio2.Pages
{
    public class CityManagerModel : PageModel
    {
        public string CityName { get; set; } = string.Empty;
        public void OnGet()
        {
        }

        public void OnPost(string cityName)
        {
            CityName = cityName;
        }
    }
}
