﻿using System;
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
        [DeploymentItem("PageObjectCalculator\\DataForPositiveTest.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataForPositiveTest.csv", "DataForPositiveTest.csv", DataAccessMethod.Sequential)]
        public void PositiveCalculationTest()
        {
            string firstNumber = TestContext.DataRow[0].ToString();
            string secondNumber = TestContext.DataRow[1].ToString();
            string operation = TestContext.DataRow[2].ToString();
            string expectedResult = TestContext.DataRow[3].ToString();

            StandardViewScreen standardViewWindow = CalculatorApplication.Instanse.GetScreen(StandardViewScreen.EXPECTEDTITLE);
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

            StandardViewScreen standardCalcScreen = CalculatorApplication.Instanse.GetScreen(StandardViewScreen.EXPECTEDTITLE);
            standardCalcScreen.GetDigitButton(firstNumber).Click();
            standardCalcScreen.GetOperationButtons(operation).Click();
            standardCalcScreen.GetDigitButton(secondNumber).Click();
            standardCalcScreen.EqualsButton.Click();
            Assert.AreNotEqual(expectedResult, standardCalcScreen.DisplayLabel.Text);
        }

        [TestMethod]
        public void CheckVersionOnAboutWindowTest()
        {
            StandardViewScreen standardCalcScreen = CalculatorApplication.Instanse.GetScreen(StandardViewScreen.EXPECTEDTITLE);
            standardCalcScreen.HelpMenu.Click();
            AboutCalculatorModalScreen aboutCalcModalScreen = standardCalcScreen.OpenAboutCalculatorScreen();
            Assert.AreEqual("Version 6.1 (Build 7601: Service Pack 1)", aboutCalcModalScreen.VersionLabel.Text);
            aboutCalcModalScreen.OkButton.Click();
        }

        //зачем синглтон, придумать и реализовать что-то в калькуляторе
        //todo: files in the solution should have the same name as classes
        //create a structure in solution
    }
}