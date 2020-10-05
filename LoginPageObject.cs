﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class LoginPageObject
    {
        [Obsolete]
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName
        {
            get;
            set;
        }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassowrd
        {
            get;
            set;
        }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin
        {
            get;
            set;
        }

        [Obsolete]
        public EAPageObject Login(string userName, string password)
        {
            //UserName
            txtUserName.SendKeys(userName);

            //Password
            txtPassowrd.SendKeys(password);

            Thread.Sleep(7000);

            //Click Button
            btnLogin.Submit();


            //Return the page object
            return new EAPageObject();
        }



    }
}
