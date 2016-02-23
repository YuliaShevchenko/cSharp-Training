using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.ScreenObjects;
using TestStack.White.ScreenObjects.ScreenAttributes;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
{
    class AboutCalculatorModalScreen : BaseScreen
    {
        public const string EXPECTEDTITLE = "About Calculator";

        [AutomationId("1")]
        public Button OkButton;

        [AutomationId("13579")]
        public Label VersionLabel;

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

        public AboutCalculatorModalScreen(Window window, ScreenRepository screenRepository) : base(window, screenRepository)
        {           
        }
    }
}
