using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    class ScreenFactory
    {
        public static BaseScreen CreateScreen(string title)
        {
            switch (title)
            {
                case (StandardViewScreen.EXPECTEDTITLE):
                    BaseScreen standardScreen = new StandardViewScreen(CalculatorApplication.Instanse.GetMainScreen(title));
                    return standardScreen;
                case (AboutCalculatorModalScreen.EXPECTEDTITLE):
                    Window mainScreen = CalculatorApplication.Instanse.GetMainScreen(StandardViewScreen.EXPECTEDTITLE);
                    BaseScreen aboutScreen = CalculatorApplication.Instanse.GetModalScreen(mainScreen);
                    return aboutScreen;
                default:
                    return null;
            }
        }
    }
}
