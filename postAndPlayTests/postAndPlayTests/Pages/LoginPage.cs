using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postAndPlayTests.Pages
{
    internal class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

    }
}
