using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using Umbraco.Site.UITests.Core;
using OpenQA.Selenium.Interactions;



namespace TestingTranslate.Core
{
    public static class Element
    {
        public static IWebElement FindElement(By locator)
        {
            return WebDriverManager.GetWebDriver().FindElement(locator);
        }

        public static List<IWebElement> FindElements(By locator)
        {
            return WebDriverManager.GetWebDriver().FindElements(locator).ToList();
        }

        public static void ClearField(By locator)
        {
            FindElement(locator).Clear();
        }

        public static void InputText(By locator, String text)
        {
            FindElement(locator).SendKeys(text);
        }

        public static void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public static void ErrorMessageView(By locator)
        {
            FindElement(locator);

        }

        /*public static IWebDriver SwitctToWindow()
        {
            return IWebDriverManager.GetWebDriver();
        }*/

        public static void WaitUntilDisplayed(By locator, int timeout)
        {
            int counter = 0;
            int step = 100;
            while (counter < timeout && !IsElementDisplayed(locator))
            {
                counter += step;
                Commons.Sleep(step);
            }
        }

        public static Boolean IsElementDisplayed(By locator)
        {
            try
            {
                return FindElement(locator).Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }

 }

}
