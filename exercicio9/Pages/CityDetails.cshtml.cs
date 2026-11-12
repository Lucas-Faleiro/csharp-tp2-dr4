using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio9.Pages
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; set; } = string.Empty;

        public void OnGet(string cityName)
        {
            CityName = cityName;
        }
    }
}
