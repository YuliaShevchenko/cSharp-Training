using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Custom;

namespace CalculatorTest
{
    [ControlTypeMapping(CustomUIItemType.MenuItem)]
    public class MyCustomMenu : CustomUIItem
    {

        //public MyCustomMenu(AutomationElement automationElement, ActionListener actionListener)
        //    : base(automationElement, actionListener)
        //{
        //}

        //public MyCustomMenu() { }

        //public virtual bool IsToggledOn()
        //{
        //    var element = this.AutomationElement;

        //    Object objPattern;
        //    if (true == element.TryGetCurrentPattern(TogglePattern.Pattern, out objPattern))
        //    {
        //        return ((TogglePattern)objPattern).Current.ToggleState == ToggleState.On;
        //    }

        //    return false;
        //}

    }
}
