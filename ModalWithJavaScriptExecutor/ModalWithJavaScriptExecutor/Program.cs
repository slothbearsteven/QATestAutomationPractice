using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://formy-project.herokuapp.com/modal";
            IWebElement modalButton = driver.FindElement(By.Id("modal-button"));
            modalButton.Click();

            IWebElement closeModalButton = driver.FindElement(By.Id("close-button"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Thread.Sleep(1000);
            js.ExecuteScript(script:"arguments[0].click();" , closeModalButton);


            driver.Quit();

        }
    }
}

