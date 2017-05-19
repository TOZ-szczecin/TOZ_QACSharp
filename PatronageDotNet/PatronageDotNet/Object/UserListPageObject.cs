using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.UserList
{
    public class UserListPageObject : BasePageObject
    {
        public UserListPageObject(IWebDriver driver)
         : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn-create")]
        public IWebElement CreateUserButton { get; set; }


        // Create user formular //

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Purpose")]
        public IWebElement SelectRole { get; set; }

        [FindsBy(How = How.Id, Using = "Cancel")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.Id, Using = "Save")]
        public IWebElement SaveButton { get; set; }
    }
}
