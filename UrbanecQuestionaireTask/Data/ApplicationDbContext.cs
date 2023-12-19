using Microsoft.EntityFrameworkCore;
using UrbanecQuestionaireTask.Data.Model;

namespace UrbanecQuestionaireTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Credit> Credits { get; set; }
    }
}
