using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Header
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@id='account']/a")]
        public IWebElement myAccount;

        [FindsBy(How = How.XPath, Using = ".//*[@id='header_cart']/a")]
        public IWebElement checkoutButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='account_logout'")]
        public IWebElement logoutButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='wp-admin-bar-my-account']/a")]
        public IWebElement homePageUserName;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-33']/a")]
        public IWebElement ProductCategoryTab;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-34']/a")]
        public IWebElement AccessoriesMenuItem;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-35']/a")]
        public IWebElement iMacMenuItem;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-36']/a")]
        public IWebElement iPadMenuItem;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-37']/a")]
        public IWebElement iPhonesMenuItem;

        [FindsBy(How = How.XPath, Using = ".//*[@id='main-nav']/form")]
        public IWebElement searchField;



        public Header(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            //if (driver.Title != "ONLINE STORE | Toolsqa Dummy Test site ")
            //    throw new NoSuchWindowException("This is not the Login page");
        }

        public String GetHomePageUserName()
        {
            return homePageUserName.Text;

        }

        public void SelectProductCategory(String product)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(ProductCategoryTab).Perform();
            GetProduct(product).Click();

        }
        private IWebElement GetProduct(string product)
        {
            switch (product)
            {
                case "Accessories":
                    return AccessoriesMenuItem;
                case "iMacs":
                    return iMacMenuItem;
                case "iPads":
                    return iPadMenuItem;
                case "iPhones":
                    return iPhonesMenuItem;
                default:
                    return null;
            }

        }

        public void GotoCart()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(checkoutButton).Perform();
        }


    }
}
