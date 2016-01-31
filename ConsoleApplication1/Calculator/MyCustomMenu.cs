using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Custom;

namespace Calculator
{
    [ControlTypeMapping(CustomUIItemType.MenuItem)]
   public class MyCustomMenu : CustomUIItem
    {

        public MyCustomMenu(AutomationElement automationElement, ActionListener actionListener)
            : base(automationElement, actionListener)
        {
        }

        public MyCustomMenu() { }

        public virtual void EnterDate()
        {
            //Base class, i.e. CustomUIItem has property called Container. Use this find the items within this.
            //Can also use SearchCriteria for find items
            Console.WriteLine("ttttttttttt");
        }


    }
}
