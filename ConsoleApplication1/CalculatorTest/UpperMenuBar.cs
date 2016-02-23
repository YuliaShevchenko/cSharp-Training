using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.ScreenObjects;
using TestStack.White.ScreenObjects.ScreenAttributes;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Custom;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
{

    class UpperMenuBar : BaseScreen
    {
        private Window window;

        [AutomationId("Item 1")]
        [Text("View")]
        public Menu ViewMenu;
       
        [AutomationId("Item 965")]
        public MyCustomMenu HistoryMenu;
       
        [AutomationId("Item 3")]
        public Menu HelpMenu;
       
        [AutomationId("Item 302")]
        public Menu AboutHelpMenu;

        //private static UpperMenuBar instance;
        //public static UpperMenuBar Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new UpperMenuBar();
        //        }
        //        return instance;
        //    }
        //}

        //private UpperMenuBar(Window window, ScreenRepository screenRepository) : base(window, screenRepository)
        //{
        //    window = CalculatorApplication.Instanse.MainWindow;
        //}

      //  private static UpperMenuBar Instance;

        //[Obsolete("Designer only", true)]

        public UpperMenuBar(Window window, ScreenRepository screenRepository) : base(window, screenRepository)
        {
            window = CalculatorApplication.Instanse.MainWindow;
        }
        public override string ExpectedTitle
        {
            get
            {
                return StandardViewScreenRep.EXPECTEDTITLE;
            }
        }

        //public bool IsHistoryMenuToggledOn()
        //{
        //    ViewMenu.Click();
        //    return HistoryMenu.IsToggledOn();
        //}

        //public void TurnOnHistory()
        //{
        //    ViewMenu.Click();
        //    if (!HistoryMenu.IsToggledOn())
        //    {
        //        HistoryMenu.Click();
        //    }
        //    ViewMenu.Click();
        //}

        //public void TurnOffHistory()
        //{
        //    ViewMenu.Click();
        //    if (HistoryMenu.IsToggledOn())
        //    {
        //        HistoryMenu.Click();
        //    }
        //    ViewMenu.Click();
        //}

        public virtual void ClickAboutCalculatorButton()
    {
        HelpMenu.Click();
        AboutHelpMenu.Click();
    }

}
}
