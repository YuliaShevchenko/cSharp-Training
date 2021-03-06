﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Custom;
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
                return window.Get<Menu>(SearchCriteria.ByAutomationId("Item 1").AndByText("Вид"));
            }
        }
        public MyCustomMenu HistoryMenu
        {
            get
            {
                return window.Get<MyCustomMenu>(SearchCriteria.ByAutomationId("Item 965"));
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

        public bool IsHistoryMenuToggledOn()
        {
            ViewMenu.Click();
            return HistoryMenu.IsToggledOn();
        }

        public void TurnOnHistory()
        {
            ViewMenu.Click();
            if (!HistoryMenu.IsToggledOn())
            {
                HistoryMenu.Click();
            }
            ViewMenu.Click();
        }

        public void TurnOffHistory()
        {
            ViewMenu.Click();
            if (HistoryMenu.IsToggledOn())
            {
                HistoryMenu.Click();
            }
            ViewMenu.Click();
        }

        public void ClickAboutCalculatorButton()
        {
            HelpMenu.Click();
            AboutHelpMenu.Click();           
        }

    }
}
