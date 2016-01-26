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
        public Window MainWindow
        {
            get
            {
                return application.GetWindow("Калькулятор");
            }
        }

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
        

        //TODO: set IsModal property (true/false in parametrs)
        public T GetScreen<T>(string title) where T : BaseScreen
        {
            return ScreenFactory.CreateScreen<T>(title);
        }

        //TODO: create property mainwindow to pass in params; to find  modal window from parent.
        //get modal window
        public Window GetModalWindow(string title)
        {
            return MainWindow.ModalWindow(title);
        }
        
    }
}
