using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using System.Windows.Automation;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string exeSourceFile = @"C:\Windows\System32\calc.exe";

        [TestMethod]
        public void TestMethod1()
        {

            Application application = Application.Launch(exeSourceFile);
            Window window = application.GetWindow("Калькулятор");
            window.WaitWhileBusy();
            Button button1 = window.Get<Button>(SearchCriteria.ByAutomationId("131"));
            button1.Click();
            Button button2 = window.Get<Button>(SearchCriteria.ByAutomationId("132"));
            button2.Click();
            Button equalsBtn = window.Get<Button>(SearchCriteria.ByAutomationId("121"));
           equalsBtn.Click();
           window.WaitWhileBusy();
           SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("158");
           Label display = window.Get<Label>(searchCriteria);
           string text = display.Text;
           string expectedResult = "12";
           Assert.AreEqual(expectedResult, text);
           application.Close();
        }
    }
}
