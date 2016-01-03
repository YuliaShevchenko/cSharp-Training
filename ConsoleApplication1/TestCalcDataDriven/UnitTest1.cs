using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using System.IO;

namespace TestCalcDataDriven
{
    [TestClass]
    public class TestCalculator
    {
        private const string exeSourceFile = @"C:\Windows\System32\calc.exe";
        private const string filePath = @"C:\Users\Jul\Source\Repos\cSharp-Training\ConsoleApplication1\TestCalcDataDriven\Data.csv";

        public TestContext TestContext { get; set; }

        [TestMethod]
       [DeploymentItem("calc.exe")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", filePath, "Data#csv", DataAccessMethod.Sequential)]
        public void TestSumDataDriven()
        {


            int num1 = System.Convert.ToInt32(TestContext.DataRow[0]);
            int num2 = System.Convert.ToInt32(TestContext.DataRow[1]);
            int expectedResult = System.Convert.ToInt32(TestContext.DataRow[2]);
            int actualResult = TestCalculator.Logic(num1, num2);

            Assert.AreEqual(expectedResult, actualResult);

            Application application = Application.Launch(exeSourceFile);
            Window window = application.GetWindow("Калькулятор");
            window.WaitWhileBusy();
       
            Button button1 = window.Get<Button>(SearchCriteria.ByText(num1.ToString()));
            button1.Click();
            Button plusBtn = window.Get<Button>(SearchCriteria.ByAutomationId("93"));
            plusBtn.Click();
            Button button2 = window.Get<Button>(SearchCriteria.ByText(num2.ToString()));
            button2.Click();
            Button equalsBtn = window.Get<Button>(SearchCriteria.ByAutomationId("121"));
            equalsBtn.Click();
            window.WaitWhileBusy();
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("158");
            Label display = window.Get<Label>(searchCriteria);
            
            Assert.AreEqual(expectedResult, display.Text);

            application.Close();
        }

        public static int Logic(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }
}
