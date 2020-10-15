using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
        private RemoteWebDriver driver;

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");

            driver.Manage().Window.Maximize();

            Console.WriteLine("Opened and maximized execute automation selenium test site webpage.");
        }

        [Test]
        [Obsolete]
        public void ExecuteTest()
        {
            // ExcelLib.PopulateInCollection("./data.xlsx");
            ExcelLib.PopulateInCollection(@"C:\csharp\selenium_projects\SeleniumCSharp\data.xlsx");

            //string userNa = ExcelLib.ReadData(1, "UserName");
            //string passWo = ExcelLib.ReadData(1, "Password");

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject(driver);

            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1,"UserName"), ExcelLib.ReadData(1,"Password"));

            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));

            //logging in Console
            Console.WriteLine("The test is executed.");
        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(5000);
            driver.Quit();

            Console.WriteLine("The last opened browser is closed.");
        }
    }
}
