using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
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

        /*
         [Obsolete]
         public EAPageObject()
         {
             PageFactory.InitElements(PropertiesCollection.driver, this);
         }

         [FindsBy(How = How.Id, Using = "Initial")]
         public IWebElement txtInitial
         {
             get;
             set;
         }

         [FindsBy(How = How.Id, Using = "FirstName")]
         public IWebElement txtFirstName
         {
             get;
             set;
         }

         [FindsBy(How = How.Id, Using = "MiddleName")]
         public IWebElement txtMiddleName
         {
             get;
             set;
         }

         [FindsBy(How = How.Name, Using = "Save")]
         public IWebElement btnSave
         {
             get;
             set;
         }
         */

        public void FillUserForm(string initial, string firstName, string middleName)
        {
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);

            Console.WriteLine("The Initial is : " + SeleniumGetMethods.GetText(txtInitial));
            Console.WriteLine("The First Name is : " + SeleniumGetMethods.GetText(txtFirstName));
            Console.WriteLine("The Middle Name is  : " + SeleniumGetMethods.GetText(txtMiddleName));

            Thread.Sleep(5000);
            SeleniumSetMethods.Click(btnSave);

            /*
            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            Thread.Sleep(5000);
            btnSave.Click();
            */
        }
    }
}
