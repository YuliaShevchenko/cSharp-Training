using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    class ScreenFactory
    {

        public static BaseScreen CreateScreen(Window window, NAME titleEnum)
        {
            switch (titleEnum)
            {
                case NAME.ABOUT:
                    return new AboutCalculatorModalScreen(window);
                case NAME.STANDARD:
                    return new StandardViewScreen(window);
                default:
                    return null;
            }
        }
    }

}


