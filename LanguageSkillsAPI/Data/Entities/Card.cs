using LanguageSkillsAPI.Data.Infrastructure.Enums;

namespace LanguageSkillsAPI.Data.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string? Word { get; set; }
        public string? Example { get; set; }
        public int Rating { get; set; }
        public Languages language { get; set; }
        public bool IsActive { get; set; }

        public ICollection<CardTranslation> cardTranslations { get; set; }
    }
}
