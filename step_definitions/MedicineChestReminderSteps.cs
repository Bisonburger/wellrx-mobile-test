using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class MedicineChestReminderSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.MedicineChestReminderPage _MedicineChestReminderPage;

        public MedicineChestReminderSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _MedicineChestReminderPage = FeatureContext.Current.Get<Pages.MedicineChestReminderPage>("MedicineChestReminderPage");
        }

        [When("I fill out Pill Reminder information")]
        public void WhenIFillOutPillReminderInformation()
        {
            When("I select When in the Pill Reminder selection");
            Then("I should be on When in the Pill Reminder selection");
            When("I enter When information for Pill Reminder selection");
            When("I save the Reminder selections");
            When("I select How Often in the Pill Reminder selection");
            Then("I should be on How Often in the Pill Reminder selection");
            When("I enter How Often information for Pill Reminder selection");
            When("I save the Reminder selections");
            When("I select Start Date in the Pill Reminder selection");
            When("I select End Date in the Pill Reminder selection");
            When("I enter a reminder Alert Message");
        }

        [When("I fill out Refill Reminder information")]
        public void WhenIFillOutRefillReminderInformation()
        {
            When("I change all Refill Reminder information");
            When("I enter a reminder Alert Message");
        }

        [Then("I should be on the Pill Reminder page")]
        public void ThenIShouldBeOnThePillReminderPage()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.PillReminderPage, 5);
            Assert.IsTrue(_MedicineChestReminderPage.PillReminderPage.Displayed(), "Not on the Pill Reminder Page");
            Assert.IsTrue(_MedicineChestReminderPage.PillReminderHeader.Displayed(), "missing Pill Reminder Header");
        }

        [When("I toggle the Toggle Switch")]
        public void WhenIToggleTheToggleSwitch()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.ToggleSwitch, 5);
            if (!_MedicineChestReminderPage.StartDateRow.Displayed() && _MedicineChestReminderPage.PillReminderPage.Displayed())
                _MedicineChestReminderPage.ToggleSwitch.Click();
            if (!_MedicineChestReminderPage.DateFilledRow.Displayed() && _MedicineChestReminderPage.RefillReminderPage.Displayed())
                _MedicineChestReminderPage.ToggleSwitch.Click();
        }

        [When("I save the Reminder selections")]
        public void WhenISaveTheReminderSelections()
        {
            if (!_MedicineChestReminderPage.SaveButton.Displayed())
            {
                _MedicineChestReminderPage.ScrollDownTo(_MedicineChestReminderPage.SaveButton.Locator);
            }
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.SaveButton, 5);
            _MedicineChestReminderPage.SaveButton.Click();
        }


        [When("I enter a reminder Alert Message")]
        public void WhenIEnterAReminderAlertMessage()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.AlertMessageEntry, 5);
            _MedicineChestReminderPage.AlertMessageEntry.Click();
            if (!_MedicineChestReminderPage.AlertMessageEntry.Displayed())
                _MedicineChestReminderPage.ScrollDownTo(_MedicineChestReminderPage.AlertMessageEntry.Locator);
            if (AppInitializer.CurrentPlatform == Platform.iOS)
                _MedicineChestReminderPage.AlertMessageEntry.Click();
            _MedicineChestReminderPage.AlertMessageEntry.EnterText("This is made by Automation");
        }

        [When("I select When in the Pill Reminder selection")]
        public void WhenISelectWhenInThePillReminderSelection()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.ReminderIntervalRow, 5);
            _MedicineChestReminderPage.ReminderIntervalRow.Click();
        }

        [Then("I should be on When in the Pill Reminder selection")]
        public void ThenIShouldBeOnWhenInThePillReminderSelection()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.PillReminderPage, 5);
            Assert.IsTrue(_MedicineChestReminderPage.PillReminderIntervalPage.Displayed(), "Not on when? in the Pill Reminder Page");
            Assert.IsTrue(_MedicineChestReminderPage.PillReminderIntervalHeader.Displayed(), "missing when? Pill Reminder Header");
            Assert.IsTrue(_MedicineChestReminderPage.DailyOptionsStackLayout.Displayed(), "missing Daily Option Pill Reminder section");
        }

        [When("I enter When information for Pill Reminder selection")]
        public void WhenIIEnterWhenInformationForPillReminderSelection()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.CheckboxImage, 5);
            _MedicineChestReminderPage.CheckboxImage.Click();
            _MedicineChestReminderPage.ReminderTypeRow.Click();
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.RepeatDaily, 5);
            _MedicineChestReminderPage.RepeatInterval.Click();
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.IntervalOptionsStackLayout, 5);
            _MedicineChestReminderPage.IntervalRow.Click();
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.IntervalDaily, 5);
            _MedicineChestReminderPage.IntervalWeekly.Click();
            _MedicineChestReminderPage.FrequencyRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.UpperCaseOK, 5);
            app.ClearText();
            app.EnterText("4");
            _MedicineChestReminderPage.UpperCaseOK.Click();
            _MedicineChestReminderPage.ReminderTypeRow.Click();
            _MedicineChestReminderPage.RepeatCycle.Click();
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.CycleOptionsStackLayout, 5);
            _MedicineChestReminderPage.CycleRow.Click();
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                _MedicineChestReminderPage.CycleText.Click();
                _MedicineChestReminderPage.FirstPillTakenRow.Click();
                _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.FirstPillTakenCalendar, 5);
            }
            else if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                _MedicineChestReminderPage.DoneButton.Click();
                _MedicineChestReminderPage.FirstPillTakenRow.Click();
            }

            _MedicineChestReminderPage.LowerCaseOk.Click();
            _MedicineChestReminderPage.ToggleSwitch.Click();
        }

        [When("I select How Often in the Pill Reminder selection")]
        public void WhenISelectHowOftenInThePillReminderSelection()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.ReminderFrequencyRow, 5);
            _MedicineChestReminderPage.ReminderFrequencyRow.Click();
        }

        [Then("I should be on How Often in the Pill Reminder selection")]
        public void ThenIShouldBeOnHowOftenInThePillReminderSelection()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.PillReminderFrequencyPage, 5);
            Assert.IsTrue(_MedicineChestReminderPage.PillReminderFrequencyPage.Displayed(), "Not on How Often? in the Pill Reminder Page");
            Assert.IsTrue(_MedicineChestReminderPage.PillReminderFrequencyHeader.Displayed(), "missing How Often? Pill Reminder Header");
        }

        [When("I enter How Often information for Pill Reminder selection")]
        public void WhenIIEnterHowOftenInformationForPillReminderSelection()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.FrequencyPicker, 5);
            _MedicineChestReminderPage.FrequencyPicker.Click();
            _MedicineChestReminderPage.FrequencyTime.Click();
            if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                _MedicineChestReminderPage.DoneButton.Click();
            }
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.AlertTimeSetting, 5);
            _MedicineChestReminderPage.AlertTimeSetting.Click();
            _MedicineChestPage.WaitForElementPresent(_MedicineChestReminderPage.UpperCaseOK, 5);
            _MedicineChestReminderPage.UpperCaseOK.Click();
        }

        [When("I select Start Date in the Pill Reminder selection")]
        public void WhenISelectStartDateInThePillReminderSelection()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.StartDateRow, 5);
            _MedicineChestReminderPage.StartDateRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.LowerCaseOk, 5);
            _MedicineChestReminderPage.LowerCaseOk.Click();
        }

        [When("I select End Date in the Pill Reminder selection")]
        public void WhenISelectEndDateInThePillReminderSelection()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.EndDateRow, 5);
            _MedicineChestReminderPage.EndDateRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.LowerCaseOk, 5);
            _MedicineChestReminderPage.LowerCaseOk.Click();
        }

        [Then("I should be on the Refill Reminder page")]
        public void ThenIShouldBeOnTheRefillReminderPage()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.RefillReminderPage, 5);
            Assert.IsTrue(_MedicineChestReminderPage.RefillReminderPage.Displayed(), "Not on the Refill Reminder Page");
            Assert.IsTrue(_MedicineChestReminderPage.RefillReminderHeader.Displayed(), "missing Refill Reminder Header");
        }

        [When("I change all Refill Reminder information")]
        public void WhenIChangeallRefillReminderinformation()
        {
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.DateFilledRow, 3);
            _MedicineChestReminderPage.DateFilledRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.LowerCaseOk, 3);
            _MedicineChestReminderPage.LowerCaseOk.Click();
            _MedicineChestReminderPage.QuantityFilledRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.UpperCaseOK, 3);
            app.ClearText();
            app.EnterText("30");
            _MedicineChestReminderPage.UpperCaseOK.Click();
            _MedicineChestReminderPage.FrequencyUnitRow.Click();
            _MedicineChestReminderPage.IntervalWeekly.Click();
            _MedicineChestReminderPage.FrequencyRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.UpperCaseOK, 3);
            app.ClearText();
            app.EnterText("2");
            _MedicineChestReminderPage.UpperCaseOK.Click();
            _MedicineChestReminderPage.AlertTimeRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.UpperCaseOK, 3);
            _MedicineChestReminderPage.UpperCaseOK.Click();
            _MedicineChestReminderPage.AlertIntervalRow.Click();
            _MedicineChestReminderPage.WaitForElementPresent(_MedicineChestReminderPage.AlertIntervalText, 3);
            _MedicineChestReminderPage.AlertIntervalText.Click();
        }
    }
}
