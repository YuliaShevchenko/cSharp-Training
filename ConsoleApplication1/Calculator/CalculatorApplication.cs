using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace Calculator
{
    class CalculatorApplication
    {
        private const string PATH = "calc.exe";

        private Application application;
        private static CalculatorApplication instanse;
        public static CalculatorApplication Instanse
        {
            get
            {
                if (instanse == null)
                {
                    instanse = new CalculatorApplication();
                }
                return instanse;
            }
        }

        private CalculatorApplication()
        {
        }

        public void Start()
        {
            application = Application.Launch(PATH);
        }

        public void Close()
        {
            application.Close();
        }

        //todo: use generic to return appropriate page
        //public T GetScreen<T>(string title) where T : BaseScreen
        //{
        //    Window myWindow = application.GetWindow(title);
        //    return (T)Activator.CreateInstance(typeof(T), myWindow);
        //}

        //TODO: base on T.IsModal if..else
        //public T GetScreen<T>(string title) where T : BaseScreen
        //{
        //    if (title == StandardViewScreen.EXPECTEDTITLE)
        //    {
        // 
        //            BaseScreen standardScreen = new StandardViewScreen(application.GetWindow(title));
        //            return (T)standardScreen;
    //}
        //        else{
        //            Window mainScreen = application.GetWindow(StandardViewScreen.EXPECTEDTITLE);
        //            BaseScreen aboutScreen = GetModalScreen(mainScreen);
        //            return (T)aboutScreen;
        //    }
        //    

        //TODO: set IsModal property (true/false in parametrs)
        public T GetScreen<T>(string title) where T : BaseScreen
        {           
           return (T)ScreenFactory.CreateScreen(title);
        }

        //TODO: create property mainwindow to pass in params; to find  modal window from parent.
        public Window GetMainScreen(string title) {
            return application.GetWindow(title);
        }

        //get modal window
        public AboutCalculatorModalScreen GetModalScreen(Window window)
        {
            return new AboutCalculatorModalScreen(window.ModalWindow(AboutCalculatorModalScreen.EXPECTEDTITLE));
        }
    }
}
