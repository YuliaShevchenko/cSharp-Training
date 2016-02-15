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
        
        public abstract string ExpectedTitle { get; }
        public abstract bool IsModal { get; }

        //todo: public enum Name { AboutCalc , Calculator}
        // create enum for acreens


        public BaseScreen(Window window)
        {
            this.window = window;
            if (!getTitle().Equals(ExpectedTitle))
            {
                throw new InvalidOperationException();
            }
        }

        public BaseScreen()
        {
        }

        public void Init(Window window)
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

        public static NAME ConvertdataToEnum(string title)
        {
            return (NAME)Enum.Parse(typeof(NAME), title, true);
        }
    }

    public enum NAME
    {
        ABOUT, STANDARD
    }

}
