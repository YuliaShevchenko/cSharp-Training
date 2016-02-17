using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
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
                    return new StandardViewScreenRep(window);
                default:
                    return null;
            }
        }
    }

}


