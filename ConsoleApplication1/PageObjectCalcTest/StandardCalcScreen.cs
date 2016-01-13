
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
        private const string WINDOWNAME = "Калькулятор";
        private Window window;
        public Button equalsButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("121"));
            }
        }
        public Label display { get { return window.Get<Label>(SearchCriteria.ByAutomationId("158")); } }
        public Button plusButton { get { return window.Get<Button>(SearchCriteria.ByAutomationId("93")); } }
        public Button minusButton { get { return window.Get<Button>(SearchCriteria.ByAutomationId("94")); } }
        public Button multiplyButton { get { return window.Get<Button>(SearchCriteria.ByAutomationId("92")); } }
        public Button devideButton { get { return window.Get<Button>(SearchCriteria.ByAutomationId("91")); } }
        public Button oneButton { get { return window.Get<Button>(SearchCriteria.ByText("1")); } }
        public Button twoButton { get { return window.Get<Button>(SearchCriteria.ByText("2")); } }
        public Button threeButton { get { return window.Get<Button>(SearchCriteria.ByText("3")); } }
        public MenuBar menuBar { get { return window.Get<MenuBar>(SearchCriteria.ByAutomationId("Application")); } }
        public MenuBar helpTab { get { return window.Get<MenuBar>(SearchCriteria.ByAutomationId("Item 3")); } }

        public StandardCalcScreen(Application calculator)
        {
            window = calculator.GetWindow(WINDOWNAME);
        }

        //TODO: window name -const; rename app. methods rename, enumeration(click operation), buttons
        //TODO: get init controls; rewrite enum via parse; read about path; clean path; read about debug folder; refactor methods(click());   about in calc; tc deviding to 0;

        //public void ClickOnHelp()
        //{
        //    MenuBar menuBar = window.MenuBar;
        //    menuBar.MenuItemBy(GetHelpTab()).Click();
        //    window.WaitWhileBusy();
        //    Menu view = menuBar.MenuItemBy(GetViewHelp());
        //    view.Click();
        //}

        public string GetDisplayedText()
        {
            return display.Text;
        }
        public Button ClickOnDigitButton(string num)
        {
            switch (num)
            {
                case "1":
                    return oneButton;
                case "2":
                    return twoButton;
                case "3":
                    return threeButton;
            }
            return null;
        }
        public enum OPERATION
        {
            PLUS, MINUS, DEVIDE, MULTIPLY
        }

        public OPERATION GetOperands(string values)
        {
            if (values.Equals("PLUS"))
            {
                return OPERATION.PLUS;
            }
            else if (values.Equals("MINUS"))
            {
                return OPERATION.MINUS;
            }
            else if (values.Equals("DEVIDE"))
            {
                return OPERATION.DEVIDE;
            }
            else
            {
                return OPERATION.MULTIPLY;
            }
        }

        public Button ClickOnOperand(string operation)
        {
            OPERATION command = GetOperands(operation);
            switch (command)
            {
                case OPERATION.PLUS:
                    return plusButton;
                case OPERATION.MINUS:
                    return minusButton;
                case OPERATION.MULTIPLY:
                    return multiplyButton;
                case OPERATION.DEVIDE:
                    return devideButton;
            }
            return null;
        }
    }
}

