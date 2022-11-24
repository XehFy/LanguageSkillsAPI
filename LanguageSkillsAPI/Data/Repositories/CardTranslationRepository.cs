using LanguageSkillsAPI.Data.Entities;

namespace LanguageSkillsAPI.Data.Repositories
{
    public class CardTranslationRepository : BaseRepository<CardTranslation>, ICardTranslationRepository
    {
        public CardTranslationRepository(ApiContext context) : base(context) { }

        // функции нужные только для переводов карточек
    }
}
