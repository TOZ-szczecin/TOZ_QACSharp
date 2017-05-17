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

    }
}
