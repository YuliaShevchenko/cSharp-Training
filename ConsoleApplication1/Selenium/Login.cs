﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Login
    {

        [FindsBy(How = How.Id, Using = "log")]
        private IWebElement userNameField;

        [FindsBy(How = How.Id, Using = "pwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement loginButton;


        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void SetUserName(String userName) {
            userNameField.SendKeys(userName);
        }

        public void SetPassword (String password)
        {
            passwordField.SendKeys(password);
        }

    }
}
