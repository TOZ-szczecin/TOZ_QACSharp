using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.ActiveList
{
    public class ActiveListPageObject : BasePageObject
    {
        public ActiveListPageObject(IWebDriver driver)
         : base(driver)
        {
            PageFactory.InitElements(Driver, this);
        }

        /// News Page Butoons ///

        [FindsBy(How = How.ClassName, Using = "btn-create")]
        public IWebElement createPostButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "unreleased")]
        public IWebElement unreleasedTag { get; set; }

        [FindsBy(How = How.ClassName, Using = "overflow-ellipsis")]
        public IWebElement textPresent { get; set; }

        /// Create Post Buttons ///

        [FindsBy(How = How.Id, Using = "Title")]
        public IWebElement mainTitle { get; set; }

        [FindsBy(How = How.Id, Using = "Text")]
        public IWebElement mainText { get; set; }

        [FindsBy(How = How.Id, Using = "Save")]
        public IWebElement saveButton { get; set; }

        [FindsBy(How = How.Id, Using = "Publish")]
        public IWebElement publishButton { get; set; }

        [FindsBy(How = How.Id, Using = "Cancel")]
        public IWebElement cancelButton { get; set; }






    }

}


