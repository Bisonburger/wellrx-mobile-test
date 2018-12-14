using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class FoodIndexDetailsSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.FoodIndexPage _FoodIndexPage;
        readonly Pages.FoodIndexSearchPage _FoodIndexSearchPage;
        readonly Pages.FoodIndexFoodDetailsPage _FoodIndexFoodDetailsPage;
        readonly Pages.FoodIndexFoodIndexSectionPage _FoodIndexFoodIndexSectionPage;
        readonly Pages.FoodIndexNutritionSectionPage _FoodIndexNutritionSectionPage;
        readonly Pages.FoodIndexBetterForMeSection _FoodIndexBetterForMeSection;
        readonly Pages.LockedFeaturePage _LockedFeaturePage;

        public FoodIndexDetailsSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _FoodIndexPage = FeatureContext.Current.Get<Pages.FoodIndexPage>("FoodIndexPage");
            _FoodIndexSearchPage = FeatureContext.Current.Get<Pages.FoodIndexSearchPage>("FoodIndexSearchPage");
            _FoodIndexFoodDetailsPage = FeatureContext.Current.Get<Pages.FoodIndexFoodDetailsPage>("FoodIndexFoodDetailsPage");
            _FoodIndexFoodIndexSectionPage = FeatureContext.Current.Get<Pages.FoodIndexFoodIndexSectionPage>("FoodIndexFoodIndexSectionPage");
            _FoodIndexNutritionSectionPage = FeatureContext.Current.Get<Pages.FoodIndexNutritionSectionPage>("FoodIndexNutritionSectionPage");
            _FoodIndexBetterForMeSection = FeatureContext.Current.Get<Pages.FoodIndexBetterForMeSection>("FoodIndexBetterForMeSection");
            _LockedFeaturePage = FeatureContext.Current.Get<Pages.LockedFeaturePage>("LockedFeaturePage");
        }

        [When("I select the Summary tab")]
        public void WhenISelectTheSummaryTab()
        {
            int tries = 0;
            while (!_FoodIndexFoodDetailsPage.SummaryTabButon.Displayed())
            {
                _FoodIndexFoodDetailsPage.ScrollUp();
                tries++;
                if (tries == 10)
                    break;
            }
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.SummaryTabButon, 5);
            _FoodIndexFoodDetailsPage.SummaryTabButon.Click();
        }

        [Then("I should be on the food details summary tab")]
        public void ThenIShouldBeOnTheFoodDetailsSummaryTab()
        {
            _FoodIndexFoodDetailsPage.WaitForElementNotPresent(_FoodIndexFoodDetailsPage.LoadingIndecator, 6);
            Thread.Sleep(1000);
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.ProductSummarySection, 6);
            Assert.IsTrue(_FoodIndexFoodDetailsPage.ProductSummarySection.Displayed(), "Not on the Food Details Summary Tab");
            Assert.IsTrue(_FoodIndexFoodDetailsPage.ProductImage.Displayed(), "The food item image did not display");
            Assert.IsTrue(_FoodIndexFoodDetailsPage.FoodScoreSectionView.Displayed(), "Food Score Section View is not present");
        }

        [Then("I should see food details summary tab Circular Graph")]
        public void ThenIShouldSeeFoodDetailsSummaryTabCircularGraph()
        {
            if (!_FoodIndexNutritionSectionPage.CircularGraph.Displayed())
                _FoodIndexFoodDetailsPage.ScrollDownTo(_FoodIndexNutritionSectionPage.CircularGraph.Locator, ScrollStrategy.Gesture);

            Assert.IsTrue(_FoodIndexNutritionSectionPage.NutrientHighlightsSection.Displayed(), "The Nutrient Highlights Section is not displayed");
        }

        [When("I select Label Information")]
        public void WhenISelectLabelInformation()
        {
            if (!_FoodIndexFoodDetailsPage.ViewLabelInfoLabelButton.Displayed())
                _FoodIndexFoodDetailsPage.ScrollDownTo(_FoodIndexFoodDetailsPage.ViewLabelInfoLabelButton.Locator, ScrollStrategy.Gesture);

            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.ViewLabelInfoLabelButton, 5);
            _FoodIndexFoodDetailsPage.ViewLabelInfoLabelButton.Click();
        }

        [Then("I should see the Nutrition Facts")]
        public void ThenIShouldSeetheNutritionFacts()
        {
            if (!_FoodIndexFoodDetailsPage.NutritionFactsHeader.Displayed())
                _FoodIndexFoodDetailsPage.ScrollDownTo(_FoodIndexFoodDetailsPage.NutritionFactsHeader.Locator, ScrollStrategy.Gesture);
            
            Assert.IsTrue(_FoodIndexFoodDetailsPage.NutritionFactsHeader.Displayed(), "Nutrition Facts header is not present");
            Assert.IsTrue(_FoodIndexFoodDetailsPage.NutritionFactsText.Displayed(), "Nutrition Facts text is not present");
            if (!_FoodIndexFoodDetailsPage.NutritionFactsTable.Displayed())
                _FoodIndexFoodDetailsPage.ScrollDownTo(_FoodIndexFoodDetailsPage.NutritionFactsTable.Locator, ScrollStrategy.Gesture);

            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.NutritionFactsTable, 5);
            Assert.IsTrue(_FoodIndexFoodDetailsPage.NutritionFactsTable.Displayed(), "Nutrition Facts Table is not present");

        }

        [When("I scroll to the Better For Me View More")]
        public void WhenIScrollToTheBetterForMeViewMore()
        {
            if (!_FoodIndexFoodDetailsPage.BetterForMeViewMoreButton.Displayed())
                _FoodIndexFoodDetailsPage.ScrollDownTo(_FoodIndexFoodDetailsPage.BetterForMeViewMoreButton.Locator, ScrollStrategy.Gesture);

            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.BetterForMeViewMoreButton, 5);
        }

        [Then("I should see Better For Me Options")]
        public void ThenIShouldSeeBetterForMeOptions()
        {
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.BetterForMeSummaryView, 5);
            Assert.IsTrue(_FoodIndexFoodDetailsPage.BetterForMeHeader.Displayed(), "Better for me header is not present");
            Assert.IsTrue(_FoodIndexBetterForMeSection.BetterForMeScore.Displayed(), "Better for me score is not present");
            Assert.IsTrue(_FoodIndexFoodDetailsPage.BetterForMeSummarySection.Displayed(), "Better for me section is not present");
        }

        [When("I select Nutrition Facts View More option")]
        public void WhenISelectNutritionFactsViewMoreOption()
        {
            When("I select Label Information");
            When("I scroll to the Better For Me View More");
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.NutritionFactsViewMoreButton, 5);
            _FoodIndexFoodDetailsPage.NutritionFactsViewMoreButton.Click();
        }

        [Then("I should be on the food details Calorie Breakdown")]
        public void ThenIShouldBeOnTheFoodDetailsCalorieBreakdown()
        {
            _FoodIndexNutritionSectionPage.WaitForElementPresent(_FoodIndexNutritionSectionPage.FatCalorieLabel, 5);
            Assert.IsTrue(_FoodIndexNutritionSectionPage.FatCalorieSectionView.Displayed(), "Fat Calorie Section View is not present");
        }

        [When("I select Better For Me View More")]
        public void WhenISelectBetterForMeViewMore()
        {
            When("I scroll to the Better For Me View More");
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.BetterForMeViewMoreButton, 5);
            _FoodIndexFoodDetailsPage.BetterForMeViewMoreButton.Click();
        }

        [When("I select the Food Index tab")]
        public void WhenISelectTheFoodIndexTab()
        {
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.FoodIndexTabButon, 5);
            _FoodIndexFoodDetailsPage.FoodIndexTabButon.Click();
        }

        [Then("I should be on the Food Index Tab")]
        public void ThenIShouldBeOnTheFoodIndexTab()
        {
            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.FoodDeterminantSmartLabel, 5);
            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.FoodIndexScoreLabel, 5);
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.ConditionText.Displayed(), "Condition Text is not present");
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.FoodDeterminantSmartLabel.Displayed(), "Food Determinant Smart Label is not present");
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.FoodIndexScoreLabel.Displayed(), "Food Index Score Label is not present");
        }

        [When("I select How Is This Generated button")]
        public void WhenISelectHowIsThisGeneratedButton()
        {
            if (!_FoodIndexFoodIndexSectionPage.HowIsThisGeneratedButton.Displayed())
                _FoodIndexFoodIndexSectionPage.ScrollDownTo(_FoodIndexFoodIndexSectionPage.HowIsThisGeneratedButton.Locator, ScrollStrategy.Gesture);

            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.HowIsThisGeneratedButton, 5);
            _FoodIndexFoodIndexSectionPage.HowIsThisGeneratedButton.Click();
        }

        [Then("I should be on the Food Index Calculation page")]
        public void ThenIShouldBeOnTheFoodIndexCalculationPage()
        {
            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.FoodIndexCalculationText, 5);
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.FoodIndexCalculationText.Displayed(), "Food Index Calculation page is not present");
            app.Back();
        }

        [When("I scroll to the All Conditions View")]
        public void WhenIScrollToTheAllConditionsView()
        {
            if (!_FoodIndexFoodIndexSectionPage.AllConditionsView.Displayed())
            _FoodIndexFoodIndexSectionPage.ScrollDownTo(_FoodIndexFoodIndexSectionPage.AllConditionsView.Locator, ScrollStrategy.Gesture);

            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.AllConditionsView, 5);
        }

        [When("I select the Condition Picker")]
        public void WhenISelectTheConditionPicker()
        {
            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.ConditionPicker, 5);
            _FoodIndexFoodIndexSectionPage.ConditionPicker.Click();
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.SelectCoditionHeader, 5);
                _FoodIndexFoodIndexSectionPage.SelectCoditionOk.Click();
            }
            else
            {
                _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.SelectCoditionDone, 5);
                _FoodIndexFoodIndexSectionPage.SelectCoditionDone.Click();
            }
        }

        [Then("I should be on the lower part of Food Index")]
        public void ThenIShouldBeOnTheLowerPartOfFoodIndex()
        {
            _FoodIndexFoodIndexSectionPage.WaitForElementPresent(_FoodIndexFoodIndexSectionPage.DailyValueCalorieSectionView, 3);
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.DailyValueCalorieSectionView.Displayed(), "Daily Value Calorie Section View is not present");
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.FoodConditionScoreSectionView.Displayed(), "Food Condition Score Section View is not present");
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.ConditionPicker.Displayed(), "Condition Picker is not present");
            Assert.IsTrue(_FoodIndexFoodIndexSectionPage.AllConditionsView.Displayed(), "All Conditions View is not present");
        }

        [When("I select the Nutrition tab")]
        public void WhenISelectTheNutritionTab()
        {
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.NutritionTabButon, 3);
            _FoodIndexFoodDetailsPage.NutritionTabButon.Click();
        }

        [Then("I should be on the food details Nutrition tab")]
        public void ThenIShouldBeOnTheFoodDetailsNutritionTab()
        {
            _FoodIndexNutritionSectionPage.WaitForElementPresent(_FoodIndexNutritionSectionPage.NutrientHighlightsSection, 5);
            _FoodIndexNutritionSectionPage.WaitForElementPresent(_FoodIndexNutritionSectionPage.CircularGraph, 5);
            Assert.IsTrue(_FoodIndexNutritionSectionPage.NutrientHighlightsSection.Displayed(), "Not on the Food Details Nutrition Tab");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.NutrientHighlightsHeader.Displayed(), "Nutrient Highlights Header is not present");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.CircularGraph.Displayed(), "Circular Graph is not present");
            if (!_FoodIndexNutritionSectionPage.FatCalorieLabel.Displayed())
            {
                _FoodIndexFoodDetailsPage.ScrollDownTo(_FoodIndexNutritionSectionPage.FatCalorieLabel.Locator, ScrollStrategy.Gesture);
            }
            _FoodIndexNutritionSectionPage.WaitForElementPresent(_FoodIndexNutritionSectionPage.FatCalorieLabel, 5);
            Assert.IsTrue(_FoodIndexNutritionSectionPage.FatCalorieSectionView.Displayed(), "Fat Calorie Section View is not present");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.FatCalorieLabel.Displayed(), "Fat Calorie Label is not displayed");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.CalorieBreakdownText.Displayed(), "Calories From Fat Text is not displayed");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.CalorieBreakdownHeader.Displayed(), "Calorie Breakdown Header is not displayed");
        }

        [When("I select Complete Label Information")]
        public void WhenISelectCompleteLabelInformation()
        {
            if (!_FoodIndexNutritionSectionPage.CompleteLabelInformationButton.Displayed())
            {
                _FoodIndexNutritionSectionPage.ScrollDownTo(_FoodIndexNutritionSectionPage.CompleteLabelInformationButton.Locator, ScrollStrategy.Gesture);
            }
            _FoodIndexNutritionSectionPage.WaitForElementPresent(_FoodIndexNutritionSectionPage.CompleteLabelInformationButton, 5);
            _FoodIndexNutritionSectionPage.CompleteLabelInformationButton.Click();
        }

        [Then("I should see the Complete Nutrition Facts")]
        public void ThenIShouldSeetheCompleteNutritionFacts()
        {
            if (!_FoodIndexNutritionSectionPage.NutritionFactsHeader.Displayed())
            {
                _FoodIndexNutritionSectionPage.ScrollUpTo(_FoodIndexNutritionSectionPage.NutritionFactsHeader.Locator, ScrollStrategy.Gesture);
            }
            _FoodIndexNutritionSectionPage.WaitForElementPresent(_FoodIndexNutritionSectionPage.CompleteNutrientsSectionView, 5);
            Assert.IsTrue(_FoodIndexNutritionSectionPage.CompleteNutrientsSectionView.Displayed(), "Complete Nutrition Facts Table is not present");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.NutritionFactsHeader.Displayed(), "Nutrition Facts header is not present");
            Assert.IsTrue(_FoodIndexNutritionSectionPage.NutritionFactsText.Displayed(), "Nutrition Facts text is not present");
        }

        [When("I select the Better For Me tab")]
        public void WhenISelectTheBetterForMeTab()
        {
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.BetterForMeTabButon, 5);
            _FoodIndexFoodDetailsPage.BetterForMeTabButon.Click();
        }

        [Then("I should be on the food details Better For Me tab")]
        public void ThenIShouldBeOnTheFoodDetailsBetterForMeTab()
        {
            _FoodIndexBetterForMeSection.WaitForElementPresent(_FoodIndexBetterForMeSection.BetterForMeFoodImage, 8);
            Assert.IsTrue(_FoodIndexBetterForMeSection.BetterForMeFoodImage.Displayed(), "Not on the better for me Tab");
            Assert.IsTrue(_FoodIndexBetterForMeSection.BetterForMeFoodImageText.Displayed(), "Better For Me Food Image Text is not present");
            Assert.IsTrue(_FoodIndexBetterForMeSection.BetterForMeFoodImageTextTwo.Displayed(), "Better For Me Food Image Text is not present");
        }

        [When("I select the Better For Me View More options")]
        public void WhenISelectTheBetterForMeViewMoreOptions()
        {
            if (!_FoodIndexBetterForMeSection.BetterForMeFoodViewMore.Displayed())
                _FoodIndexBetterForMeSection.ScrollDownTo(_FoodIndexBetterForMeSection.BetterForMeFoodViewMore.Locator, ScrollStrategy.Gesture);

            _FoodIndexBetterForMeSection.WaitForElementPresent(_FoodIndexBetterForMeSection.BetterForMeFoodViewMore, 5);
            _FoodIndexBetterForMeSection.BetterForMeFoodViewMore.Click();
            if (!_FoodIndexBetterForMeSection.BetterForMeFoodViewPrevious.Displayed())
                _FoodIndexBetterForMeSection.ScrollDownTo(_FoodIndexBetterForMeSection.BetterForMeFoodViewPrevious.Locator, ScrollStrategy.Gesture);

            _FoodIndexBetterForMeSection.WaitForElementPresent(_FoodIndexBetterForMeSection.BetterForMeFoodViewPrevious, 5);
            _FoodIndexBetterForMeSection.BetterForMeFoodViewPrevious.Click();
        }

        [When("I select the Better For Me Food item")]
        public void WhenISelectTheBetterForMeFoodItem()
        {
            _FoodIndexBetterForMeSection.WaitForElementPresent(_FoodIndexBetterForMeSection.BetterForMeFoodImageText, 5);
            _FoodIndexBetterForMeSection.BetterForMeFoodImageText.Click();
        }

        [Then("I should be on the Locked Feature Page")]
        public void ThenIShouldBeOnTheLockedFeaturePage()
        {
            _LockedFeaturePage.WaitForElementPresent(_LockedFeaturePage.LockedFeatureStackLayout, 5);
            Assert.IsTrue(_LockedFeaturePage.LockedFeatureStackLayout.Displayed(), "Locked Feature page is not present");
        }

        [When("I select the Locked Feature Create Account button")]
        public void WhenISelectTheLockedFeatureCreateAccountButton()
        {
            _LockedFeaturePage.WaitForElementPresent(_LockedFeaturePage.CreateAccountButton, 3);
            _LockedFeaturePage.CreateAccountButton.Click();
        }

        [Then("I should be on the Create Account Page from Food Index")]
        public void ThenIShouldBeOnTheCreateAccountPageFromFoodIndex()
        {
            Then("I should be on the Locked Feature Page");
            When("I select the Locked Feature Create Account button");
            Then("I should be on the create account page");
            When("I select the toobar item of Food Index");
        }

        [When("I select the Locked Feature Cancel button")]
        public void WhenISelectTheLockedFeatureCancelButton()
        {
            _LockedFeaturePage.WaitForElementPresent(_LockedFeaturePage.CancelButton, 3);
            _LockedFeaturePage.CancelButton.Click();
        }

        [When("I select the Favorite Star for a food item")]
        public void WhenISelectTheFavoriteStarForAFoodItem()
        {
            _FoodIndexFoodDetailsPage.WaitForElementPresent(_FoodIndexFoodDetailsPage.FavoriteStar, 5);
            _FoodIndexFoodDetailsPage.FavoriteStar.Click();
            if (_FoodIndexFoodDetailsPage.ItemRemovedText.Displayed())
                _FoodIndexFoodDetailsPage.FavoriteStar.Click();
            app.Back();
            if (AppInitializer.CurrentPlatform == Platform.iOS)
                app.Back();
        }
    }
}
