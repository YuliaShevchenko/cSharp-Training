using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    class CalculatorApplication
    {
        private const string PATH = "calc.exe";

        private Application application;

        public static CalculatorApplication INSTANCE = new CalculatorApplication();

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

        public StandardViewWindow GetWindow(string title)
        {
            return new StandardViewWindow(application.GetWindow(title));
        }
    }
}
