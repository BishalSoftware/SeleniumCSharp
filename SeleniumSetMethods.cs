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
        public static void SelectDropDown(PropertyType elementtype, string element, string value)
        {
            if (elementtype == PropertyType.id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }


        //Enter Text for Initial
        public static void EnterText(PropertyType elementtype, string element, string value)
        {
            if (elementtype == PropertyType.id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }


        //Click into a button, Checkbox, option etc.
        public static void Click(PropertyType elementtype, string element)
        {
            if (elementtype == PropertyType.name && element == "Save")
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
                Console.WriteLine("Save button is clicked by selenium automation");
            }
            else
                Console.WriteLine("Save button is not clicked");
        }
    }
}
