using System;
using System.Windows.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.ScreenObjects;
using TestStack.White.Factory;
using TestStack.White.Sessions;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        private ScreenRepository screenRepository;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            CalculatorApplication.Instanse.Start();
            screenRepository = new ScreenRepository(CalculatorApplication.Instanse.application.ApplicationSession);
        }

        [TestCleanup]
        public void TestCleanUp()
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

           // StandardViewScreenRep standardViewWindow = CalculatorApplication.Instanse.GetScreen<StandardViewScreenRep>(StandardViewScreenRep.EXPECTEDTITLE, screenRepository);
            StandardViewScreenRep standardViewWindow = screenRepository.Get<StandardViewScreenRep>(StandardViewScreenRep.EXPECTEDTITLE, InitializeOption.NoCache);
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
        
            StandardViewScreenRep standardCalcScreen = screenRepository.Get<StandardViewScreenRep>(StandardViewScreenRep.EXPECTEDTITLE, InitializeOption.NoCache);
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
            UpperMenuBar upperBAr = screenRepository.Get<UpperMenuBar>(StandardViewScreenRep.EXPECTEDTITLE, InitializeOption.NoCache);
            upperBAr.ClickAboutCalculatorButton();
            AboutCalculatorModalScreen aboutCalcModalScreen = screenRepository.GetModal<AboutCalculatorModalScreen>(AboutCalculatorModalScreen.EXPECTEDTITLE, CalculatorApplication.Instanse.MainWindow, InitializeOption.NoCache);
            Assert.AreEqual("Version 6.1 (Build 7601: Service Pack 1)", aboutCalcModalScreen.VersionLabel.Text);
            aboutCalcModalScreen.OkButton.Click();
        }


        //[TestMethod]
        //public void TurnOnHistoryTest()
        //{
        //    UpperMenuBar.Instance.ViewMenu.Click();
        //    if (!UpperMenuBar.Instance.HistoryMenu.IsToggledOn()) {
        //        UpperMenuBar.Instance.HistoryMenu.Click();
        //        UpperMenuBar.Instance.ViewMenu.Click();
        //    }

        //    Assert.IsTrue(UpperMenuBar.Instance.HistoryMenu.IsToggledOn());
        //}

        //[TestMethod]
        //public void TurnOffHistoryTest()
        //{
        //    UpperMenuBar.Instance.ViewMenu.Click();
        //    if (UpperMenuBar.Instance.HistoryMenu.IsToggledOn())
        //    {
        //        UpperMenuBar.Instance.HistoryMenu.Click();
        //        UpperMenuBar.Instance.ViewMenu.Click();
        //    }

        //    Assert.IsFalse(UpperMenuBar.Instance.HistoryMenu.IsToggledOn());
        //}
        ////TODO: read abot CustomUI items. create toggle menu item

    }
}
