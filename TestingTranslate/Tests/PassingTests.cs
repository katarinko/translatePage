using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using TestingTranslate.Core;
using TestingTranslate.Core.Helpers;
using OpenQA.Selenium.Interactions;
using System.IO;
using OpenQA.Selenium.Support.Extensions;
using System.Collections.ObjectModel;
using Umbraco.Site.UITests.Core;
using TestingTranslate.Pages;
using TestingTranslate.Tests;

namespace TestingTranslate.Tests
{
    [TestFixture]

    class PassingTests : BaseTest
    {
        [Test, Order(1)]
        public void TestTranslateEnglishTextToUkraine()
        {
            //test steps
            var translatePage = new TranslatePage();
            var traslateAction = new TranslateActions();
            traslateAction.TypeEnglishText(Data.enText);

            Assert.AreEqual(Data.ukText, translatePage.GetTranslateText(), "Translate is not correct");
            traslateAction.SwapLanguage();
            traslateAction.TypeUkraineText(Data.ukText);
            Commons.Sleep(5000);
            Assert.AreEqual(Data.enText, translatePage.GetTranslateText(), "Translate is not correct");

        }
        /* [Test, Order(2)]

         public void TestTranslateUkraineTextToEnglis()
         {
             //test steps
             var translatePage = new TranslatePage();
             var traslateAction = new TranslateActions();
             traslateAction.TypeUkraineText(Data.ukText);

             Assert.AreEqual(Data.ukText, translatePage.GetTranslateText(), "Translate is not correct");
         }*/
    }
}
