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
    class AboutCalculatorModalWindow : BaseWindow
    {
        public const string TITLE = "About Calculator";

        private Window aboutCalculatorModalWindow;

        public Button OkButton
        {
            get
            {
                return aboutCalculatorModalWindow.Get<Button>(SearchCriteria.ByAutomationId("1"));
            }
        }
        public Label VersionLabel
        {
            get
            {
                return aboutCalculatorModalWindow.Get<Label>(SearchCriteria.ByAutomationId("13579"));
            }
        }

        public AboutCalculatorModalWindow(Window window)
        {
            title = TITLE;

            if (!window.Title.Equals(TITLE))
            {
                throw new InvalidOperationException();
            }

            aboutCalculatorModalWindow = window;
        }
        //TODO: initialize childWindow, delete it from method
        ////TODO: window name make as const - done
    }
}
