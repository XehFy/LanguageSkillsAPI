using LanguageSkillsAPI.Infrastructure.Languages;
using Jering.Javascript.NodeJS;
using LanguageSkillsAPI.Data.Entities;

namespace LanguageSkillsAPI.Infrastructure.TranslationAPI
{
    public class Translator
    {
        YandexDictionary YandexDictionary = new YandexDictionary();
        GoogleDictionary GoogleDictionary;
        GoogleTranslator GoogleTranslator = new GoogleTranslator();

        public Translator(INodeJSService nodeJSService)
        {
            GoogleDictionary = new GoogleDictionary(nodeJSService);
        }
        public async Task Translate(List<Card> list, string targetLang)
        {
            var sourceLang = list.First().Language;
            if(!Languages.Languages.Google.ContainsKey(sourceLang))
            {
                throw new Exception($"Language {sourceLang} is not supported");
            }
            if (!Languages.Languages.Google.ContainsKey(targetLang))
            {
                throw new Exception($"Language {targetLang} is not supported");
            }
            var pair = sourceLang + "-" + targetLang;
            if (Languages.Languages.YandexPairs.Contains(pair))
            {
                Console.WriteLine("yandex");
                foreach (Card card in list) 
                {
                    YandexDictionary.GetTranslations(card, targetLang);
                }
            } 
            else
            {
                Console.WriteLine("goohgle");
                foreach (Card card in list)
                {
                    await GoogleDictionary.Translate(card, targetLang);
                    await Task.Delay(1000);
                }
            };
        }
    }
}
