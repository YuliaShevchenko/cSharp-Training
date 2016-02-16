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

        //public T GetScreen<T>(string title) where T : BaseScreen
        //{
        //    Window myWindow = application.GetWindow(title);
        //    return (T)Activator.CreateInstance(typeof(T), myWindow);
        //}

        public T GetScreen<T>(String title) where T : BaseScreen
        {
            Type type = typeof(T);

            MethodInfo methodInfo = type.GetMethod("IsModal", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);

            Object isModal = methodInfo.Invoke(null, null);

            Window window = null;

            if ((bool)isModal)
            {
                window = MainWindow.ModalWindow(title);
            }
            else
            {
                window = MainWindow;
            }

            return (T)ScreenFactory.CreateScreen(window, BaseScreen.ConvertdataToEnum(title));
        }
    }
}
