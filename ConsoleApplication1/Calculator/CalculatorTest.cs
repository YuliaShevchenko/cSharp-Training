using System;
using System.Windows.Automation;
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
        [DeploymentItem("Calculator\\DataForPositiveTest.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataForPositiveTest.csv", "DataForPositiveTest.csv", DataAccessMethod.Sequential)]
        public void PositiveCalculationTest()
        {
            string firstNumber, secondNumber, operation, expectedResult;
            GetDigitInDataFile(out firstNumber, out secondNumber, out operation, out expectedResult);

            StandardViewScreen standardViewWindow = CalculatorApplication.Instanse.GetScreen<StandardViewScreen>();
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
            StandardViewScreen standardCalcScreen = CalculatorApplication.Instanse.GetScreen<StandardViewScreen>();
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
            UpperMenuBar.Instance.ClickAboutCalculatorButton();
            AboutCalculatorModalScreen aboutCalcModalScreen = CalculatorApplication.Instanse.GetScreen<AboutCalculatorModalScreen>();
            Assert.AreEqual("Version 6.1 (Build 7601: Service Pack 1)", aboutCalcModalScreen.VersionLabel.Text);
            aboutCalcModalScreen.OkButton.Click();
        }
       
        [TestMethod]
        //[ControlTypeMapping(CustomUIItemType.Menu)]
        public void TurnOnHistoryTest()
        {
            UpperMenuBar.Instance.TurnOnHistory();
            UpperMenuBar.Instance.ViewMenu.Click();
           // Assert.IsTrue(IsElementToggledOn(UpperMenuBar.Instance.HistoryMenu));
        }
        //TODO: read abot CustomUI items. create toggle menu item

        private bool IsElementToggledOn(AutomationElement element)
        {
            if (element == null)
            {
                return false;
            }

            Object objPattern;
            TogglePattern togPattern;
            if (true == element.TryGetCurrentPattern(TogglePattern.Pattern, out objPattern))
            {
                togPattern = objPattern as TogglePattern;
                return togPattern.Current.ToggleState == ToggleState.On;
            }
            return false;
        }
    }
}
