namespace LanguageSkillsAPI.Data.Entities
{
    public class Card
    {
        public int Id;
        public string? Word;
        public string? Example { get; set; }
        public DateTime LastRepeat { get; set; }
        public DateTime NextRepeat { get; set; }
        public int RepeatCounter { get; set; }
        public int Rating { get; set; }
        public byte StudyStage { get; set; }
        public bool IsActive;
    }
}
