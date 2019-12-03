using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using TestingTranslate.Core;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace TestingTranslate.Pages 
   {
    public class TranslatePage 
    {

        //By TextTabLocator = By.CssSelector(".text-icon");
        By TextTabLocator = By.XPath("//*[contains(@class, 'text-icon')]");
        By DocumentTabLocator = By.XPath("//*[contains(@class, 'documents-icon')]");
        By LeftTextreaLocator = By.XPath("//textarea[@id='source']");
        By RightTextareaLocator = By.CssSelector(".translation > span");
        By LeftLanguageListButton = By.XPath("//div[contains(@class,'sl-more' )]");
       // By CheckMarkLocator = By.XPath("//div[contains(@class,'sl_list_en_checkmark')]");
        By LeftUkCheckMark = By.XPath("//div[contains(@class,'sl_list_uk_checkmark')]");
        String CheckMarkLocator = "//div[contains(@class,'%s')]";
        //public const string englishCheckMark = "sl_list_en_checkmark";
        By RightLanguageListButton = By.XPath("//div[contains(@class,'tl-more')]");
        By RightUkCheckMark = By.XPath("//div[contains(@class,'tl_list_uk_checkmark')]");
        By RightEnCheckMark = By.XPath("//div[contains(@class,'tl_list_en_checkmark')]");
        By SwapButtonLocator = By.XPath("//div[contains(@class,'swap')]//div[@class='jfk-button-img']");
        By ClearButtonLocator = By.XPath("//div[contains(@class,'clear')]//div[@class='jfk-button-img']");

        public TranslatePage SelectTextTab()
        {
            Element.WaitUntilDisplayed(TextTabLocator, 5000);
            Element.Click(TextTabLocator);
            return this;
        }

        public TranslatePage SelectDocumentTab()
        {
            Element.WaitUntilDisplayed(DocumentTabLocator, 5000);
            Element.Click(DocumentTabLocator);
            return this;
        }

       /* public void SelectEnglishLanguage()
        {
            Element.Click(LeftLanguageListButton);
            Element.WaitUntilDisplayed(CheckMarkLocator, 5000);
            Element.Click(CheckMarkLocator);
         }*/

         public TranslatePage SelectLanguage(String language)
         {
            By locator = By.XPath(String.Format(CheckMarkLocator, language));
            Element.Click(locator);
            return this;
        }
              
        public TranslatePage SelectUkranianLanguage()
        {
            Element.Click(RightLanguageListButton);
            Element.WaitUntilDisplayed(RightUkCheckMark, 5000);
            Element.Click(RightUkCheckMark);
            return this;
        }

        public TranslatePage TypeText(string text)
        {
            Element.InputText(LeftTextreaLocator, text);
            return this;
        }

        public string GetTranslateText()
        {
            Element.WaitUntilDisplayed(RightTextareaLocator, 5000);
            return Element.FindElement(RightTextareaLocator).Text;
        }

        public TranslatePage SwapButton()
        {
            Element.Click(SwapButtonLocator);
            return this;
        }

        public TranslatePage ClearText()
        {
            Element.Click(ClearButtonLocator);
            return this;
        }

    }
}
