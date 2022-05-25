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

            IWebElement newTabButton = driver.FindElement(By.Id("new-tab-button"));
            newTabButton.Click();

            string originalHandle = driver.CurrentWindowHandle;

            List<string> lstWindow = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(lstWindow[1]);
            driver.SwitchTo().Window(originalHandle);



            driver.Quit();

        }
    }
}
