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
            BaseScreen t = new T();
            bool isModalScreen = t.IsModal;
            if (isModalScreen)
            {
                Window modalWindow = window.ModalWindow(t.ExpectedTitle);
                t.Init(modalWindow);
                return (T)t;
            }
            else
            {
                t.Init(window);
                return (T)t;
            }
        }
    }
}

