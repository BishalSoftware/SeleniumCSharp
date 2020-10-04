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
        public static string GetSelectedDropDown(IWebDriver driver, string elementtype, string element)
        {
            if (elementtype == "id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }

        //Get Text from Initial
        public static string GetText(IWebDriver driver, string elementtype, string element)
        {
            if (elementtype == "id")
                return driver.FindElement(By.Id(element)).GetAttribute("value"); 
            if (elementtype == "name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }
    }


}
