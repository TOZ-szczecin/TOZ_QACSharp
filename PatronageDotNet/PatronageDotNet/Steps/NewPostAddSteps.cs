using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PatronageDotNet.Object.ActiveList;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Support.UI;
using PatronageDotNet.Object.MainPage;

namespace PatronageDotNet
{

    [Binding]
    public class NewPostAddSteps
    {
        private IWebDriver _driver;
        private MainPageObject _Main;
        private ActiveListPageObject _Activ;

        [BeforeScenario]
         public void BeforeTest()
         {
         _driver = new ChromeDriver();
 
         }
         [AfterScenario]
         public void AfterTest()
         {
         _driver.Quit();
         }

        [Given(@"Im on Main Page")]
        public void GivenImOnMainPage()
        {
            _driver.Navigate().GoToUrl("https://toz-backoffice.now.sh/");
            _Main = new MainPageObject(_driver);
            _Activ = new ActiveListPageObject(_driver);
        }



        [When(@"I go to News page")]
        public void WhenIGoToNewsPage()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_Main.RedBox));
            _Main.RedBox.Click();
        }

        [When(@"I press add new info button")]
        public void WhenIPressAddNewInfoButton()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_Activ.createPostButton));
            _Activ.createPostButton.Click();
          

        }

        [When(@"I wrote (.*) and (.*)")]
        public void WhenIWroteAnd(string title, string text)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_Activ.mainTitle));
            _Activ.mainTitle.SendKeys(title);
            _Activ.mainText.SendKeys(text);
           
        }

        [When(@"I press Save")]
        public void WhenIPressSave()
        {
            _Activ.publishButton.Click();
        }

        [Then(@"I see post with this (.*) and (.*) was created")]
        public void ThenISeePostWithThis(string title, string text)

        {
             Assert.IsTrue(_Activ.textPresent.Text.Equals(text));

            /// There is no assertion to title field i cant locate it for now ///
            /// This only works when there is one news ///

        }






    }
}
