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
        public static void SelectDropDown(IWebDriver driver, string elementtype, string element, string value)
        {
            if (elementtype == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }


        //Enter Text for Initial
        public static void EnterText(IWebDriver driver, string elementtype, string element,  string value)
        {
           if (elementtype == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
           if (elementtype == "name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

       
        //Click into a button, Checkbox, option etc.
        public static void Click(IWebDriver driver, string elementtype, string element)
        {
            if (elementtype == "name" && element == "Save")
            {
                driver.FindElement(By.Name(element)).Click();
                Console.WriteLine("Save button is clicked by selenium automation");
            }
            else
                Console.WriteLine("Save button is not clicked"); 
        }
    }
}
