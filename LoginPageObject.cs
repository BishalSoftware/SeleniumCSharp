using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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

        public void Login(string userName, string password)
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
        }
    }
}
