using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google Page
            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Window.Maximize();

            //Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operation
            element.SendKeys("selenium with C#");

            element.SendKeys(Keys.Enter);
        }
    }
}
