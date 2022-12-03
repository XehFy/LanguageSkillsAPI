using YandexLinguistics.NET.Dictionary;
using LanguageSkillsAPI.Data.Entities;

namespace LanguageSkillsAPI.Infrastructure.TranslationAPI
{
    public class YandexDictionary
    {
        public string key = "dict.1.1.20221125T183730Z.1ff12fda3483c48f.527ce68c1d508b6510c60a1df0df9d0460492081";

        public async void GetTranslations(Card card, string targetLang)
        {

            var Dictionary = new DictionaryService(key);
            var lp = new YandexLinguistics.NET.LanguagePair
                (YandexLinguistics.NET.Language.En, YandexLinguistics.NET.Language.Ru);
            var result = await Dictionary.LookupAsync(lp, card.Word);
            string translate = "";
            foreach(var definition in result.Definitions)
            {
                foreach(var Translation in definition.Translations)
                {
                    var text = Translation.Text;
                    translate += text;
                    translate += ", ";
                }
            }
            var translateCard = new CardTranslation {
                Language = targetLang,
                Translate = translate };
            card.cardTranslations.Add(translateCard);
        }

    }
}
