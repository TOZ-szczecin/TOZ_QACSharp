using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using PatronageDotNet.Object.MainPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PatronageDotNet.Object.UserList;
using OpenQA.Selenium.Support.UI;
using PatronageDotNet.Object.LoginPage;
using PatronageDotNet.Object.DriverFactory;

namespace PatronageDotNet.Steps
{
    [Binding]
    public class NewUserAddSteps: DriverFactory
    {

        private MainPageObject _Main;
        private UserListPageObject _UserList;
        private LoginPageObject _LoginPage;

        private WebDriverWait _wait;
       // private String baseUrl = "https://toz-backoffice.now.sh";
        private String baseUrl = "http://192.168.99.100:5001/";

        [Given(@"User is on a Main Page")]
        public void givenUserIsOnMainPage()
        {
            
            _Main = new MainPageObject(this.getDriver());
            _UserList = new UserListPageObject(this.getDriver());
            _LoginPage = new LoginPageObject(this.getDriver());
            _wait = new WebDriverWait(this.getDriver(), TimeSpan.FromSeconds(10));
            this.getDriver().Navigate().GoToUrl(baseUrl);
        }

        [When(@"User click on login tile")]
        public void WhenUserClickOnLoginTile()
        {
            _Main.loginTile.Click();
        }

        [When(@"User login with (.*) and (.*)")]
        public void WhenUserLoginWith(String login, String password)
        {
            _LoginPage.email.SendKeys(login);
            _LoginPage.password.SendKeys(password);
            _LoginPage.submitButton.Click();
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

        [When(@"User write (.*), (.*), (.*), (.*), (.*) and (.*)")]
        public void andUserFillFormular(String name, String surname, String phoneNumber, String email, String Password, String role)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_UserList.CancelButton));
            _UserList.FirstName.SendKeys(name);
            _UserList.LastName.SendKeys(surname);
            _UserList.PhoneNumber.SendKeys(phoneNumber);
            _UserList.Email.SendKeys(email);
            _UserList.Password.SendKeys(Password);
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
