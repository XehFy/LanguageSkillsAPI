using LanguageSkillsAPI.Data.Entities;
using LanguageSkillsAPI.Data.Repositories;
using LanguageSkillsAPI.Infrastructure.GoogleTranslation;
using Microsoft.AspNetCore.Mvc;

namespace LanguageSkillsAPI.Controllers
{
    [ApiController]
    [Route("LangSkill")]
    public class CardController : Controller
    {
        private ICardRepository CardRepository { get; set; }

        public CardController(ICardRepository cardRepository)
        {
            CardRepository = cardRepository;
        }

        [HttpGet]
        [Route("/GetCard")]

        public async Task<IEnumerable<Card>> GetCard([FromQuery]int lastId )
        {
            IEnumerable<Card> cards = await CardRepository.GetWhere(card => card.Id > lastId);
            return cards;
        }

        [HttpPost]
        [Route("/CreateCards")]

        public IActionResult CreateCards(List<Card> cardsAdd)
        {
            var tranlator = new GoogleTranslator();
            foreach (Card card in cardsAdd)
            {
                tranlator.Translate(card);
            }
            CardRepository.AddList(cardsAdd);
            return Ok();
        }

                      
    }
}
