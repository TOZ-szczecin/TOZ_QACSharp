using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.Calendar
{
    public class CalendarPageObject : BasePageObject
    {
        public CalendarPageObject(IWebDriver driver)
         : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

    }

    }
