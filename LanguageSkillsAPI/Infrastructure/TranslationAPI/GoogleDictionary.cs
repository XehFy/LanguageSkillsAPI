using LanguageSkillsAPI.Data.Entities;
using Jurassic;
using Microsoft.AspNetCore.NodeServices;
using Jering.Javascript.NodeJS;

namespace LanguageSkillsAPI.Infrastructure.TranslationAPI
{
    public class GoogleDictionary
    {
        private string key = "AIzaSyA_PX6UNG1laDJquPfMBvVYxBMtdwL00cc";
        public INodeJSService NodeServices;

        public GoogleDictionary(INodeJSService nodeServices)
        {
            NodeServices = nodeServices;    
        }

        public async Task Translate(Card card, string targetLang)
        {

            object[] arr = { card.Word, card.Language, targetLang};

            var result = await NodeServices.InvokeFromFileAsync<string>("C:/Users/Home/source/repos/LanguageSkillsAPI/LanguageSkillsAPI/Infrastructure/TranslationAPI/JsGoogleAPI/Translator.js", args: arr);

            var translatedCard = new CardTranslation
            {
                Translate = result,
                Language = targetLang
            };
            card.cardTranslations.Add(translatedCard);
        }
    }
}
