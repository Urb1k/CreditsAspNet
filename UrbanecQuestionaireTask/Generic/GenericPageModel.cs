using Microsoft.AspNetCore.Mvc.RazorPages;
using UrbanecQuestionaireTask.Data;

namespace UrbanecQuestionaireTask.Generic
{
    public class GenericPageModel:PageModel
    {

        internal ApplicationDbContext _context;

        public string Message { get; set; } = String.Empty;

    }
}
