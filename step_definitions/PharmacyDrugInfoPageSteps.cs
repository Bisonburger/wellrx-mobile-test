using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class PharmacyDrugInfoPageSteps
    {
        [Then("I should see Language Text text reads as")]
        public void ThenIShouldSeeLanguageTextReadsAs(string multiLines)
        {
            Assert.AreEqual(multiLines, Page.PharmacyDrugInfoPage.LanguageText.GetText());
        }

        [AfterStep]
        public void AfterStep()
        {
            // TODO: implement logic that has to run after each scenario step
        }

        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            // TODO: implement logic that has to run before each scenario block (given-when-then)
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
            // TODO: implement logic that has to run after each scenario block (given-when-then)
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // TODO: implement logic that has to run after executing each scenario
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            // TODO: implement logic that has to run before executing each feature
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            // TODO: implement logic that has to run after executing each feature
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // TODO: implement logic that has to run before the entire test run
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // TODO: implement logic that has to run after the entire test run
        }
    }
}
