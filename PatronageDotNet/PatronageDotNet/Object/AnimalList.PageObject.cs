using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.AnimalList
{
    public class AnimalListPageObject 
    {
        public AnimalListPageObject(IWebDriver Driver)
        {
            PageFactory.InitElements(Driver, this);
        }

    }
}
