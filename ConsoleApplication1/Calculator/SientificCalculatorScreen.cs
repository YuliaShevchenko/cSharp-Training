using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
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
        public override bool IsModal
        {
            get
            {
                return false;
            }
        }

        public SientificCalculatorScreen(Window window) : base(window)
        {

        }
    }
}
