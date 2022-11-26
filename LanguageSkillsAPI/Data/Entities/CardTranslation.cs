using LanguageSkillsAPI.Data.Infrastructure.Enums;


namespace LanguageSkillsAPI.Data.Entities
{
    public class CardTranslation
    {
        public int Id { get; set; }
        public string? ExampleTranslation { get; set; }
        public string Language { get; set; }    
        public string? Translate { get; set; }
    }
}
