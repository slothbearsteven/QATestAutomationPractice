using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    class program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://formy-project.herokuapp.com/dragdrop";

            IWebElement image = driver.FindElement(By.Id("image"));
            IWebElement dropBox = driver.FindElement(By.Id("box"));

            Actions actions = new Actions(driver);
            actions.DragAndDrop(image, dropBox).Build().Perform();

            driver.Quit();

        }
    }
}
