using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace Calculator
{
    class ScreenFactory
    {
        public static T CreateScreen<T>(Window window) where T : BaseScreen, new()
        {
            //    BaseScreen type = new T();
            //    switch (BaseScreen.ConvertdataToEnum(title))
            //    {
            //        case NAME.ABOUT:

            //            Window modalWindow = window.ModalWindow(type.ExpectedTitle);
            //            type.Init(modalWindow);
            //            return (T)type;

            //        case NAME.STANDARD:
            //            type.Init(window);
            //            return (T)type;
            //        default:
            //            return null;
            //    }
            //}
            //public static Object CreateScreen(string title) where T: BaseScreen
            //{
            //    //switch (BaseScreen.ConvertdataToEnum(title))
            //{
            //    case NAME.ABOUT:
            //        return new AboutCalculatorModalScreen();
            //    case NAME.STANDARD:
            //        return new StandardViewScreen();
            //    default:
            //        return null;
            //}
            //}
            // todo: create instance depends on enum 

            BaseScreen type = new T();
            bool isModalScreen = type.IsModal;
            if (isModalScreen)
            {
                Window modalWindow = window.ModalWindow(type.ExpectedTitle);
                type.Init(modalWindow);
                return (T)type;
            }
            else
            {
                type.Init(window);
                return (T)type;
            }
        }
    }
}


