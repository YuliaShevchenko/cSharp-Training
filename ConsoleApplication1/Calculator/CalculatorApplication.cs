using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

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
        //    return (T) Activator.CreateInstance(typeof(T), myWindow);
        //}
        public List<BaseScreen> GetData<T>(string title) where T : BaseScreen
        {
            List<BaseScreen> myList = new List<BaseScreen>();
            if (title == StandardViewScreen.EXPECTEDTITLE)
            {
                myList.Add(new StandardViewScreen(application.GetWindow(title)));
            }
            if (title == AboutCalculatorModalScreen.EXPECTEDTITLE)
            {
              Window mainScreen =  application.GetWindow(StandardViewScreen.EXPECTEDTITLE);
                myList.Add(GetModalScreen(mainScreen));
            }
            return myList;
        }

        public T GetScreen<T>(string title) where T : BaseScreen
        {
            List<BaseScreen> list = GetData<T>(title);
            foreach (BaseScreen screen in list)
            {
                if (title.Equals(screen.getTitle()))
                {
                    return (T)screen;
                }
            }
            //BaseScreen baseScreen = list[0];
            return null;
        }

        //get modal window
        private AboutCalculatorModalScreen GetModalScreen(Window window)
        {
            return new AboutCalculatorModalScreen(window.ModalWindow(AboutCalculatorModalScreen.EXPECTEDTITLE));
        }
    }
}
