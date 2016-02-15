using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                return application.GetWindow("Calculator");
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

        //public T GetScreen<T>(string title) where T : BaseScreen
        //{
        //    Window myWindow = application.GetWindow(title);
        //    return (T)Activator.CreateInstance(typeof(T), myWindow);
        //}

            //todo: search using isModal and title

        public T GetScreen<T>( Window window) where T : BaseScreen, new()
        {
            //Type type = typeof(T);
            //MethodInfo method = type.GetMethod("isModal", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            //object obj = Activator.CreateInstance(type);

           
            
            return ScreenFactory.CreateScreen<T>(MainWindow);
           
        }
    }
}
