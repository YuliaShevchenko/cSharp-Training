using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
{
    class SientificCalculatorScreen : BaseScreen
    {
        public const string EXPECTEDTITLE = "Calculator";

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

        public SientificCalculatorScreen(Window window, ScreenRepository screenRepository) : base(window, screenRepository)
        {

        }
    }
}
