using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.LoginPage
{
    public class LoginPageObject
    {

        public LoginPageObject(IWebDriver Driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        //Login textboxes 

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "SignIn")]
        public IWebElement submitButton { get; set; }


    }
}
