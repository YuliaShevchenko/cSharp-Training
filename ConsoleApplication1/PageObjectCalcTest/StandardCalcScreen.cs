
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace PageObjectCalcTest
{
   class StandardCalcScreen
    {
        private const string APPNAME = "Калькулятор";
        public Button equalsButton { get; set; }
        public Button plusButton { get; set; }
        public Button minusButton { get; set; }
        public Button multiplyButton { get; set; }
        public Button divideButton { get; set; }

        public Button digitOneButton { get; set; }
        public Button digitTwoButton { get; set; }
        public Button digitThreeButton { get; set; }

        public Label display { get; set; }
        public Menu helpTab { get; set; }
        public MenuBar menuBars { get; set; }
        public Menu menuBar { get; set; }
        public Menu viewHelp { get; set; }

        public StandardCalcScreen(Application calculator)
        {
            Window window = calculator.GetWindow(APPNAME);
            equalsButton = window.Get<Button>(SearchCriteria.ByAutomationId("121"));
            plusButton = window.Get<Button>(SearchCriteria.ByAutomationId("93"));
            display = window.Get<Label>(SearchCriteria.ByAutomationId("158"));
            // minusButton = window.Get<Button>(SearchCriteria.ByAutomationId("121"));
            digitOneButton = window.Get<Button>(SearchCriteria.ByText("1"));
            digitTwoButton = window.Get<Button>(SearchCriteria.ByText("2"));
            digitThreeButton = window.Get<Button>(SearchCriteria.ByText("3"));
            window.WaitWhileBusy();
           // menuBar = window.Get<MenuBar>(SearchCriteria.ByAutomationId("Application"));
            menuBars = window.MenuBar;
            menuBar = menuBars.MenuItemBy(SearchCriteria.ByText("MenuBar"));
           helpTab = menuBars.MenuItemBy(SearchCriteria.ByAutomationId("Item 3"));
           viewHelp = menuBars.MenuItemBy(SearchCriteria.ByAutomationId("Item 311"));
        }
        //TODO: window name -const; rename app. methods rename, enumeration(click operation), buttons

        public void ClickOnHelp()
        {
            helpTab.Click();
            viewHelp.Click();
        }

        public void ClickOnOneButton()
        {
            digitOneButton.Click();
        }
        public void ClickOnTwoButton()
        {
            digitTwoButton.Click();
        }
        public void ClickOnThreeButton()
        {
            digitThreeButton.Click();
        }
        public void ClickOnPlusButton()
        {
            plusButton.Click();
        }
        public void ClickOnEqualsButton()
        {
            equalsButton.Click();
        }
        public string GetDisplayedText()
        {
            return display.Text;
        }
        public void ClickOnDigitButton(string num)
        {
            switch (num)
            {
                case "1":
                    ClickOnOneButton();
                    break;

                case "2":
                    ClickOnTwoButton();
                    break;
                case "3":
                    ClickOnThreeButton();
                    break;
            }
        }
    }
}