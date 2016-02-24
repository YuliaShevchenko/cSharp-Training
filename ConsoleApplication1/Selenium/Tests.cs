using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Selenium
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;

        public object IWebDriverWait { get; private set; }

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
            string productCategory = "iMacs";
            Header header = new Header(driver);
            header.SelectProductCategory(productCategory);
            Container conentContainer = new Container(driver);
            Assert.AreEqual(productCategory, conentContainer.pageHeader.Text);
            
            //todo: verify view

        }

        [Test]
        public void AddProductToCart()
        {
            string productCategory = "iPads";
            Header header = new Header(driver);
            header.SelectProductCategory(productCategory);
            Container conentContainer = new Container(driver);
            string title = conentContainer.SelectAProduct(0);
            conentContainer.ClickOnCartButton(1);
            Pop_up pop = new Pop_up(driver);
            pop.continueShoppingButton.Click();
            header.GotoCart();

            Cart cart = new Cart(driver);
            Assert.AreEqual(title, cart.productInCart.Text);
        }

        [Test]
        public void Search()
        {
            Header header = new Header(driver);
            header.searchField.SendKeys("Apple TV");
            header.searchField.Submit();

        }


        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
