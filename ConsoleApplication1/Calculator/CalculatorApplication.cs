﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace Calculator
{
    class CalculatorApplication
    {
        private const string PATH = "calc.exe";

        private Application application;
        private static CalculatorApplication instanse;
        public static CalculatorApplication Instanse
        {
            get
            {
                if (instanse == null)
                {
                    instanse = new CalculatorApplication();
                }
                return instanse;
            }
        }

        private CalculatorApplication()
        {
        }

        public void Start()
        {
            application = Application.Launch(PATH);
        }

        public void Close()
        {
            application.Close();
        }

        //todo: use generic to return appropriate page
        //public StandardViewScreen GetScreen(string title)
        //{
        //    Window myWindow = application.GetWindow(title);
        //    return new StandardViewScreen(myWindow);
        //}
        //    Window Screen = Desktop.Instance.Windows().Find(obj => obj.Title.Equals(StandardViewScreen.EXPECTEDTITLE));

        //get modal window
        public AboutCalculatorModalScreen GetModalScreen(Window window)
        {
            return new AboutCalculatorModalScreen(window.ModalWindow(AboutCalculatorModalScreen.EXPECTEDTITLE));
        }
        }
    }
}