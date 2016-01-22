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
                    return new StandardViewScreen(CalculatorApplication.Instanse.GetMainScreen(title));
                case (AboutCalculatorModalScreen.EXPECTEDTITLE):
                    Window mainScreen = CalculatorApplication.Instanse.GetMainScreen(StandardViewScreen.EXPECTEDTITLE);
                    return CalculatorApplication.Instanse.GetModalScreen(mainScreen);
                default:
                    return null;
            }
        }
    }
}
