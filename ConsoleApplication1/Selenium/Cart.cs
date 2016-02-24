using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Cart
    {
        [FindsBy(How = How.XPath, Using = ".//*[@class='checkout_cart']//a")]
        public IWebElement productInCart;

        public Cart(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


    }
}
