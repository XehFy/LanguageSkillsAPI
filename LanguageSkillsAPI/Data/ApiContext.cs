using LanguageSkillsAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LanguageSkillsAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardTranslation> CardTranslations { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }

}
