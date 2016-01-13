using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TestStack.White;
using TestStack.White.UIItems;
using PageObjectCalcTest;

namespace PageObjectCalculator
{
    [TestClass]
    public class PageObjectCalcTest
    {
        //string calculatorAppPath ="calc2.exe";
        string calculatorAppPath = Path.GetFullPath(@"calc2.exe");
        //string fullPath = Path.GetFullPath(@"PageObjectCalculator");
        private const string FILEPATH = @"C:\Users\Jul\Source\Repos\cSharp-Training\ConsoleApplication1\PageObjectCalcTest\Data.csv";

        public TestContext TestContext { get; set; }
        private Application application;

        [TestInitialize]
        public void initialize()
        {
            application = Application.Launch(calculatorAppPath);
        }

        [TestCleanup]
        public void testCleanUp()
        {
            application.Close();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", FILEPATH, "Data#csv", DataAccessMethod.Sequential)]
        public void CalculationTest()
        {
            string num1 = TestContext.DataRow[0].ToString();
            string num2 = TestContext.DataRow[1].ToString();
            string operation = TestContext.DataRow[2].ToString();
            string expectedResult = TestContext.DataRow[3].ToString();
            StandardCalcScreen calcScreen = new StandardCalcScreen(application);
            calcScreen.ClickOnDigitButton(num1).Click();
            calcScreen.ClickOnOperand(operation).Click();
            calcScreen.ClickOnDigitButton(num2).Click();
            calcScreen.equalsButton.Click();
            Assert.AreEqual(expectedResult, calcScreen.GetDisplayedText());
        }

        //public void OpenHelp()
        //{
        //    StandardCalcScreen calcScreen = new StandardCalcScreen(application);
        //    calcScreen.ClickOnHelp();
        //}
    }
}


