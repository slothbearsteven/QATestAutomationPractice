using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://formy-project.herokuapp.com/switch-window";

            IWebElement alertButton = driver.FindElement(By.Id("alert-button"));
            alertButton.Click();

             IAlert alertBox =driver.SwitchTo().Alert();
            alertBox.Accept();




            driver.Quit();

        }
    }
}
