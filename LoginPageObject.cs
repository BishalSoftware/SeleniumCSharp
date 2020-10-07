using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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
        private readonly RemoteWebDriver _driver1;

        public LoginPageObject(RemoteWebDriver driver1) => _driver1 = driver1;

        IWebElement txtUserN => _driver1.FindElementByName("UserName");

        IWebElement txtPass => _driver1.FindElementByName("Password");

        IWebElement btnLog => _driver1.FindElementByName("Login");


        /*
        [Obsolete]
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserN
        {
            get;
            set;
        }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPass
        {
            get;
            set;
        }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLog
        {
            get;
            set;
        }
        */

        [Obsolete]
        public EAPageObject Login(string userName, string password)

        {
            SeleniumSetMethods.EnterText(txtUserN, userName);
            SeleniumSetMethods.EnterText(txtPass, password);

            Console.WriteLine("The User Name is : " + SeleniumGetMethods.GetText(txtUserN));
            Console.WriteLine("The Password is : " + SeleniumGetMethods.GetText(txtPass));

            Thread.Sleep(5000);
            SeleniumSetMethods.Submit(btnLog);
            Thread.Sleep(5000);

            /*
            //UserName
            txtUserN.SendKeys(userName);
            //Password
            txtPass.SendKeys(password);
            Thread.Sleep(7000);
            //Click Button
            btnLog.Submit();
            */

            //Return the page object

            //return new EAPageObject();
            return new EAPageObject(_driver1);
        }

    }
}
