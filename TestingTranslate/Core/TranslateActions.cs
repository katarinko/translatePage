using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingTranslate.Pages;

namespace TestingTranslate.Core
{
    public class TranslateActions
    {
        public const string englishCheckMark = "sl_list_en_checkmark";

        public void TypeEnglishText(string text)
        {
            new TranslatePage()
                .SelectDocumentTab()
                .SelectTextTab()
                .SelectLanguage(englishCheckMark)
                .SelectUkranianLanguage()
                .TypeText(text);
        }
        public void TypeUkraineText(string text)
        {
            var translatePage = new TranslatePage();
            translatePage.SelectDocumentTab();
            translatePage.SelectTextTab();
            //translatePage.SelectUkranianLanguage();
            //translatePage.SelectEnglishLanguage(); 
            translatePage.TypeText(text);
        }

        public void SwapLanguage()
        {
            var translatePage = new TranslatePage();
            translatePage.SwapButton();
            translatePage.ClearText();

        }
    }
}