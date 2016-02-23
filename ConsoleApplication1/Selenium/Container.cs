using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Container
    {
        //IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-33']/a")]
        public IWebElement ProductsTab;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-34']/a")]
        public IWebElement AccessoriesMenuItem;

        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-35']/a")]
        public IWebElement iMacs;


        public Container(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void SelectProductCategory() {
            //ProductsTab.Click();
            
           // AccessoriesMenuItem.Click();
          

            
        }

    }
}
