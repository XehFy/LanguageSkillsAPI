using LanguageSkillsAPI.Data.Entities;
using LanguageSkillsAPI.Data.Repositories;
using LanguageSkillsAPI.Infrastructure.TranslationAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.NodeServices;
using Jering.Javascript.NodeJS;

namespace LanguageSkillsAPI.Controllers
{
    [ApiController]
    [Route("LangSkill")]
    public class CardController : Controller
    {
        private ICardRepository CardRepository { get; set; }

        INodeJSService NodeServices;
        public CardController(ICardRepository cardRepository, INodeJSService nodeServices)
        {
            CardRepository = cardRepository;
            NodeServices = nodeServices;
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

        public async Task CreateCards(List<Card> cardsAdd)
        {
            GoogleDictionary translator = new GoogleDictionary(NodeServices);
            foreach (Card card in cardsAdd)
            {
                await translator.Translate(card.Word, "en", "ru");
            }
            CardRepository.AddList(cardsAdd);
        }

                      
    }
}
