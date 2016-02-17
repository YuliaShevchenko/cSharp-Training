using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
{
    class ScreenFactory
    {

        public static BaseScreen CreateScreen(Window window, NAME titleEnum, ScreenRepository screenRepository)
        {
            switch (titleEnum)
            {
                case NAME.ABOUT:
                    return new AboutCalculatorModalScreen(window, screenRepository);
                case NAME.STANDARD:
                    return new StandardViewScreenRep(window, screenRepository);
                default:
                    return null;
            }
        }
    }

}


