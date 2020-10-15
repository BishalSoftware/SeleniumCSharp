using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class EAPageObject
    {
        private readonly RemoteWebDriver _driver2;

        public EAPageObject(RemoteWebDriver driver2) => _driver2 = driver2;

        IWebElement txtInitial => _driver2.FindElementById("Initial");

        IWebElement txtFirstName => _driver2.FindElementById("FirstName");

        IWebElement txtMiddleName => _driver2.FindElementById("MiddleName");

        IWebElement btnSave => _driver2.FindElementByName("Save");
        
        public void FillUserForm(string initial, string firstName, string middleName)
        {
            //Setter
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);

            //Getter
            Console.WriteLine("Using extension method,the Initial is : " + txtInitial.GetText());
            Console.WriteLine("Using extension method,the First Name is : " + txtFirstName.GetText());
            Console.WriteLine("Using extension method,the Middle Name is  : " + txtMiddleName.GetText());

            Thread.Sleep(5000);
            btnSave.ClickExt();

            /*
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);

            Console.WriteLine("The Initial is : " + SeleniumGetMethods.GetText(txtInitial));
            Console.WriteLine("The First Name is : " + SeleniumGetMethods.GetText(txtFirstName));
            Console.WriteLine("The Middle Name is  : " + SeleniumGetMethods.GetText(txtMiddleName));

            Thread.Sleep(5000);
            SeleniumSetMethods.Click(btnSave);
            */
        }
    }
}
