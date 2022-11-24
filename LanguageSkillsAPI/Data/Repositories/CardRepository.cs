using LanguageSkillsAPI.Data.Entities;

namespace LanguageSkillsAPI.Data.Repositories
{
    public class CardRepository : BaseRepository<Card>, ICardRepository
    {
        public CardRepository(ApiContext context) : base(context) { }

        //Функции нужные только для карточек
    }
}
