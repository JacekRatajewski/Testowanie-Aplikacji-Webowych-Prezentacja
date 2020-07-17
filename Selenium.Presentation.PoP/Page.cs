using OpenQA.Selenium;
using Selenium.Presentation.AC;

namespace Selenium.Presentation.PoP
{
    public class Page
    {
        public IWebDriver DRIVER { get; }

        public ActionCenter AC { get; }
        public Page(IWebDriver driver)
        {
            DRIVER = driver;
            AC = new ActionCenter();
        }

        public void Open(string url)
        {
            DRIVER.Url = url;
        }

        public void Close()
        {
            DRIVER.Close();
            DRIVER.Dispose();
        }

        public void Maximize()
        {
            DRIVER.Manage().Window.Maximize();
        }

    }
}
