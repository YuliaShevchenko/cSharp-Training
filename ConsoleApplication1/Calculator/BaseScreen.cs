using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;

namespace Calculator
{
    abstract class BaseScreen
    {
        protected Window window;
        //TODO: create property IsModal, by default all created screens set this property to false in constructor
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
