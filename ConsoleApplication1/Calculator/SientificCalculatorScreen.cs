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

        protected override string ExpectedTitle
        {
            get
            {
                return EXPECTEDTITLE;
            }
        }
        
        public SientificCalculatorScreen(Window window) : base(window)
        {

        }
    }
}
