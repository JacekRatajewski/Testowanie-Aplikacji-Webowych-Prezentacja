using OpenQA.Selenium;

namespace Selenium.Presentation.PoP.POM
{
    public class Model : Page
    {
        public Model(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Button => DRIVER.FindElement(By.Id("button"));
        public IWebElement Button2 => DRIVER.FindElement(By.Id("button2"));
    }
}
