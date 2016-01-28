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
        private Window window;
        public Menu ViewMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 1").AndByText("View"));
            }
        }
        public Menu HistoryMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 965"));
            }
        }
        public Menu HelpMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 3"));
            }
        }
        public Menu AboutHelpMenu
        {
            get
            {
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 302"));
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

        private UpperMenuBar()
        {
            window = CalculatorApplication.Instanse.MainWindow;
        }

        public void TurnOnHistory()
        {
            ViewMenu.Click();
            HistoryMenu.Click();
        }

        //Use this Menu BAr to open About modal window
        public void ClickAboutCalculatorButton()
        {
            HelpMenu.Click();
            AboutHelpMenu.Click();           
        }

    }
}
