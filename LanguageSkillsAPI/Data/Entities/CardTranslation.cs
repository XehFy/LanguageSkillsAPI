using LanguageSkillsAPI.Data.Infrastructure.Enums;


namespace LanguageSkillsAPI.Data.Entities
{
    public class CardTranslation
    {
        public int Id;
        public int OriginalId;
        public string? ExampleTranslation { get; set; }
        public languages Language;
        public string? Translate;
    }
}
