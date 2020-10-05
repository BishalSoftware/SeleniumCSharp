using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class EAPageObject
    {

        [Obsolete]
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        /*
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID
        {
            set;
            get;
        }
        */

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial
        {
           get;
           set;
        }

        [FindsBy(How = How.Name, Using ="Save")]
        public IWebElement btnSave
        {
            get;
            set;
        }
    }
}
