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
        public static T CreateScreen<T>(string title)where T:BaseScreen
        {
            if (title == StandardViewScreen.EXPECTEDTITLE)
            {
                Window mainWindow = CalculatorApplication.Instanse.MainWindow;
                BaseScreen screen = new StandardViewScreen(mainWindow);
                return (T)screen;
            }
            if (title == AboutCalculatorModalScreen.EXPECTEDTITLE)
            {
                Window modalWindow = CalculatorApplication.Instanse.GetModalWindow(title);
                BaseScreen screen = new AboutCalculatorModalScreen(modalWindow);
                return (T)screen;
            }
            return null;
        }
    }
}

