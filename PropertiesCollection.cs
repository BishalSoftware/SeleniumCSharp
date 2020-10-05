using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    //Strongly typed parameters
    enum PropertyType
    {
        id,
        name,
        value,
        onclick,
        type
    }

    class PropertiesCollection
    {
        //Auto-implemented Property
        public static IWebDriver driver
        {
            get;
            set;             
        }
    }
}
