
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
    class StandardCalcScreen : Windows
    {
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
        public Button zeroButton { get { return window.Get<Button>(SearchCriteria.ByText("0")); } }

        public StandardCalcScreen(Application application) : base(application) { }

        //TODO: get init controls; rewrite enum via parse; read about path; clean path; read about debug folder; refactor methods(click());   about in calc; tc deviding to 0;
        
        public void GetHelpMenu()
        {
            var menuView = window.Get<Menu>(SearchCriteria.ByAutomationId("Item 3"));
            menuView.Click();
        }

        public ModalWindows GetAboutCalcWindow()
        {
            var menuViewBasic = window.Get<Menu>(SearchCriteria.ByAutomationId("Item 302"));
            menuViewBasic.Click();
            return new ModalWindows(application);
        }

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
                case "0":
                    return zeroButton;
            }
            return null;
        }

        public OPERATION ConvertStringToEnum(string operation)
        {
            return (OPERATION)Enum.Parse(typeof(OPERATION), operation, true);
        }

        public Button GetOperationButton(string operation)
        {
            switch (ConvertStringToEnum(operation))
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

    public enum OPERATION
    {
        PLUS, MINUS, DEVIDE, MULTIPLY
    }
}

