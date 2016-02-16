using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    class AboutCalculatorModalScreen : BaseScreen
    {
        public const string EXPECTEDTITLE = "About Calculator";

        public Button OkButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            }
        }
        public Label VersionLabel
        {
            get
            {
                return window.Get<Label>(SearchCriteria.ByAutomationId("13579"));
            }
        }

        public override string ExpectedTitle
        {
            get
            {
                return EXPECTEDTITLE;
            }
        }
      
        public static bool IsModal()
        {
            return true;
        }

        public AboutCalculatorModalScreen(Window window) : base(window)
        {           
        }
    }
}
