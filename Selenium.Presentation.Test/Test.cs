using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Presentation.AC.Controls.Waiters;
using Selenium.Presentation.PoP.POM;
using System.IO;
using System.Reflection;

namespace Selenium.Presentation.Test
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;

        private Model Model;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), new ChromeOptions { AcceptInsecureCertificates = true });
            Model = new Model(_driver);
            Model.Open("");
            Model.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            Model.Close();
        }

        [Test]
        public void Test1()
        {
            Part1();
        }

        private void Part1()
        {
            Model.AC.Wait(new SimpleWait());
            Model.Button.Click();
        }
    }
}