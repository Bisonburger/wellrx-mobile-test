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
    public class MedicineChestDetailsSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.MedicineChestDetailsPage _MedicineChestDetailsPage;
        readonly Pages.MedicineChestSubsectionsPage _MedicineChestSubsectionsPage;
        readonly Pages.MedicineChestReminderPage _MedicineChestReminderPage;

        public MedicineChestDetailsSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _MedicineChestDetailsPage = FeatureContext.Current.Get<Pages.MedicineChestDetailsPage>("MedicineChestDetailsPage");
            _MedicineChestSubsectionsPage = FeatureContext.Current.Get<Pages.MedicineChestSubsectionsPage>("MedicineChestSubsectionsPage");
            _MedicineChestReminderPage = FeatureContext.Current.Get<Pages.MedicineChestReminderPage>("MedicineChestReminderPage");
        }


        [Given("I am on Medication Details for Med Chest")]
        public void GivenIAmOnMedicationDetailsForMedChest()
        {
            When("I add a Medications for Med Chest");
            When("I select the Add Medications Button with additional checks");
            Then("I should be navigated to the medicine chest page with a list");
            When("I select a Medication from Med Chest");
            Then("I should be on the med chest Medication Details page");
        }

        [Then("I should be on the med chest Medication Details page")]
        public void ThenIShouldBeOnTheMedChestMedicationDetailsPage()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedChestDetailPage, 5);
            Assert.IsTrue(_MedicineChestDetailsPage.MedChestDetailPage.Displayed(), "not on Med Chest Detail Page.");
            Assert.IsTrue(_MedicineChestDetailsPage.MedicationPillImage.Displayed(), "missing Medication Pill Image.");
            Assert.IsTrue(_MedicineChestDetailsPage.MedicationPillName.Displayed(), "missing Medication Pill Name.");
            Assert.IsTrue(_MedicineChestDetailsPage.MedicationPillInformation.Displayed(), "missing Medication Pill Information.");
            Assert.IsTrue(_MedicineChestDetailsPage.PreferredPharmacyText.Displayed(), "missing Preferred Pharmacy Text.");
        }

        [When("I select the tab for Med Chest details of (Medications|Notifications|Information)")]
        public void WhenISelectTheTabForMedChestDetailsOf(string medChestTab)
        {
            switch (medChestTab.ToLower())
            {
                case "medications":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicationTabButton, 5);
                    _MedicineChestDetailsPage.MedicationTabButton.Click();
                    break;
                case "notifications":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.NotificationsTabButton, 5);
                    _MedicineChestDetailsPage.NotificationsTabButton.Click();
                    break;
                case "information":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.InformationTabButton, 5);
                    _MedicineChestDetailsPage.InformationTabButton.Click();
                    break;

                default:
                    Assert.Fail(medChestTab + ": Medication Details tab is not supported at the moment.");
                    break;
            }
        }

        [When("I change Medications information for Med Chest details")]
        public void WhenIChangeMedicationsInformationForMedChestDetails()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.DoseFormRow, 5);
            _MedicineChestDetailsPage.DoseFormRow.Click();
            _MedicineChestDetailsPage.CancelButton.Click();
            _MedicineChestDetailsPage.StrengthRow.Click();
            _MedicineChestDetailsPage.ChooseStrength300MG.Click();
            if (_MedicineChestDetailsPage.YesButton.Displayed())
                _MedicineChestDetailsPage.YesButton.Click();
            _MedicineChestDetailsPage.QuantityRow.Click();
            _MedicineChestDetailsPage.ChooseQuantity30.Click();
            _MedicineChestDetailsPage.AtPreferredIcon.Click();
        }

        [When("I select Save Changes for Med Chest details")]
        public void WhenISelectSaveChangesForMedChestDetails()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.SaveButton, 5);
            _MedicineChestDetailsPage.SaveButton.Click();
        }

        [Then("I should see Med Chest details message reads as")]
        public void ThenIShouldSeeMedChestDetailsMessageReadsAs(string multiline)
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedChestDetailMessage, 5);
            Assert.AreEqual(multiline, _MedicineChestDetailsPage.MedChestDetailMessage.GetText(), "The message does not match");
        }

        [When("I Delete a medication from Med Chest details")]
        public void WhenIDeleteAMedicationFromMedChestDetails()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.TrashIcon, 3);
            _MedicineChestDetailsPage.TrashIcon.Click();
            if (!_MedicineChestDetailsPage.YesButton.Displayed())
                _MedicineChestDetailsPage.TrashIcon.Click();
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.YesButton, 3);
            _MedicineChestDetailsPage.YesButton.Click();
        }

        [When("I Archive a Medications from Med Chest details")]
        public void WhenIArchiveAMedicationsFromMedChestDetails()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListName, 3);
            _MedicineChestPage.PillListName.Click();
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MoveToArchiveButton, 3);
            _MedicineChestDetailsPage.MoveToArchiveButton.Click();
        }

        [When("I select Pill Reminder for Med Chest Notifications Tab")]
        public void WhenISelectPillReminderForMedChestNotificationsTab()
        {
            if (!_MedicineChestDetailsPage.AlertSetText.Displayed())
            {
                _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.PillReminderRow, 3);
                _MedicineChestDetailsPage.PillReminderRow.Click();
                When("I toggle the Toggle Switch");
                When("I fill out Pill Reminder information");
                When("I save the Reminder selections");
            }
            else
                Assert.IsTrue(_MedicineChestDetailsPage.AlertSetText.Displayed(), "Missing Alert Set Text");
        }

        [When("I select Refill Reminder for Med Chest Notifications Tab")]
        public void WhenISelectRefillReminderForMedChestNotificationsTab()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.RefillReminderRow, 5);
            _MedicineChestDetailsPage.RefillReminderRow.Click();
            When("I toggle the Toggle Switch");
            When("I fill out Refill Reminder information");
            When("I save the Reminder selections");
        }

        [Then("I should be on the med chest Medication Details Notfication tab")]
        public void ThenIShouldBeOnTheMedChestMedicationDetailsNotficationTab()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicationInformation, 5);
            Assert.IsTrue(_MedicineChestDetailsPage.MedicationInformation.Displayed(), "not on Med Chest Detail Medication Information tab.");
            Assert.IsTrue(_MedicineChestDetailsPage.MedicationInformationCardsOne.Displayed(), "missing Medication Information Cards.");
        }

        [When("I select a card for Med Chest Notfication details of (Information Cards One|Information Cards Two|Information Cards Three|Information Cards Four)")]
        public void WhenISelectACardForMedChestNotficationDetailsOf(string notficationCard)
        {
            switch (notficationCard.ToLower())
            {
                case "information cards one":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicationInformationCardsOne, 5);
                    _MedicineChestDetailsPage.MedicationInformationCardsOne.Click();
                    break;
                case "information cards two":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicationInformationCardsTwo, 5);
                    _MedicineChestDetailsPage.MedicationInformationCardsTwo.Click();
                    break;
                case "information cards three":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicationInformationCardsThree, 5);
                    _MedicineChestDetailsPage.MedicationInformationCardsThree.Click();
                    break;
                case "information cards four":
                    _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicationInformationCardsFour, 5);
                    _MedicineChestDetailsPage.MedicationInformationCardsFour.Click();
                    break;

                default:
                    Assert.Fail(notficationCard + ": Notfication Card is not supported at the moment.");
                    break;
            }
        }

        [Then("I should be on the Drug Content page for Notfication details")]
        public void ThenIShouldBeOnTheDrugContentPageForNotficationDetailsb()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.DrugContentPage, 5);
            Assert.IsTrue(_MedicineChestDetailsPage.DrugContentPage.Displayed(), "not on Med Chest Detail Medication Information Drug Content Page.");
            Assert.IsTrue(_MedicineChestDetailsPage.EnglishButton.Displayed(), "missing English Button.");
            Assert.IsTrue(_MedicineChestDetailsPage.SpanishButton.Displayed(), "missing Spanish Button.");
            app.Back();
        }

        [Then("I should be on the Drug Images page for Notfication details")]
        public void ThenIShouldBeOnTheDrugImagesPageForNotficationDetailsb()
        {

            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.DrugImagesPage, 5);
            Assert.IsTrue(_MedicineChestDetailsPage.DrugImagesPage.Displayed(), "not on Med Chest Detail Medication Information Drug Images Page.");
            Assert.IsTrue(_MedicineChestDetailsPage.DrugImageRepeaterView.Displayed(), "missing Drug Images View.");
            app.Back();
        }

        [Then("I should be on the Drug Videos page for Notfication details")]
        public void ThenIShouldBeOnTheDrugVideosPageForNotficationDetailsb()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.MedicineVideoPage, 5);
            Assert.IsTrue(_MedicineChestDetailsPage.MedicineVideoPage.Displayed(), "not on Med Chest Detail Medication Information Drug Videos Page.");
            Assert.IsTrue(_MedicineChestDetailsPage.MedicationVideos.Displayed(), "missing Drug Videos View.");
            if (_MedicineChestDetailsPage.BackToDashboardButton.Displayed())
                _MedicineChestDetailsPage.BackToDashboardButton.Click();
            else
            app.Back();
        }

        [Then("I should be on the Life Style Interaction page for Notfication details")]
        public void ThenIShouldBeOnTheLifeStyleInteractionPageForNotficationDetails()
        {
            _MedicineChestDetailsPage.WaitForElementPresent(_MedicineChestDetailsPage.LifestyleInteractionsPage, 5);
            Assert.IsTrue(_MedicineChestDetailsPage.LifestyleInteractionsPage.Displayed(), "not on Med Chest Detail Medication Information Lifestyle Interactions Page.");
            Assert.IsTrue(_MedicineChestDetailsPage.CautionImage.Displayed(), "missing Caution Image.");
            Assert.IsTrue(_MedicineChestDetailsPage.NumberOfInteractions.Displayed(), "missing Number Of Interactions.");
            Assert.IsTrue(_MedicineChestDetailsPage.InteractionsExtendedText.Displayed(), "missing Interactions Extended Text.");
            Assert.IsTrue(_MedicineChestPage.ShareButton.Displayed(), "missing Android Share Button.");
            if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                _MedicineChestPage.IosShareButton.Click();
                _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.CancelButton, 3);
                _MedicineChestPage.CancelButton.Click();
            }
            app.Back();
        }
    }
}
