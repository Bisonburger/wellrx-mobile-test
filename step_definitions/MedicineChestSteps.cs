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
    public class MedicineChestSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.MedicineChestSubsectionsPage _MedicineChestSubsectionsPage;
        readonly Pages.PharmacyDrugInfoPage _PharmacyDrugInfoPage;

        public MedicineChestSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _MedicineChestSubsectionsPage = FeatureContext.Current.Get<Pages.MedicineChestSubsectionsPage>("MedicineChestSubsectionsPage");
            _PharmacyDrugInfoPage = FeatureContext.Current.Get<Pages.PharmacyDrugInfoPage>("PharmacyDrugInfoPage");
        }

        [When("I add a Medications for Med Chest")]
        public void WhenIAddAMedicationsForMedChest()
        {
            When("I select the Add Medications Button");
            When("I select the Enter Medications Search for Med Chest");
            When("I enter plavix as drug name without using the autocomplete");
            When("I Enter Medications information for Med Chest");
        }

        [When("I add a secound Medication of (.*) for Med Chest")]
        public void WhenIAddASecoundMedicationOFDrugForMedChest(string drugName)
        {
            //This function can add any medication that does NOT require to input additional information
            //Examples are: Thrombate iii, Apokyn
            When("I select the Add Medications Button");
            When("I select the Enter Medications Search for Med Chest");
            When("I enter "+ drugName+ " as drug name without using the autocomplete");
            When("I select the Add Medications Button with additional checks");
        }

        [Then("I should see empty chest message")]
        public void ThenIShouldSeeEmptyChestMessage()
        {
            When("I need to dissmiss the Med Chest swipe Tutorial");
            if (_MedicineChestPage.ViewArchiveButton.Displayed())
            {
                When("I select View Archive Button from Med Chest");
                Then("I should be on the Med Chest Archive page");
                if(!_MedicineChestSubsectionsPage.EmptyArchiveListMessage.Displayed())
                When("I select Delete All in the Archive Section");
                Then("I should see the Med Chest Archive empty message");
            }
            int tries = 0;
            while (!_MedicineChestPage.EmptyChestMsg.Displayed())
            {
                When("I swipe to delete a Medications from Med Chest list");
                if(_MedicineChestPage.MedChestError.Displayed())
                    break;
                tries++;
                if (tries > 5)
                    break;
            }
            Assert.IsTrue(_MedicineChestPage.EmptyChestMsg.Displayed(), "missing empty chest message");
        }

        [Then("I should be navigated to the medicine chest page")]
        public void ThenIShouldBeNavigatedToTheMedicineChestPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.MedChestPage, 5);
            When("I need to dissmiss the Med Chest swipe Tutorial");
            Assert.IsTrue(_MedicineChestPage.MedChestPage.Displayed(), "not on medicine chest page.");
            Assert.IsTrue(_MedicineChestPage.AddMedications.Displayed(), "missing add med button.");
        }

        [When("I select the Med Chest Create Account")]
        public void WhenISelectTheMedChestCreateAccount()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.MedChestCreateAccount, 5);
            _MedicineChestPage.MedChestCreateAccount.Click();
        }

        [When("I select the Add Medications Button")]
        public void WhenISelectTheAddMedicationsButton()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.AddMedications, 5);
            _MedicineChestPage.AddMedications.Click();
        }

        [When("I select the Add Medications Button with additional checks")]
        public void WhenISelectTheAddMedicationsButtonWithAdditionalcChecks()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.AddMedications, 5);
            _MedicineChestPage.AddMedications.Click();
            if (_MedicineChestPage.AddMedicationsError.Displayed())
                app.Back();
            if (_MedicineChestPage.DrugInteractionsPage.Displayed())
                When("I select Add Medication on the Drug Interaction screen");
            if (_MedicineChestPage.NoButton.Displayed())
                _MedicineChestPage.NoButton.Click();
        }

        [When("I select the Med Chest Import Option")]
        public void WhenISelectTheMedChestImportOption()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.ImportTabButton, 5);
            _MedicineChestPage.ImportTabButton.Click();
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.ManuallyEnterBtn, 5);
            _MedicineChestPage.ManuallyEnterBtn.Click();
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                Thread.Sleep(2000);
                app.Back();
            }
        }

        [When("I select the Enter Medications Search for Med Chest")]
        public void WhenISelectTheEnterMedicationsSearchForMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.DrugNameContainer, 5);
            _MedicineChestPage.DrugNameContainer.Click();
        }

        [When("I Enter Medications information for Med Chest")]
        public void WhenIEnterMedicationsInformationForMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.DrugFormRow, 5);
            _MedicineChestPage.DrugFormRow.Click();
            _MedicineChestPage.ChooseFormTablet.Click();
            _MedicineChestPage.DrugStrengthRow.Click();
            _MedicineChestPage.ChooseStrength75MG.Click();
            _MedicineChestPage.DrugQuantityRow.Click();
            _MedicineChestPage.ChooseQuantity15.Click();
        }

        [Then("I should be navigated to the medicine chest page with a list")]
        public void ThenIShouldBeNavigatedToTheMedicineChestPageWithAList()
        {
            When("I need to dissmiss the Med Chest swipe Tutorial");
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.MedChestListView, 5);
            Assert.IsTrue(_MedicineChestPage.MedChestListView.Displayed(), "not on medicine chest page.");
            Assert.IsTrue(_MedicineChestPage.AddMedications.Displayed(), "missing add med button.");
            Assert.IsTrue(_MedicineChestPage.PillListImage.Displayed(), "missing Pill List Image.");
            Assert.IsTrue(_MedicineChestPage.PillListName.Displayed(), "missing Pill List Name.");
        }

        [When("I select a Medications from Med Chest")]
        public void WhenISelectAMedicationsFromMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListName, 5);
            _MedicineChestPage.PillListName.Click();
        }

        [When("I swipe to delete a Medications from Med Chest list")]
        public void WhenISwipeToDeleteAMedicationsFromMedChestList()
        {
            When("I need to dissmiss the Med Chest swipe Tutorial");
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListName, 5);
            _MedicineChestPage.SwipeRightToLeft(_MedicineChestPage.PillListName.Locator);
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.DeleteButton, 5);
            _MedicineChestPage.DeleteButton.Click();
            _MedicineChestPage.YesButton.Click();
        }

        [When("I swipe to Archive a Medications from Med Chest list")]
        public void WhenISwipeToArchiveAMedicationsFromMedChestList()
        {
            When("I need to dissmiss the Med Chest swipe Tutorial");
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListName, 5);
            _MedicineChestPage.SwipeRightToLeft(_MedicineChestPage.PillListName.Locator);
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.ArchiveButton, 5);
            _MedicineChestPage.ArchiveButton.Click();
        }

        [When("I select Pill Reminder from Med Chest Manual Entry")]
        public void WhenISelectPillReminderFromMedChestManualEntry()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillReminderRow, 5);
            _MedicineChestPage.PillReminderRow.Click();
        }

        [Then("I should see the Bell notfication icon")]
        public void ThenIShouldSeeTheBellNotficationIcon()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListBellIcon, 5);
            Assert.IsTrue(_MedicineChestPage.PillListBellIcon.Displayed(), "missing Pill List Bell Icon");
        }

        [When("I select Refill Reminder from Med Chest Manual Entry")]
        public void WhenISelectRefillReminderFromMedChestManualEntry()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.RefillReminderRow, 5);
            _MedicineChestPage.RefillReminderRow.Click();
        }

        [When("I need to dissmiss the Med Chest swipe Tutorial")]
        public void WhenINeedToDissmissTheMedChestSwipeTutorial()
        {
            if (_MedicineChestPage.SwipeLeftPopupPage.Displayed())
            {
                _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.MedChestHeader, 5);
                _MedicineChestPage.MedChestHeader.Click();
            }
        }

        [Then("I should see the Pill List Refill notfication icon")]
        public void ThenIShouldSeeThePillListRefillNotficationIcon()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListRefillIcon, 5);
            Assert.IsTrue(_MedicineChestPage.PillListRefillIcon.Displayed(), "missing Pill List Bell Icon");
        }

        [When("I select View Archive Button from Med Chest")]
        public void WhenISelectViewArchiveButtonFromMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.ViewArchiveButton, 5);
            _MedicineChestPage.ViewArchiveButton.Click();
        }

        [When("I select Reprice Button from Med Chest")]
        public void WhenISelectRepriceButtonFromMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.RepriceButton, 5);
            _MedicineChestPage.RepriceButton.Click();
        }

        [Given("I select Pharmacist Button from Med Chest")]
        public void WhenISelectPharmacistButtonFromMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PharmacistButton, 5);
            _MedicineChestPage.PharmacistButton.Click();
            Then("I should be on the Ask a Pharmacist Page");
            When("I select the toobar item of Medicine Chest");
        }

        [When("I select a Medication from Med Chest")]
        public void WhenISelectAMedicationFromMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.PillListName, 5);
            _MedicineChestPage.PillListName.Click();
        }

        [When("I select View Interactions from Med Chest")]
        public void WhenISelectViewInteractionsFromMedChest()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.DrugInteractionText, 5);
            _MedicineChestPage.DrugInteractionText.Click();
        }

        [Then("I should be on the Drug Interactions page")]
        public void ThenIShouldBeOnTheDrugInteractionsPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.DrugInteractionsPage, 5);
            Assert.IsTrue(_MedicineChestPage.DrugInteractionsPage.Displayed(), "Not on the Drug Interactions Page.");
            Assert.IsTrue(_MedicineChestPage.DrugInteractionsHeader.Displayed(), "missing Drug Interactions Header.");
            Assert.IsTrue(_MedicineChestPage.NumberOfInteractionsFoundLabel.Displayed(), "missing Number Of Interactions Found Label.");
            Assert.IsTrue(_MedicineChestPage.SeverityInteractionsText.Displayed(), "missing Severity Interactions Text.");
            Assert.IsTrue(_MedicineChestPage.ShareButton.Displayed(), "missing Android Share Button.");
            if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                _MedicineChestPage.IosShareButton.Click();
                _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.CancelButton, 5);
                _MedicineChestPage.CancelButton.Click();
            }
            app.Back();
        }

        [When("I select Add Medication on the Drug Interaction screen")]
        public void WhenISelectAddMedicationOntheDrugInteractionScreen()
        {
            _PharmacyDrugInfoPage.ScrollDownTo(_PharmacyDrugInfoPage.AddToChest.Locator, ScrollStrategy.Gesture);
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.AddToChest, 5);
            _PharmacyDrugInfoPage.AddToChest.Click();
        }

        [When("I select the Share icon on the Med Chest Page")]
        public void WhenISelectTheShareIconOnTheMedChestPage()
        {
            _MedicineChestPage.WaitForElementPresent(_MedicineChestPage.ShareButton, 5);
            _MedicineChestPage.ShareButton.Click();
        }
    }
}