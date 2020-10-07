﻿using NUnit.Framework;
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
            /*
             PropertiesCollection.driver = new ChromeDriver();

             //Navigate to execute automation Page
             PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");

             PropertiesCollection.driver.Manage().Window.Maximize();
            */

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");

            driver.Manage().Window.Maximize();

            Console.WriteLine("Opened and maximized execute automation selenium test site webpage.");
        }


        [Test]
        [Obsolete]
        public void ExecuteTest()
        {
            //Login to Application

            //LoginPageObject pageLogin = new LoginPageObject();
            LoginPageObject pageLogin = new LoginPageObject(driver);

            EAPageObject pageEA = pageLogin.Login("execute", "pass_auto");

            pageEA.FillUserForm("BP", "Bishal", "Programmer");

            //logging
            Console.WriteLine("The test is executed.");
        }


        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(5000);

            //PropertiesCollection.driver.Quit();
            driver.Quit();

            Console.WriteLine("The last opened browser is closed.");
        }
    }
}
