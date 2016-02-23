using System;
using NUnit.Framework;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Selenium
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Init()
        { 
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("http://store.demoqa.com/");
        }

        [Test]
        public void LoginTest()
        {
            Login login = new Login(driver);
            Header header = new Header(driver);
            header.myAccount.Click();
            login.SetUserName("qa29");
            login.SetPassword("W0fucGsTDnVS");
            login.loginButton.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Assert.AreEqual("Howdy, Qa29", header.GetHomePageUserName());
        }
        [Test]
        public void SelectCategoryTest()
        {
            Container content = new Container(driver);
            content.SelectProductCategory();

        }


        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
