using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace Calculator
{
    class StandardViewWindow : BaseWindow
    {
        public const string TITLE = "Calculator";

        private Window window;
        ////TODO: properties start from capital letter - done
        ////TODO: rename controls(name + type) - done
        public Button EqualsButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("121"));

            }
        }
        public Label DisplayLabel
        {
            get
            {
                return window.Get<Label>(SearchCriteria.ByAutomationId("158"));
            }
        }
        public Button PlusButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("93"));
            }
        }
        public Button MinusButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("94"));
            }
        }
        public Button MultiplyButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("92"));
            }
        }
        public Button DevideButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("91"));
            }
        }
        public Button OneButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByText("1"));
            }
        }
        public Button TwoButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByText("2"));
            }
        }
        public Button ThreeButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByText("3"));
            }
        }
        public Button ZeroButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByText("0"));
            }
        }
        public Menu HelpMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 3"));
            }
        }
        public Menu AboutHelpMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 302"));
            }
        }

        //TODO: create mainViewWindow, constructor - get window according to view, window validation
        public StandardViewWindow(Window window)
        {
            title = TITLE;
            this.window = window;

            if (!window.Title.Equals(TITLE))
            {
                throw new InvalidOperationException();
            }
        }

        //TODO: screen validation
        public AboutCalculatorModalWindow GetAboutCalculatorWindow()
        {
            AboutHelpMenu.Click();
            return new AboutCalculatorModalWindow(window.ModalWindow(AboutCalculatorModalWindow.TITLE));
        }
        ////TODO: delete method GetDisplayedText() - done

        public Button GetDigitButton(string number)
        {
            switch (number)
            {
                case "1":
                    return OneButton;
                case "2":
                    return TwoButton;
                case "3":
                    return ThreeButton;
                case "0":
                    return ZeroButton;
            }
            return null;
        }

        public OPERATION ConvertOperationToEnum(string operation)
        {
            return (OPERATION)Enum.Parse(typeof(OPERATION), operation, true);
        }

        public Button GetOperationButtons(string operation)
        {
            switch (ConvertOperationToEnum(operation))
            {
                case OPERATION.PLUS:
                    return PlusButton;
                case OPERATION.MINUS:
                    return MinusButton;
                case OPERATION.MULTIPLY:
                    return MultiplyButton;
                case OPERATION.DIVIDE:
                    return DevideButton;
            }
            return null;
        }
    }
    public enum OPERATION
    {
        PLUS, MINUS, DIVIDE, MULTIPLY
    }
}
