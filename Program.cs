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
                driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");

                driver.Manage().Window.Maximize();

                Console.WriteLine("Opened and maximized execute automation selenium test site webpage.");
            }

            [Test]
            public void ExecuteTest()
            {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "id", "TitleId", "Mr.");

            //Initial
            SeleniumSetMethods.EnterText(driver, "id", "Initial", "BP");

            //Save
            SeleniumSetMethods.Click(driver, "name", "Save");

            //Getter for Title
            Console.WriteLine("The value from Title is: " + SeleniumGetMethods.GetSelectedDropDown(driver, "id", "TitleId"));

            //Getter for Initial
            Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText(driver, "id", "Initial"));



            //logging
            Console.WriteLine("The test is executed.");
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
