using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UrbanecQuestionaireTask.Data;
using UrbanecQuestionaireTask.Data.Model;
using UrbanecQuestionaireTask.Generic;

namespace UrbanecQuestionaireTask.Pages
{
    public class IndexModel : GenericPageModel
    {
        private readonly ILogger<IndexModel> _logger;


        [BindProperty]
        public Credit Credit { get; set; } = new Credit();


        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Credit.Created = DateTime.Now;

            _context.Credits.Add(Credit);
            _context.SaveChanges();

            Message = $"Výsledek byl uložen do databáze!!!";

            Credit = new Credit();

            ModelState.Clear();

            return Page();
        }

        
        public void OnGet()
        {

        }
    }
}
