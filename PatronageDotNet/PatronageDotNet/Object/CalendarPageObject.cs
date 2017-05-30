using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.Calendar
{
    public class CalendarPageObject
    {
        public CalendarPageObject(IWebDriver Driver)
        {
            PageFactory.InitElements(Driver, this);
        }

    }

    }
