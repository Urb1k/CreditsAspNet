using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UrbanecQuestionaireTask.Data;
using UrbanecQuestionaireTask.Data.Model;
using UrbanecQuestionaireTask.Generic;

namespace UrbanecQuestionaireTask.Pages.CreditPages
{

    public class IndexModel : GenericPageModel
        {

            public List<Credit> Credits { get; set; } = new List<Credit>();

            public IndexModel(ApplicationDbContext context)
            {
                _context = context;
            }
            public void OnGet()
            {
                Credits = _context.Credits.ToList();
            }
       
    }
}
