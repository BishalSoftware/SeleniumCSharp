using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class Program
    {
        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

            [SetUp]
             public void Initialize()
            {
                //Navigate to Google Page
                driver.Navigate().GoToUrl("https://www.google.com/");

                driver.Manage().Window.Maximize();

            Console.WriteLine("Opened and maximized google webpage.");
            }

            [Test]
            public void ExecuteTest()
            {
                //Find the Element
                IWebElement element = driver.FindElement(By.Name("q"));

                //Perform Operation
                element.SendKeys("selenium with C#");

                //search for keywords in google by hitting 'enter' command
                element.SendKeys(Keys.Enter);

            Console.WriteLine("The test is executed.");
            }

            
            [Test]
            public void NextTest()
            {
            Console.WriteLine("The Next second test is executed.");
            }



            [TearDown]
            public void CleanUp()
            {
                Thread.Sleep(2000);
                driver.Close();

            Console.WriteLine("The last opened browser is closed.");
            }       
    }
}
