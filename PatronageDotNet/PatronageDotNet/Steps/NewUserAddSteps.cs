using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using PatronageDotNet.Object.MainPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PatronageDotNet.Object.UserList;
using OpenQA.Selenium.Support.UI;

namespace PatronageDotNet.Steps
{
    [Binding]
    public class NewUserAddSteps
    {

        private IWebDriver _driver;
        private MainPageObject _Main;
        private UserListPageObject _UserList;
        private WebDriverWait _wait;
        [BeforeScenario]
        public void BeforeTest()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        [AfterScenario]
        public void AfterTest()
        {
            _driver.Quit();
        }

        [Given(@"User is on a Main Page")]
        public void givenUserIsOnMainPage()
        {
            _driver.Navigate().GoToUrl("https://toz-backoffice.now.sh");
            _Main = new MainPageObject(_driver);
            _UserList = new UserListPageObject(_driver);
        }

        [When(@"User click on user list")]
        public void andUserClickOnUserList()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_Main.OrangeBox));
            _Main.OrangeBox.Click();
        }

        [When(@"User click on add new user button")]
        public void andUserClickOnAddNewUserrBtn()
        {
           _wait.Until(ExpectedConditions.ElementToBeClickable(_UserList.CreateUserButton));
           _UserList.CreateUserButton.Click();
        }

        [When(@"User write (.*), (.*), (.*), (.*) and (.*)")]
        public void andUserFillFormular(String name, String surname, String phoneNumber, String email, String role)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_UserList.CancelButton));
            _UserList.FirstName.SendKeys(name);
            _UserList.LastName.SendKeys(surname);
            _UserList.PhoneNumber.SendKeys(phoneNumber);
            _UserList.Email.SendKeys(email);
            SelectElement SelectRole = new SelectElement(_UserList.SelectRole);
            SelectRole.SelectByText(role);
        }

        [When(@"User click save")]
        public void andUserClickSaveBtn()
        {
            _UserList.SaveButton.Click();
        }

        [Then(@"User see results")]
        public void thenUserSeeResults()
        {
           //Assertion to Fill
           //Assert.IsTrue()

        }

    }
}
