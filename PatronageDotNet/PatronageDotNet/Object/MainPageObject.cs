using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.MainPage
{
    public class MainPageObject : BasePageObject
    {
        public MainPageObject(IWebDriver driver)
         : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Lista aktualności")]
        public IWebElement RedBox { get; set; }

        [FindsBy(How = How.LinkText, Using = "Użytkownicy")]
        public IWebElement OrangeBox { get; set; }
    }
    
}
