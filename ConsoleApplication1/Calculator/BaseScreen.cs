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
        // public abstract bool IsModal { get; }

        //todo: public enum Name { AboutCalc , Calculator}
        // create enum for acreens


        public BaseScreen(Window window)
        {
            this.window = window;
            if (!getTitle().Equals(ExpectedTitle))
            {
                throw new InvalidOperationException("Expected title: " + ExpectedTitle + " Current title: " + getTitle());
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
                throw new InvalidOperationException("Expected title: " + ExpectedTitle + " Current title: " + getTitle());
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
            switch (title)
            {
                case AboutCalculatorModalScreen.EXPECTEDTITLE:
                    return NAME.ABOUT;
                case StandardViewScreen.EXPECTEDTITLE:
                    return NAME.STANDARD;
            }

            throw new ArgumentException("Can not find enum for title: " + title);
        }
    }

    public enum NAME
    {
        ABOUT, STANDARD
    }

}
