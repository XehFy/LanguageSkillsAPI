using Google.Cloud.Translation.V2;
using LanguageSkillsAPI.Data.Entities;

namespace LanguageSkillsAPI.Infrastructure.GoogleTranslation
{
    public class GoogleTranslator
    {
        TranslationClient client = TranslationClient.CreateFromApiKey("AIzaSyA_PX6UNG1laDJquPfMBvVYxBMtdwL00cc");
        public void Translate(Card card)
        {
            var response = client.TranslateText(card.Word, LanguageCodes.Russian , LanguageCodes.English);
            card.cardTranslations.Add(new CardTranslation
            { Translate = response.TranslatedText });
        }
    }
}
