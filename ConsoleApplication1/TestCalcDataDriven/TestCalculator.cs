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

        private Application application;

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
            string num1 = TestContext.DataRow[0].ToString();
            string num2 = TestContext.DataRow[1].ToString();
            string expectedResult = TestContext.DataRow[2].ToString();
            assertCalculatorAddition(num1, num2, expectedResult);
        }

        //click on buttons with digits, plus and equals.
        public void assertCalculatorAddition(string num1, string num2, string expectedResult)
        {
            Window window = application.GetWindow("Калькулятор");
            window.WaitWhileBusy();
            window.Get<Button>(SearchCriteria.ByText(num1)).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("93")).Click();
            window.Get<Button>(SearchCriteria.ByText(num2)).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("121")).Click();
            window.WaitWhileBusy();
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("158");
            Label display = window.Get<Label>(searchCriteria);
            Assert.AreEqual(expectedResult, display.Text);
        }

    }
}
