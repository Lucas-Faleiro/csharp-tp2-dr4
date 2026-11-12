using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio10.Pages
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();
        public string FileName { get; set; } = string.Empty;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
            Directory.CreateDirectory(folderPath);

            string timestamp = DateTime.Now.ToString("ddMMyyyyHHmmss");
            FileName = $"note-{timestamp}.txt";

            string filePath = Path.Combine(folderPath, FileName);
            System.IO.File.WriteAllText(filePath, Input.Content);
        }
    }

    public class InputModel
    {
        public string Content { get; set; } = string.Empty;
    }
}
