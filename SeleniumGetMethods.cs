using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class SeleniumGetMethods
    {

        //Get Text from Title
        public static string GetSelectedDropDown(PropertyType elementtype, string element)
        {
            if (elementtype == PropertyType.id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }

        //Get Text from Initial
        public static string GetText(PropertyType elementtype, string element)
        {
            if (elementtype == PropertyType.id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }
    }
}
