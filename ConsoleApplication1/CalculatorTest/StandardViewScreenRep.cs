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
    public class StandardViewScreenRep:BaseScreen
    {
        public const string EXPECTEDTITLE = "Calculator";

        [AutomationId("121")]
        public Button EqualsButton;

        [AutomationId("158")]
        public Label DisplayLabel;

        [AutomationId("93")]
        protected Button PlusButton;

        [AutomationId("94")]
        protected Button MinusButton;

        [AutomationId("92")]
        protected Button MultiplyButton;

        [AutomationId("91")]
        protected Button DevideButton;

        [AutomationId("1")]
        protected Button OneButton;

        [Text("2")]
        protected Button TwoButton;

        [Text("3")]
        protected Button ThreeButton;

        [Text("0")]
        protected Button ZeroButton;

       // public StandardViewScreenRep(Window window) { }

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

