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

