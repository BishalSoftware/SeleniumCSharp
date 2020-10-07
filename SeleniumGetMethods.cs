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
        public static string GetSelectedDropDown(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        //Get Text from Initial, First Name, Middle Name etc.
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
