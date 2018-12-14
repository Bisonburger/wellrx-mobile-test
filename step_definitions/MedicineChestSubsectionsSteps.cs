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
    public class MedicineChestSubsectionsSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.MedicineChestSubsectionsPage _MedicineChestSubsectionsPage;

        public MedicineChestSubsectionsSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _MedicineChestSubsectionsPage = FeatureContext.Current.Get<Pages.MedicineChestSubsectionsPage>("MedicineChestSubsectionsPage");
        }

        [Given("I validate the full Repricing Section")]
        public void WhenIValidateTheFullRepricingSection()
        {
            When("I select Reprice Button from Med Chest");
            Then("I should be on the Reprice Select Medications page");
            When("I select All on Select Medications page");
            When("I select Next in Reprice Medications section");
            Then("I should be on the Reprice Select Method page");
            When("I select from Reprice a Method item of Method Selection One");
            Then("I should be on the Reprice Select Location page");
            When("I select Next in Reprice Medications section");
            Then("I should see a list of pharmacies");
            PressBackTwoTimes();
            When("I select from Reprice a Method item of Method Selection Two");
            When("I select Next in Reprice Medications section");
            Then("I should see a list of pharmacies");
            PressBackTwoTimes();
            When("I select from Reprice a Method item of Method Selection Three");
            When("I select Next in Reprice Medications section");
            Then("I should see a list of pharmacies");
            When("I select the toobar item of Medicine Chest");
        }

        [Given("I validate the full Share section in Med Chest")]
        public void WhenIValidateTheFullShareSectionInMedChest()
        {
            Then("I should be on the Share Medication page");
            When("I select Medication in Share Medications section");
            Then("I should be on the Share select Medications page");
            When("I select All on Select Medications page");
            When("I select Share in Share Medications section");
            app.Back();
            When("I select Reminders in Share Medications section");
            When("I select Dates in Share Medications Date Range section");
            When("I select Next in Reprice Medications section");
            Then("I should be on the Share select Reminders page");
            When("I select All on Select Medications page");
            When("I select Share in Share Medications section");
            When("I select the toobar item of Medicine Chest");
        }

        [Then("I should be on the Med Chest Archive page")]
        public void ThenIShouldBeOnTheMedChestArchivePage()
        {
            if (_MedicineChestPage.SwipeLeftPopupPage.Displayed())
            {
                _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.ArchivePageHeading, 5);
                _MedicineChestSubsectionsPage.ArchivePageHeading.Click();
            }
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.ArchivedDrugsPage, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.ArchivedDrugsPage.Displayed(), "Not on the Archived Drugs Page");
            Assert.IsTrue(_MedicineChestSubsectionsPage.ArchivePageHeading.Displayed(), "missing Archive Page Heading");
        }

        [When("I swipe to Restore a Medications from Med Chest Archive list")]
        public void WhenISwipeToRestoreAMedicationsFromMedChestArchivelist()
        {
            When("I need to dissmiss the Med Chest swipe Tutorial");
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.ArchiveMedicationName, 5);
            _MedicineChestSubsectionsPage.SwipeRightToLeft(_MedicineChestSubsectionsPage.ArchiveMedicationName.Locator);
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.ArchiveSwipeRestore, 5);
            _MedicineChestSubsectionsPage.ArchiveSwipeRestore.Click();
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.YesButton, 5);
            _MedicineChestSubsectionsPage.YesButton.Click();
        }

        [Then("I should see the Med Chest Archive empty message")]
        public void ThenIShouldSeeTheMedChestArchiveEmptyMessage()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.EmptyArchiveListMessage, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.EmptyArchiveListMessage.Displayed(), "missing empty Archive list message");
            app.Back();
        }

        [When("I select Delete All in the Archive Section")]
        public void WhenISelectDeleteAllInTheArchiveSection()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.DeleteAllContainer, 5);
            _MedicineChestSubsectionsPage.DeleteAllContainer.Click();
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.YesButton, 5);
            _MedicineChestSubsectionsPage.YesButton.Click();
        }

        [Then("I should be on the Reprice Select Medications page")]
        public void ThenIShouldBeOnTheRepriceSelectMedicationsPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.RepricingSelectPage, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.RepricingSelectPage.Displayed(), "Not on the Repricing Select Page");
            Assert.IsTrue(_MedicineChestSubsectionsPage.SelectMedicationsHeading.Displayed(), "missing Select Medications Heading");
            Assert.IsTrue(_MedicineChestSubsectionsPage.MedicationListView.Displayed(), "missing Medication List View");
            Assert.IsTrue(_MedicineChestSubsectionsPage.PillListImage.Displayed(), "missing Pill List Image");
            Assert.IsTrue(_MedicineChestSubsectionsPage.PillListName.Displayed(), "missing Pill List Name");
            Assert.IsTrue(_MedicineChestSubsectionsPage.PillListText.Displayed(), "missing Pill List Text");
        }

        [When("I select All on Select Medications page")]
        public void WhenISelectAllAndNextOnSelectMedicationsPage()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.SelectAllLinkButton, 5);
            _MedicineChestSubsectionsPage.SelectAllLinkButton.Click();
        }

        [When("I select Next in Reprice Medications section")]
        public void WhenISelectNextInRepriceMedicationSection()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.NextButton, 5);
            _MedicineChestSubsectionsPage.NextButton.Click();
        }

        [Then("I should be on the Reprice Select Method page")]
        public void ThenIShouldBeOnTheRepriceSelectMethodPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.RepricingMethodPage, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.RepricingMethodPage.Displayed(), "Not on the Repricing Method Page");
            Assert.IsTrue(_MedicineChestSubsectionsPage.RepricingMethodHeader.Displayed(), "missing Repricing Method Header");
            Assert.IsTrue(_MedicineChestSubsectionsPage.RepricingMethodList.Displayed(), "missing Medication List View");
            Assert.IsTrue(_MedicineChestSubsectionsPage.MethodSelectionDetails.Displayed(), "missing Method Selection Details");
        }

        [When("I select from Reprice a Method item of (Method Selection One|Method Selection Two|Method Selection Three)")]
        public void WhenISelectFromRepriceAMethodItemOf(string methodItem)
        {
            switch (methodItem.ToLower())
            {
                case "method selection one":
                    _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.MethodSelectionOne, 5);
                    _MedicineChestSubsectionsPage.MethodSelectionOne.Click();
                    break;
                case "method selection two":
                    _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.MethodSelectionTwo, 5);
                    _MedicineChestSubsectionsPage.MethodSelectionTwo.Click();
                    break;
                case "method selection three":
                    _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.MethodSelectionThree, 5);
                    _MedicineChestSubsectionsPage.MethodSelectionThree.Click();
                    break;

                default:
                    Assert.Fail(methodItem + ": Method Selection item is not supported at the moment.");
                    break;
            }
        }

        [Then("I should be on the Reprice Select Location page")]
        public void ThenIShouldBeOnTheRepriceSelectLocationPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.RepricingLocationPage, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.RepricingLocationPage.Displayed(), "Not on the Repricing Location Page");
            Assert.IsTrue(_MedicineChestSubsectionsPage.RepricingLocationHeader.Displayed(), "missing Repricing Location Header");
            Assert.IsTrue(_MedicineChestSubsectionsPage.SearchMedicationLocationEntry.Displayed(), "missing Search Medication Location Entry");
            Assert.IsTrue(_MedicineChestSubsectionsPage.UseLocationLinkButton.Displayed(), "missing Use Location Link Button");
        }

        [Then("I should be on the Share Medication page")]
        public void ThenIShouldBeOnTheShareMedicationPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.SharePageHeading, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.SharePageHeading.Displayed(), "Not on the Share Page.");
            Assert.IsTrue(_MedicineChestSubsectionsPage.MedicationsButton.Displayed(), "missing Medications Buttony.");
            Assert.IsTrue(_MedicineChestSubsectionsPage.RemindersButton.Displayed(), "missing Reminders Button.");
        }

        [When("I select Medication in Share Medications section")]
        public void WhenISelectMedicationInShareMedicationSection()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.MedicationsButton, 5);
            _MedicineChestSubsectionsPage.MedicationsButton.Click();
        }

        [When("I select Reminders in Share Medications section")]
        public void WhenISelectRemindersInShareMedicationSection()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.RemindersButton, 5);
            _MedicineChestSubsectionsPage.RemindersButton.Click();
        }

        [Then("I should be on the Share select Medications page")]
        public void ThenIShouldBeOnTheShareSelectMedicationsPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.SelectMedicationsPage, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.SelectMedicationsPage.Displayed(), "Not on the Select Medications Page Page.");
            Assert.IsTrue(_MedicineChestSubsectionsPage.SharePageHeading.Displayed(), "missing Select Medications Heading.");
            Assert.IsTrue(_MedicineChestSubsectionsPage.MedicationListView.Displayed(), "missing Medication List View.");
        }

        [When("I select Share in Share Medications section")]
        public void WhenISelectShareInShareMedicationSection()
        {
            //This needs to be done like this since android is unable to do the Share flow
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.ShareMedicationButton, 5);
                Assert.IsTrue(_MedicineChestSubsectionsPage.ShareMedicationButton.Displayed(), "missing Share Medication Button.");
                Assert.IsTrue(_MedicineChestSubsectionsPage.ShareMedicationButton.Enabled(), "Share Medication Button not enabled.");
            }
            else
            {
                _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.ShareMedicationButton, 5);
                _MedicineChestSubsectionsPage.ShareMedicationButton.Click();
                _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.CancelButton, 5);
                _MedicineChestPage.CancelButton.Click();
            } 
        }

        [When("I select Dates in Share Medications Date Range section")]
        public void WhenISelectDatesInShareMedicationsDateRangeSection()
        {
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.StartDateRow, 5);
            _MedicineChestSubsectionsPage.StartDateRow.Click();
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.OkButton, 5);
            _MedicineChestSubsectionsPage.OkButton.Click();
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.EndDateRow, 5);
            _MedicineChestSubsectionsPage.EndDateRow.Click();
            _MedicineChestSubsectionsPage.WaitForElementPresent(_MedicineChestSubsectionsPage.OkButton, 5);
            _MedicineChestSubsectionsPage.OkButton.Click();
        }

        [Then("I should be on the Share select Reminders page")]
        public void ThenIShouldBeOnTheShareSelectRemindersPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestSubsectionsPage.SharePageHeading, 5);
            Assert.IsTrue(_MedicineChestSubsectionsPage.SharePageHeading.Displayed(), "Not on the Select Reminders Page.");
            Assert.IsTrue(_MedicineChestSubsectionsPage.ReminderListView.Displayed(), "missing Reminder List View.");
            Assert.IsTrue(_MedicineChestSubsectionsPage.SelectRemindersCheckBox.Displayed(), "missing Medication List View.");
        }

        private void PressBackTwoTimes()
        {
            app.Back();
            Thread.Sleep(4000);
            app.Back();
        }
    }
}
