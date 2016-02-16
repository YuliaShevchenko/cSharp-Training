using System;
using TestStack.White.UIItems.WindowItems;
using System.ComponentModel;


namespace Calculator
{
    abstract class BaseScreen
    {
        protected Window window;

        public abstract string ExpectedTitle { get; }

        public BaseScreen(Window window)
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
                default:
                    throw new InvalidEnumArgumentException("Can not find enum with such title: " + title);          
            }
        }
    }
    //todo: in other class
    public enum NAME
    {
        ABOUT, STANDARD
    }

}
