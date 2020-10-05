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
        static void Main(string[] args)
        {
        }

            [SetUp]
             public void Initialize()
             {
             PropertiesCollection.driver = new ChromeDriver();

             //Navigate to Google Page
             PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");

             PropertiesCollection.driver.Manage().Window.Maximize();

             Console.WriteLine("Opened and maximized execute automation selenium test site webpage.");
             }

            [Test]
        [Obsolete]
        public void ExecuteTest()
            {

            //Initialize the page by calling its reference
            EAPageObject page = new EAPageObject();

          //  page.ddlTitleID.("Mr.");

            page.txtInitial.SendKeys("BP");

            page.btnSave.Click();

            //logging
            Console.WriteLine("The test is executed.");

            /*
            //Setter for Title
            SeleniumSetMethods.SelectDropDown(PropertyType.id, "TitleId", "Mr.");

            //Setter for Initial
            SeleniumSetMethods.EnterText(PropertyType.id, "Initial", "BP");

            //Setter for Save
            SeleniumSetMethods.Click(PropertyType.name, "Save");

            //Getter for Title
            Console.WriteLine("The value from Title is: " + SeleniumGetMethods.GetSelectedDropDown(PropertyType.id, "TitleId"));

            //Getter for Initial
            Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText(PropertyType.id, "Initial"));              
            */
        }

                 
            [TearDown]
            public void CleanUp()
            {
                Thread.Sleep(7000);
            PropertiesCollection.driver.Close();

            Console.WriteLine("The last opened browser is closed.");
            }       
    }
}
