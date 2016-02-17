using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.ScreenObjects.ScreenAttributes;

namespace CalculatorTest
{
    public  class StandardViewScreenRep
    {
        public const string EXPECTEDTITLE = "Calculator";

        [AutomationId("121")]
        protected Button EqualsButton;

        [AutomationId("158")]
        protected Label DisplayLabel;

        [TestStack.White.ScreenObjects.ScreenAttributes.AutomationId("93")]
        protected Button PlusButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.AutomationId("94")]
        protected Button MinusButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.AutomationId("92")]
        protected Button MultiplyButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.AutomationId("91")]
        protected Button DevideButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.AutomationId("1")]
        protected Button OneButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.TextAttribute("2")]
        protected Button TwoButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.TextAttribute("3")]
        protected Button ThreeButton;

        [TestStack.White.ScreenObjects.ScreenAttributes.TextAttribute("0")]
        protected Button ZeroButton;

        public StandardViewScreenRep(Window window) { }

        public StandardViewScreenRep(Window window, ScreenRepository screenRepository) : base(window, screenRepository) { }

        public override string ExpectedTitle
        {
            get
            {
                return EXPECTEDTITLE;
            }
        }
        public static bool IsModal()
        {
            return false;
        }

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

