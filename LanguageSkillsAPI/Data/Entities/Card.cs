

namespace LanguageSkillsAPI.Data.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string? Word { get; set; }
        public string? Example { get; set; }
        public int Rating { get; set; }
        public string Language { get; set; }
        public bool IsVerified { get; set; }
        public int? UserRating { get; set; }

        public ICollection<CardTranslation>? cardTranslations { get; set; }
    }
}
