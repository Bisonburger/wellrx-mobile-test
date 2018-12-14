using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class ManageYourProfileSubsectionSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.DashboardPage _DashboardPage;
        readonly Pages.ManageYourProfilePage _ManageYourProfilePage;
        readonly Pages.EditProfilePage _EditProfilePage;
        readonly Pages.ManageYourProfileSubSectionsPage _ManageYourProfileSubSectionsPage;

        public ManageYourProfileSubsectionSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");
            _ManageYourProfilePage = FeatureContext.Current.Get<Pages.ManageYourProfilePage>("ManageYourProfilePage");
            _EditProfilePage = FeatureContext.Current.Get<Pages.EditProfilePage>("EditProfilePage");
            _ManageYourProfileSubSectionsPage = FeatureContext.Current.Get<Pages.ManageYourProfileSubSectionsPage>("ManageYourProfileSubSectionsPage");
        }


        [Then("I should be on Edit Condition Details")]
        public void ThenIShouldBeOnEditConditionDetails()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.EditConditionDetailsHeader, 5);
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditConditionDetailsHeader.Displayed(), "The Edit Condition Details View is not present");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditConditionDetailsText.Displayed(), "The Edit Condition Details Text is not present");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.SelectHealthTypeSelections.Displayed(), "The Select Health Type Selections is not present");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.SelectConditionsSelections.Displayed(), "The Select Conditions Selections is not present");
        }

        [When("I select the Edit Condition Health Type")]
        public void WhenISelectTheEditConditionHealthType()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.GeneralHealth, 5);
            _ManageYourProfileSubSectionsPage.MensHealth.Click();
            _ManageYourProfileSubSectionsPage.WomensHealth.Click();
            _ManageYourProfileSubSectionsPage.GeneralHealth.Click();
        }

        [When("I select the Edit Condition Condition Type")]
        public void WhenISelectTheEditConditionConditionType()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.Diabetes, 5);
            _ManageYourProfileSubSectionsPage.Diabetes.Click();
            _ManageYourProfileSubSectionsPage.HeartHealth.Click();
            _ManageYourProfileSubSectionsPage.PregnancyAndMaternity.Click();
            When("I select the Edit Condition Save button");
        }

        [When("I select the Edit Condition Save button")]
        public void WhenISelectTheEditConditionSaveButton()
        {
            if (!_ManageYourProfileSubSectionsPage.SaveConditionButton.Displayed())
                _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.SaveConditionButton.Locator);

            _ManageYourProfileSubSectionsPage.SaveConditionButton.Click();
        }

        [When("I need the Edit Condition Condition Type reset")]
        public void WhenINeedtheEditConditionConditionTypeReset()
        {
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                if (_ManageYourProfileSubSectionsPage.Diabetes.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.Diabetes.Click();

                if (_ManageYourProfileSubSectionsPage.HeartHealth.AndroidGetElementColor())
                   _ManageYourProfileSubSectionsPage.HeartHealth.Click();

                if (_ManageYourProfileSubSectionsPage.PregnancyAndMaternity.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.PregnancyAndMaternity.Click();
            }
            else
            {
                if (_ManageYourProfileSubSectionsPage.Diabetes.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.Diabetes.Click();
               
                if (_ManageYourProfileSubSectionsPage.HeartHealth.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.HeartHealth.Click();

                if (_ManageYourProfileSubSectionsPage.PregnancyAndMaternity.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.PregnancyAndMaternity.Click();
            }
        }

        [Then("I should be on Edit Allergens Details")]
        public void ThenIShouldBeOnEditAllergensDetails()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.EditAllergensPage, 3);
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditAllergensPage.Displayed(), "The Edit Allergens Page is not present.");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditAllergenHeader.Displayed(), "Missing Edit Allergen Header.");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditAllergenText.Displayed(), "Missing Edit Allergen Text.");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.SelectAllergyOptions.Displayed(), "Missing Select Allergy Options.");
        }

        [When("I need the Edit Allergens section reset")]
        public void WhenINeedtheEditAllergensSectionReset()
        {
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                if (_ManageYourProfileSubSectionsPage.ShellfishFree.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.ShellfishFree.Click();
                if (!_ManageYourProfileSubSectionsPage.DairyFree.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.DairyFree.Locator);
                if (_ManageYourProfileSubSectionsPage.DairyFree.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.DairyFree.Click();
                if (!_ManageYourProfileSubSectionsPage.ShellfishFree.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollUpTo(_ManageYourProfileSubSectionsPage.ShellfishFree.Locator);
            }
            else
            {
                if (_ManageYourProfileSubSectionsPage.ShellfishFree.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.ShellfishFree.Click();
                if (!_ManageYourProfileSubSectionsPage.DairyFree.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.DairyFree.Locator);
                if (_ManageYourProfileSubSectionsPage.DairyFree.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.DairyFree.Click();
                if (!_ManageYourProfileSubSectionsPage.ShellfishFree.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollUpTo(_ManageYourProfileSubSectionsPage.ShellfishFree.Locator);
            }
        }

        [When("I select the Allergens Details Save button")]
        public void WhenISelectTheAllergensDetailsSaveButton()
        {
            if (!_ManageYourProfileSubSectionsPage.SaveAllergenButton.Displayed())
                _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.SaveAllergenButton.Locator);
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.SaveAllergenButton, 3);
            _ManageYourProfileSubSectionsPage.SaveAllergenButton.Click();
        }

        [When("I select the Edit Allergens Prefrences")]
        public void WhenISelectTheEditAllergensPrefrences()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.ShellfishFree, 3);
            _ManageYourProfileSubSectionsPage.ShellfishFree.Click();
            if (!_ManageYourProfileSubSectionsPage.DairyFree.Displayed())
                _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.DairyFree.Locator);
            _ManageYourProfileSubSectionsPage.DairyFree.Click();
            When("I select the Allergens Details Save button");
        }

        [Then("I should be on Edit Dietary Preferences Details")]
        public void ThenIShouldBeOnEditDietaryPreferencesDetails()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.EditDietaryPage, 3);
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditDietaryPage.Displayed(), "The Edit Dietary Page Page is not present.");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditDietaryHeader.Displayed(), "Missing Edit Dietary Header.");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditDietaryText.Displayed(), "Missing Edit Dietary Text.");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.SelectDietaryProgramsOptions.Displayed(), "Missing Select Dietary Programs Options.");
        }

        [When("I need the Dietary Preferences section reset")]
        public void WhenINeedtheEditDietaryPreferencesSectionReset()
        {
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                if (_ManageYourProfileSubSectionsPage.WeightWatchers.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.WeightWatchers.Click();
                if (!_ManageYourProfileSubSectionsPage.LowFat.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.LowFat.Locator);
                if (_ManageYourProfileSubSectionsPage.LowFat.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.LowFat.Click();
                if (!_ManageYourProfileSubSectionsPage.Vegetarian.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.Vegetarian.Locator);
                if (_ManageYourProfileSubSectionsPage.Vegetarian.AndroidGetElementColor())
                    _ManageYourProfileSubSectionsPage.Vegetarian.Click();
                if (!_ManageYourProfileSubSectionsPage.WeightWatchers.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollUpTo(_ManageYourProfileSubSectionsPage.WeightWatchers.Locator);
            }
            else
            {
                if (_ManageYourProfileSubSectionsPage.WeightWatchers.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.WeightWatchers.Click();
                if (!_ManageYourProfileSubSectionsPage.LowFat.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.LowFat.Locator);
                if (_ManageYourProfileSubSectionsPage.LowFat.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.LowFat.Click();
                if (!_ManageYourProfileSubSectionsPage.Vegetarian.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.Vegetarian.Locator);
                if (_ManageYourProfileSubSectionsPage.Vegetarian.iOSGetElementColor())
                    _ManageYourProfileSubSectionsPage.Vegetarian.Click();
                if (!_ManageYourProfileSubSectionsPage.WeightWatchers.Displayed())
                    _ManageYourProfileSubSectionsPage.ScrollUpTo(_ManageYourProfileSubSectionsPage.WeightWatchers.Locator);
            }
        }

        [When("I select the Dietary Preferences Save button")]
        public void WhenISelectTheDietaryPreferencesSaveButton()
        {
            if (!_ManageYourProfileSubSectionsPage.SaveDietaryButton.Displayed())
                _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.SaveDietaryButton.Locator);
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.SaveDietaryButton, 3);
            _ManageYourProfileSubSectionsPage.SaveDietaryButton.Click();
        }

        [When("I select the Edit Dietary Preferences options")]
        public void WhenISelectTheEditDietaryPreferencesOptions()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.WeightWatchers, 3);
            _ManageYourProfileSubSectionsPage.WeightWatchers.Click();
            if (!_ManageYourProfileSubSectionsPage.LowFat.Displayed())
                _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.LowFat.Locator);
            _ManageYourProfileSubSectionsPage.LowFat.Click();
            if (!_ManageYourProfileSubSectionsPage.Vegetarian.Displayed())
                _ManageYourProfileSubSectionsPage.ScrollDownTo(_ManageYourProfileSubSectionsPage.Vegetarian.Locator);
            _ManageYourProfileSubSectionsPage.Vegetarian.Click();
            When("I select the Dietary Preferences Save button");
        }
    }
}
