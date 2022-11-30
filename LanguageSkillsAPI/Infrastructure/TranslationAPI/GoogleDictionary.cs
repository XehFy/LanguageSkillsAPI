using LanguageSkillsAPI.Data.Entities;
using Jurassic;
using Microsoft.AspNetCore.NodeServices;
using Jering.Javascript.NodeJS;

namespace LanguageSkillsAPI.Infrastructure.TranslationAPI
{
    public class GoogleDictionary
    {

        private string key = "AIzaSyA_PX6UNG1laDJquPfMBvVYxBMtdwL00cc";
        INodeJSService NodeServices;

        public GoogleDictionary(INodeJSService nodeServices)
        {
            NodeServices = nodeServices;    
        }

        public async Task Translate(string word, string origLang, string targetLang)
        {
            object[] arr = { word, origLang, targetLang};


            var result = await NodeServices.InvokeFromFileAsync<string>("C:/Users/Home/source/repos/LanguageSkillsAPI/LanguageSkillsAPI/Infrastructure/TranslationAPI/Translator.js", args: arr);


            Console.WriteLine(result);
        }
    }
}
