using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio11.Pages
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();
        public string FileName { get; set; } = string.Empty;
        public List<string> Files { get; set; } = new();
        private string FolderPath => Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");
        public string? SelectedContent { get; set; }
        public void OnGet(string? file)
        {
            LoadFiles();

            if (!string.IsNullOrEmpty(file))
            {
                string filePath = Path.Combine(FolderPath, Path.GetFileName(file));
                if (System.IO.File.Exists(filePath))
                {
                    SelectedContent = System.IO.File.ReadAllText(filePath);
                }
            }
        }

        public void OnPost()
        {
            Directory.CreateDirectory(FolderPath);

            string timestamp = DateTime.Now.ToString("ddMMyyyyHHmmss");
            FileName = $"note-{timestamp}.txt";

            string filePath = Path.Combine(FolderPath, FileName);
            System.IO.File.WriteAllText(filePath, Input.Content);

            LoadFiles();
        }
        private void LoadFiles()
        {
            Directory.CreateDirectory(FolderPath);
            Files = Directory.GetFiles(FolderPath, "*.txt").Select(Path.GetFileName).ToList();
        }
    }

    public class InputModel
    {
        public string Content { get; set; } = string.Empty;
    }
}
