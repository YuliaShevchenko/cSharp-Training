using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    abstract class BaseScreen
    {
        protected Window window;

        protected abstract string ExpectedTitle { get; }

        public BaseScreen(Window window)
        {
            this.window = window;
            if (!getTitle().Equals(ExpectedTitle))
            {
                throw new InvalidOperationException();
            }
        }

        public string getTitle()
        {
            return window.Title;
        }

        public void Close()
        {
            window.Close();
        }
    }
}
