using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void initialize()
        {
            CalculatorApplication.Instanse.Start();
        }

        [TestCleanup]
        public void testCleanUp()
        {
            CalculatorApplication.Instanse.Close();
        }
        [TestMethod]
        [DeploymentItem("Calculator\\TestData\\DataForPositiveTest.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataForPositiveTest.csv", "DataForPositiveTest.csv", DataAccessMethod.Sequential)]
        public void PositiveCalculationTest()
        {
            string firstNumber, secondNumber, operation, expectedResult;
            GetDigitInDataFile(out firstNumber, out secondNumber, out operation, out expectedResult);

            StandardViewScreen standardViewWindow = CalculatorApplication.Instanse.GetScreen<StandardViewScreen>(StandardViewScreen.EXPECTEDTITLE);
            standardViewWindow.GetDigitButton(firstNumber).Click();
            standardViewWindow.GetOperationButtons(operation).Click();
            standardViewWindow.GetDigitButton(secondNumber).Click();
            standardViewWindow.EqualsButton.Click();
            Assert.AreEqual(expectedResult, standardViewWindow.DisplayLabel.Text);
        }

        [TestMethod]
        [DeploymentItem("Calculator\\DataForNegativeTest.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataForNegativeTest.csv", "DataForNegativeTest.csv", DataAccessMethod.Sequential)]
        public void NegativeCalculationTest()
        {
            string firstNumber, secondNumber, operation, expectedResult;
            GetDigitInDataFile(out firstNumber, out secondNumber, out operation, out expectedResult);
            StandardViewScreen standardCalcScreen = CalculatorApplication.Instanse.GetScreen<StandardViewScreen>(StandardViewScreen.EXPECTEDTITLE);
            standardCalcScreen.GetDigitButton(firstNumber).Click();
            standardCalcScreen.GetOperationButtons(operation).Click();
            standardCalcScreen.GetDigitButton(secondNumber).Click();
            standardCalcScreen.EqualsButton.Click();
            Assert.AreEqual(expectedResult, standardCalcScreen.DisplayLabel.Text);
        }

        private void GetDigitInDataFile(out string firstNumber, out string secondNumber, out string operation, out string expectedResult)
        {
            firstNumber = TestContext.DataRow[0].ToString();
            secondNumber = TestContext.DataRow[1].ToString();
            operation = TestContext.DataRow[2].ToString();
            expectedResult = TestContext.DataRow[3].ToString();
        }

        [TestMethod]
        public void CheckVersionOnAboutWindowTest()
        {
            StandardViewScreen standardCalcScreen = CalculatorApplication.Instanse.GetScreen<StandardViewScreen>(StandardViewScreen.EXPECTEDTITLE);
            standardCalcScreen.HelpMenu.Click();
            AboutCalculatorModalScreen aboutCalcModalScreen = standardCalcScreen.OpenAboutCalculatorScreen();
            Assert.AreEqual("Version 6.1 (Build 7601: Service Pack 1)", aboutCalcModalScreen.VersionLabel.Text);
            aboutCalcModalScreen.OkButton.Click();
        }
        //зачем синглтон, придумать и реализовать что-то в калькуляторе
        //todo: files in the solution should have the same name as classes
        //todo: create a structure in solution
    }
}
