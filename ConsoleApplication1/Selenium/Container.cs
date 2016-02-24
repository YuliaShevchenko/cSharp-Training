using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']//header/h1")]
        public IWebElement pageHeader;

        [FindsBy(How = How.XPath, Using = ".//*[@id='default_products_page_container']")]
        public IWebElement product;

        [FindsBy(How = How.XPath, Using = ".//*[@class='input-button-buy']/span/input")]
        public IWebElement addToCartButton;






        public Container(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String SelectAProduct(int index)
        {
            var product = driver.FindElements(By.XPath(".//*[@class='product_grid_display group']")).ElementAt(index);
           
            return product.Text;
        }

        public void ClickOnCartButton(int index)
        {
             driver.FindElements(By.XPath(".//*[@class='input-button-buy']/span/input")).ElementAt(index).Click();
            
        }
    }

}
