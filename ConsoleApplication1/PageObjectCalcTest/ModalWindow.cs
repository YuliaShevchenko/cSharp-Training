using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace PageObjectCalcTest
{
    class ModalWindows: Windows
    {

        public Button okButton
        {
            get
            {
                return window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            }
        }

        public ModalWindows(Application application) : base(application) { }

        public string GetTextOnAboutWindow()
        {
            window.WaitWhileBusy();
            List<Window> modalWindows = window.ModalWindows();
            Window childWindow = window.ModalWindow("Калькулятор: сведения");
            string title = childWindow.Title;
            //window.WaitWhileBusy();
            //TextBox versionBoxText = childWindow.Get<TextBox>(SearchCriteria.ByAutomationId("13579"));
            //versionBoxText.Text
            return title;
        }
    }
}
