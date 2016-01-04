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
        private static Application application;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void initialize()
        {
            application = Application.Launch(exeSourceFile);
        }

        [TestCleanup]
        public void testCleanUp()
        {
            application.Close();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", filePath, "Data#csv", DataAccessMethod.Sequential)]
        public void AdditionDataDrivenTest()
        {
            int num1 = System.Convert.ToInt32(TestContext.DataRow[0]);
            int num2 = System.Convert.ToInt32(TestContext.DataRow[1]);
            int expectedResult = System.Convert.ToInt32(TestContext.DataRow[2]);
            TestCalculator.CalculatorAddition(num1, num2, expectedResult);
        }

        //click on buttons with digits, plus and equals.
        public static void CalculatorAddition(int num1, int num2, int expectedResult)
        {
            Window window = application.GetWindow("Калькулятор");
            window.WaitWhileBusy();
            window.Get<Button>(SearchCriteria.ByText(num1.ToString())).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("93")).Click();
            window.Get<Button>(SearchCriteria.ByText(num2.ToString())).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("121")).Click();
            window.WaitWhileBusy();
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("158");
            Label display = window.Get<Label>(searchCriteria);
            Assert.AreEqual(expectedResult.ToString(), display.Text);
        }

    }
}
