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
            CalculatorApplication.INSTANCE.Start();
        }

        [TestCleanup]
        public void testCleanUp()
        {
            CalculatorApplication.INSTANCE.Close();
        }
        [TestMethod]
        [DeploymentItem("PageObjectCalculator\\DataForPositiveTest.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataForPositiveTest.csv", "DataForPositiveTest.csv", DataAccessMethod.Sequential)]
        public void PositiveCalculationTest()
        {
            string firstNumber = TestContext.DataRow[0].ToString();
            string secondNumber = TestContext.DataRow[1].ToString();
            string operation = TestContext.DataRow[2].ToString();
            string expectedResult = TestContext.DataRow[3].ToString();

            StandardViewWindow standardViewWindow = CalculatorApplication.INSTANCE.GetWindow(StandardViewWindow.TITLE);
            standardViewWindow.GetDigitButton(firstNumber).Click();
            standardViewWindow.GetOperationButtons(operation).Click();
            standardViewWindow.GetDigitButton(secondNumber).Click();
            standardViewWindow.EqualsButton.Click();
            Assert.AreEqual(expectedResult, standardViewWindow.DisplayLabel.Text);
        }

        [TestMethod]
        [DeploymentItem("PageObjectCalculator\\DataForNegativeTest.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataForNegativeTest.csv", "DataForNegativeTest.csv", DataAccessMethod.Sequential)]
        public void NegativeCalculationTest()
        {
            string firstNumber = TestContext.DataRow[0].ToString();
            string secondNumber = TestContext.DataRow[1].ToString();
            string operation = TestContext.DataRow[2].ToString();
            string expectedResult = TestContext.DataRow[3].ToString();

            StandardViewWindow standardCalcScreen = CalculatorApplication.INSTANCE.GetWindow(StandardViewWindow.TITLE);
            standardCalcScreen.GetDigitButton(firstNumber).Click();
            standardCalcScreen.GetOperationButtons(operation).Click();
            standardCalcScreen.GetDigitButton(secondNumber).Click();
            standardCalcScreen.EqualsButton.Click();
            Assert.AreNotEqual(expectedResult, standardCalcScreen.DisplayLabel.Text);
        }

        ////TODO: rename TC - done
        [TestMethod]
        public void CheckVersionOnAboutScreenTest()
        {
            StandardViewWindow standardCalcScreen = CalculatorApplication.INSTANCE.GetWindow(StandardViewWindow.TITLE);
            standardCalcScreen.HelpMenu.Click();
            AboutCalculatorModalWindow aboutCalcModalWindow = standardCalcScreen.GetAboutCalculatorWindow();
            Assert.AreEqual("Version 6.1 (Build 7601: Service Pack 1)", aboutCalcModalWindow.VersionLabel.Text);
            aboutCalcModalWindow.OkButton.Click();
        }

        //TODO: Singleton
        //TODO: make base window, each window should have it's own title and should be initialized with window
    }
}
