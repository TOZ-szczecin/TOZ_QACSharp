using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronageDotNet.Object.DriverFactory
{
    public class DriverFactory
    {
        public DriverFactory()
        {
            this.initialize();
        }

        protected static IWebDriver Driver { get; set; }

        public void initialize()
        {
            if(Driver == null)
                createNewDriverInstance();
          
        }

        public void createNewDriverInstance()
        {
            Driver = new ChromeDriver();
        }

        public IWebDriver getDriver() { return Driver; }
               
        public void destroyDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }
        }
    }
}
