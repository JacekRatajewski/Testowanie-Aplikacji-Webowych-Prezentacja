using Moq;
using NUnit.Framework;
using Selenium.Presentation.NBA.Interfaces;

namespace Selenium.Presentation.Moq
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {
        }
        [TearDown]
        public void TearDown()
        {
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Assert.Pass();
        }

        [Test]
        [TestCase(TestName = "Test który sprawdza generacje rma")]
        [Category("Logic")]
        [Order(1)]
        [Repeat(1)]
        [Retry(1)]
        public void CreateRmaTest_Should_CreateRMA()
        {
            Assert.Pass();
            Assert.That("",Is.Empty,"Is not Empty");
            //http://dotnetpattern.com/nunit-assert-examples
        }

        [Test]
        [Order(2)]
        public void MoqTest()
        {
            Mock<IPlayerStatisticsProcessor> mock = new Mock<IPlayerStatisticsProcessor>();
            mock.Setup(x => x.GetPlayerScore(new NBA.Models.Player())).Returns(10);
        }
    }
}