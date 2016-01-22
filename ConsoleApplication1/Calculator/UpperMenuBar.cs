using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    class UpperMenuBar
    {

        public Menu ViewMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 1"));
            }
        }
        public Menu HistoryMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 965"));
            }
        }

        private static UpperMenuBar instance;
        public static UpperMenuBar Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UpperMenuBar();
                }
                return instance;
            }
        }

        private UpperMenuBar(Window window)
        {
            CalculatorApplication.Instanse.GetScreen<StandardViewScreen>(StandardViewScreen.EXPECTEDTITLE);
        }
        public void TurnOnHistory()
        {
            ViewMenu.Click();
            HistoryMenu.Click();

        }
    }
}
