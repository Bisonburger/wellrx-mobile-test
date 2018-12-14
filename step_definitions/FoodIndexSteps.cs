using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class FoodIndexSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.FoodIndexPage _FoodIndexPage;
        readonly Pages.FoodIndexSearchPage _FoodIndexSearchPage;
        readonly Pages.FoodIndexFoodDetailsPage _FoodIndexFoodDetailsPage;
        readonly Pages.OnBoardingPage _OnBoardingPage;

        public FoodIndexSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _FoodIndexPage = FeatureContext.Current.Get<Pages.FoodIndexPage>("FoodIndexPage");
            _FoodIndexSearchPage = FeatureContext.Current.Get<Pages.FoodIndexSearchPage>("FoodIndexSearchPage");
            _FoodIndexFoodDetailsPage = FeatureContext.Current.Get<Pages.FoodIndexFoodDetailsPage>("FoodIndexFoodDetailsPage");
            _OnBoardingPage = FeatureContext.Current.Get<Pages.OnBoardingPage>("OnBoardingPage");
        }

        [Then("I should be on the food index page")]
        public void ThenIShouldBeOnTheFoodIndexPage()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.Header, 3);
            Assert.IsTrue(_FoodIndexPage.Header.Displayed(), "Not on the Food index page.");
            Assert.IsTrue(_FoodIndexPage.MoreDetailsButton.Displayed(), "More Details Button is not displayed.");
            Assert.IsTrue(_FoodIndexPage.SearchProductButton.Displayed(), "Search Product Button is not displayed.");
            Assert.IsTrue(_FoodIndexPage.ScanProductButton.Displayed(), "Scan Product Button is not displayed.");
        }

        [When("I select the More Details from Food Index")]
        public void WhenISelectTheMoreDetailsFromFoodIndex()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.MoreDetailsButton, 3);
            _FoodIndexPage.MoreDetailsButton.Click();
        }

        [Then("I should be on the More Details prompt")]
        public void ThenIShouldBeOnTheMoreDetailsPrompt()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.MoreDetailsPromptHeader, 3);
            Assert.IsTrue(_FoodIndexPage.MoreDetailsPromptHeader.Displayed(), "The More Details Header is not displayed.");
            _FoodIndexPage.MoreDetailsPromptOkButton.Click();
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.Header, 5);
            Assert.IsTrue(_FoodIndexPage.Header.Displayed(), "Not on the Food index page.");
        }

        [When("I select the Scan Product from Food Index")]
        public void WhenISelectTheScanProductFromFoodIndex()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.ScanProductButton, 3);
            _FoodIndexPage.ScanProductButton.Click();
        }

        [Then("I should be on the Scan Product page")]
        public void ThenIShouldBeOnTheScanProductPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.BarcodeScanningPage, 3);
            Assert.IsTrue(_OnBoardingPage.BarcodeScanningPage.Displayed(), "The barcode scanning page is not displayed.");
            Assert.IsTrue(_OnBoardingPage.SearchProductButton.Displayed(), "The Search Product button is not displayed.");
            Assert.IsTrue(_OnBoardingPage.ScanStatusMessageLabel.Displayed(), "The scanner page text is not displayed.");
        }

        [When("I select Search Product button")]
        public void WhenISelectSearchProductButton()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.SearchProductButton, 3);
            _OnBoardingPage.SearchProductButton.Click();
        }

        [When("I select the Search Product from Food Index")]
        public void WhenISelectTheSearchProductFromFoodIndex()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.SearchProductButton, 3);
            _FoodIndexPage.SearchProductButton.Click();
        }

        [Then("I should be on the Search Product page")]
        public void ThenIShouldBeOnTheSearchProductPage()
        {
            _FoodIndexSearchPage.WaitForElementPresent(_FoodIndexSearchPage.SearchPageHeader, 3);
            Assert.IsTrue(_FoodIndexSearchPage.SearchPageHeader.Displayed(), "The search product page is not displayed.");
            Assert.IsTrue(_FoodIndexSearchPage.SearchTextBox.Displayed(), "The Search Product button is not displayed.");
            Assert.IsTrue(_FoodIndexSearchPage.ScanBarcodeButton.Displayed(), "The scanner page text is not displayed.");
        }

        [When("I select Scan Barcode from Food Index")]
        public void WhenISelectScanBarCodeFromFoodIndex()
        {
            _FoodIndexSearchPage.WaitForElementPresent(_FoodIndexSearchPage.ScanBarcodeButton, 3);
            _FoodIndexSearchPage.ScanBarcodeButton.Click();
        }

        // When calling this "When" statement replace "(.*)" with the item that you want to enter for the test 
        [When("I search for a food item with (.*)")]
        public void WhenISearchForAFoodItemWithFooditem(string Fooditem)
        {
            _FoodIndexSearchPage.WaitForElementPresent(_FoodIndexSearchPage.SearchTextBox, 3);
            _FoodIndexSearchPage.SearchTextBox.EnterText(Fooditem);
            _FoodIndexSearchPage.WaitForElementPresent(_FoodIndexSearchPage.SearchResultsList, 3);
            _FoodIndexSearchPage.SearchResultsItem.Click();
        }

        [When("I select Favorites Products in Food Index")]
        public void WhenISelectFavoritesProductsInFoodIndex()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.FavoritesProductsButton, 3);
            _FoodIndexPage.FavoritesProductsButton.Click();
        }

        [Then("I should be on the Food Index Favorites page")]
        public void ThenIShouldBeOnTheFoodIndexFavoritesPage()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.FavoritesListItemsPage, 3);
            Assert.IsTrue(_FoodIndexPage.FavoritesListItemsPage.Displayed(), "Not on the Favorites List Items Page.");
            Assert.IsTrue(_FoodIndexPage.FavoritesPageHeading.Displayed(), "Missing Favorites Page Heading.");
            Assert.IsTrue(_FoodIndexPage.FavoriteList.Displayed(), "Missing Favorite List.");
            Assert.IsTrue(_FoodIndexPage.ListImage.Displayed(), "Missing List Image.");
            Assert.IsTrue(_FoodIndexPage.ListNumber.Displayed(), "Missing List Image.");
        }

        [When("I select Sort in Favorites for Food Index")]
        public void WhenISelectSortInFavoritesForFoodIndex()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.SortLabel, 3);
            _FoodIndexPage.SortLabel.Click();
            _FoodIndexPage.SortIndexHighToLow.Click();
        }

        [Given("I select a Food Item in Favorites")]
        public void GivenISelectSortInFavoritesForFoodIndex()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.ListItemName, 3);
            _FoodIndexPage.ListItemName.Click();
            Then("I should be on the food details summary tab");
            app.Back();
        }

        [When("I swipe to remove food item in Favorites")]
        public void WhenISwipeToRemoveFoodItemInFavorites()
        {
            int tries = 0;
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.ListItemName, 3);
            while (!_FoodIndexPage.FavoritesListEmptyMessage.Displayed())
            {
                _FoodIndexPage.SwipeRightToLeft(_FoodIndexPage.ListItemName.Locator);
                _FoodIndexPage.ListDelete.Click();
                tries++;
                if (tries == 5)
                    break;
            }
        }

        [Then("I should see Favorites list is empty message")]
        public void ThenIShouldSeeFavoritesListIsEmptyMessage()
        {
            _FoodIndexPage.WaitForElementPresent(_FoodIndexPage.FavoritesListEmptyMessage, 3);
            Assert.IsTrue(_FoodIndexPage.FavoritesListEmptyMessage.Displayed(), "Missing Favorites Page Heading.");
        }
    }
}
