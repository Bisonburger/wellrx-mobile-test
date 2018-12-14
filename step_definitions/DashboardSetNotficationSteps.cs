using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class DashboardSetNotficationSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.DashboardPage _DashboardPage;
        readonly Pages.DashboardSetNotficationPage _DashboardSetNotficationPage;
        readonly Pages.SavingscardPage _SavingsCardPage;

        public DashboardSetNotficationSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");
            _SavingsCardPage = FeatureContext.Current.Get<Pages.SavingscardPage>("SavingsCardPage");
            _DashboardSetNotficationPage = FeatureContext.Current.Get<Pages.DashboardSetNotficationPage>("DashboardSetNotficationPage");
        }

        [Given("I validate the full Dashboard Notfication Card")]
        public void GivenIValidateTheFullDashboardNotficationCard()
        {
            Then("I should be on Todays Reminders page");
            When("I select See All Reminders on Todays Reminders page");
            Then("I should see all the pill information in Todays Reminders section");
            Then("I should be on See All Reminders Todays Reminders page");
            When("I select a pill on the Todays Reminders list");
            Then("I should see all the pill information in Todays Reminders section");
            When("I enter all informmation for Todays Reminders pill details");
            Then("I should see the Mood Image on Todays Reminders section");
            When("I select Mood on Todays Reminders pill details");
            Then("I should see the Mood Image on Todays Reminders section");
            When("I select Save on Todays Reminders pill details");
            Thread.Sleep(1000);
            Then("I should see the Mood Image on Todays Reminders section");
        }

        [Then("I should be on Todays Reminders page")]
        public void ThenIShouldBeOnTodaysRemindersPage()
        {
            if (_DashboardSetNotficationPage.RemindersPage.Displayed())
            {
                _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.RemindersPage, 5);
                Assert.IsTrue(_DashboardSetNotficationPage.RemindersPage.Displayed(), "not on Reminders Page view");
                Assert.IsTrue(_DashboardSetNotficationPage.RemindersPageHeader.Displayed(), "Missing Reminders Page Header");
            }
            else
                Then("I should be navigated to the medicine chest page");
        }

        [When("I select See All Reminders on Todays Reminders page")]
        public void WhenISelectSeeAllRemindersOnTodaysRemindersPage()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.AllRemindersLinkButton, 5);
            _DashboardSetNotficationPage.AllRemindersLinkButton.Click();
        }

        [Then("I should see all the pill information in Todays Reminders section")]
        public void ThenIShouldSeeAllThePillInformationInTodaysRemindersSection()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.TodaysReminderDrugName, 5);
            Assert.IsTrue(_DashboardSetNotficationPage.TodaysReminderDrugName.Displayed(), "Missing Todays Reminder Drug Name.");
            Assert.IsTrue(_DashboardSetNotficationPage.ReminderDateTimeDisplay.Displayed(), "Missing Reminder Date Time Display.");
            Assert.IsTrue(_DashboardSetNotficationPage.TodaysReminderPillFormStrength.Displayed(), "Missing Todays Reminder Pill Form Strength.");
        }

        [Then("I should be on See All Reminders Todays Reminders page")]
        public void ThenIShouldBeOnSeeAllRemindersTodaysRemindersPage()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.RemindersPage, 5);
            Assert.IsTrue(_DashboardSetNotficationPage.RemindersPage.Displayed(), "not on Reminders Page view");
            Assert.IsTrue(_DashboardSetNotficationPage.RemindersPageHeader.Displayed(), "Missing Reminders Page Header");
            app.Back();
        }

        [When("I select a pill on the Todays Reminders list")]
        public void WhenISelectAPillOnTheTodaysRemindersList()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.TodaysReminderDrugName, 5);
            _DashboardSetNotficationPage.TodaysReminderDrugName.Click();
        }

        [When("I select Save on Todays Reminders pill details")]
        public void WhenISelectSaveOnTodaysRemindersPillDetails()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.SaveReminderButton, 5);
            _DashboardSetNotficationPage.SaveReminderButton.Click();
        }

        [When("I enter all informmation for Todays Reminders pill details")]
        public void WhenIEnterAllInformmationForTodaysRemindersPillDetails()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.MedicationTakenCheckBox, 5);
            _DashboardSetNotficationPage.MedicationTakenCheckBox.Click();
            _DashboardSetNotficationPage.ReminderNotesEntry.Click();
            if (!_DashboardSetNotficationPage.ReminderNotesEntry.Displayed())
            {
                _DashboardSetNotficationPage.ScrollDownTo(_DashboardSetNotficationPage.ReminderNotesEntry.Locator);
            }
            _DashboardSetNotficationPage.ReminderNotesEntry.EnterText(MoreInformationSteps.EnterInformaton.Message, true);
            if (_DashboardSetNotficationPage.SetMoodLinkButton.Displayed())
            _DashboardSetNotficationPage.SetMoodLinkButton.Click();
            else
            _DashboardSetNotficationPage.MoodImage.Click();
        }

        [When("I select Mood on Todays Reminders pill details")]
        public void WhenISelectMoodOnTodaysRemindersPillDetails()
        {
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.EmotionSlider, 5);
            _DashboardSetNotficationPage.SwipeRightToLeft(_DashboardSetNotficationPage.EmotionSlider.Locator);
            _DashboardSetNotficationPage.SwipeLeftToRight(_DashboardSetNotficationPage.EmotionSlider.Locator);
            _DashboardSetNotficationPage.SetMoodButton.Click();
        }

        [Then("I should see the Mood Image on Todays Reminders section")]
        public void ThenISshouldSeeTheMoodImageOnTodaysRemindersSection()
        {
            Thread.Sleep(1000);
            _DashboardSetNotficationPage.WaitForElementPresent(_DashboardSetNotficationPage.MoodImage, 3);
            Assert.IsTrue(_DashboardSetNotficationPage.MoodImage.Displayed(), "Missing Mood Image. ");
        }
    }
}