﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace PageObjectCalcTest
{
    abstract class Windows
    {
        private const string WINDOWNAME = "Калькулятор";
        protected Application application;
        protected Window window;

        public Windows(Application application)
        {
            this.application = application;
            window = application.GetWindow(WINDOWNAME);
        }


    }
}
