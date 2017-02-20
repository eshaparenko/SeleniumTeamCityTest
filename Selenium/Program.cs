using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://google.com");


            PageFactory.InitElements(driver, Page.GooglePage);
            Page.GooglePage.input.SendKeys("selenium");
            driver.Close();
        }
    }

    public class GooglePage
    {
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement input { get; set; }
    }
    public class Page
    {
        public static GooglePage GooglePage = new GooglePage();
    }
}
