using OpenQA.Selenium;
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
        [FindsBy(How = How.XPath, Using = ".//*[@id='account']/a")]
        public IWebElement myAccount;

        [FindsBy(How = How.XPath, Using = ".//*[@id='account_logout'")]
        public IWebElement logoutButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='wp-admin-bar-my-account']/a")]
        public IWebElement homePageUserName;

        public Header(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            //if (driver.Title != "ONLINE STORE | Toolsqa Dummy Test site ")
            //    throw new NoSuchWindowException("This is not the Login page");
        }

        public String GetHomePageUserName()
        {
            return homePageUserName.Text;

        }


    }
}
