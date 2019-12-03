using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using TestingTranslate.Core;
using OpenQA.Selenium.Interactions;

namespace TestingTranslate.Core
{
    public class WebDriverManager
    {
        private static IWebDriver driver; 
          
        public static void SetWebDriver()
        {
            driver = new ChromeDriver(@"E:\test");
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        
        public static IWebDriver GetWebDriver()
        {
            return driver;
        }
        public static void CloseWebDriver()
        {
            driver.Close();
        }
    }
}