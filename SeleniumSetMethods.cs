using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class SeleniumSetMethods
    {
        //Selecting a drop down control for Title
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }


        //Enter Text for Initial, First name and Middle Name
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        //Submitting a button
        public static void Submit(IWebElement element)
        {
            element.Submit();
            Console.WriteLine("Login button is submitted by selenium automation");
        }

        //Click into a button, Checkbox, option etc.
        public static void Click(IWebElement element)
        {
            element.Click();
            Console.WriteLine("Save button is clicked by selenium automation");
        }

    }
}
