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


        [Obsolete]
        public EAPageObject Login(string userName, string password)
        {
            //Setter
            txtUserN.EnterText(userName);
            txtPass.EnterText(password);

            //Getter
            Console.WriteLine("Using extension method,the User Name is : " + txtUserN.GetText());
            Console.WriteLine("Using extension method, the Password is : " + txtPass.GetText());

            Thread.Sleep(5000);
            btnLog.SubmitExt();
            Thread.Sleep(5000);

            /*
            SeleniumSetMethods.EnterText(txtUserN, userName);
            SeleniumSetMethods.EnterText(txtPass, password);

            Console.WriteLine("The User Name is : " + SeleniumGetMethods.GetText(txtUserN));
            Console.WriteLine("The Password is : " + SeleniumGetMethods.GetText(txtPass));

            Thread.Sleep(5000);
            SeleniumSetMethods.Submit(btnLog);
            Thread.Sleep(5000);
            */

            //Return the page object
            return new EAPageObject(_driver1);
        }
    }
}
