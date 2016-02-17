using System;
using TestStack.White.UIItems.WindowItems;
using System.ComponentModel;
using TestStack.White.ScreenObjects;

namespace CalculatorTest
{
    public abstract class BaseScreen : AppScreen
    {
        protected Window window;

        public abstract string ExpectedTitle { get; }

        public BaseScreen(Window window, ScreenRepository screenRepository) : base(window, screenRepository)
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
                case StandardViewScreenRep.EXPECTEDTITLE:
                    return NAME.STANDARD;
                default:
                    throw new InvalidEnumArgumentException("Can not find enum with such title: " + title);          
            }
        }
    }
    public enum NAME
    {
        ABOUT, STANDARD
    }

}
