using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class PriceMedsSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.PriceMedicinePage _PriceMedicinePage;
        readonly Pages.PharmacyDrugInfoPage _PharmacyDrugInfoPage;
        readonly Pages.PriceMedsResultsPage _PriceMedsResultsPage;
        readonly Pages.LearnAboutPricing _LearnAboutPricingPage;
        readonly Pages.MedicineChestPage _MedicineChestPage;

        public PriceMedsSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //TODO Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _PriceMedicinePage = FeatureContext.Current.Get<Pages.PriceMedicinePage>("PriceMedicinePage");
            _PharmacyDrugInfoPage = FeatureContext.Current.Get<Pages.PharmacyDrugInfoPage>("PharmacyDrugInfoPage");
            _PriceMedsResultsPage = FeatureContext.Current.Get<Pages.PriceMedsResultsPage>("PriceMedsResultsPage");
            _LearnAboutPricingPage = FeatureContext.Current.Get<Pages.LearnAboutPricing>("LearnAboutPricingPage");
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
        }

        [Given("I am on Price Meds page")]
        public void GivenIAmOnPriceMedsPage()
        {
            Given("I am on the log in page");
            When("I log in as existing user");
            Then("I should be navigated to the home page");
            When("I select the toobar item of Price Medicine");
        }

        [When("I select Learn About Our Pricing link")]
        public void WhenISelectLearnAboutOurPricingLink()
        {
            if (!_PriceMedicinePage.LearnAboutPricing.Displayed())
            {
                _PriceMedicinePage.ScrollDownTo(_PriceMedicinePage.LearnAboutPricing.Locator, ScrollStrategy.Gesture);
            }
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.LearnAboutPricing, 5);
            _PriceMedicinePage.LearnAboutPricing.Click();
        }

        [When("I enter (.*) in the mediciation field")]
        public void WhenIEnterInTheMedicationField(string drugName)
        {
            _PriceMedicinePage.DrugName.EnterText(drugName, true);
        }

        [Then("I should see a list of matching mediciations that starts with (.*)")]
        public void ThenIShouldSeeAListOfMatchingMediciationsThatStartsWith(string drugName)
        {
            var drugs = app.Query(x => x.Class("FormsTextView"));
            foreach (Xamarin.UITest.Queries.AppResult drug in drugs)
            {
                drug.Text.ToLower().Contains(drugName);
            }
            app.Back();
        }

        [Then("the search button should be disabled")]
        public void ThenTheSearchButtonShouldBeDisabled()
        {
            Assert.IsFalse(_PriceMedicinePage.Search.Enabled(), "seach button should be disabled");
        }

        [When("I search (.*) with (.*) zip code via autocomplete from the Price Meds page")]
        public void WhenISearchDrugWithZipcodeViaAutocompleteFromThePriceMedsPage(string drugName, string zipCode)
        {
            _PriceMedicinePage.DrugName.EnterText(drugName, true);
            app.WaitForElement(c => c.Text(drugName.ToUpper()), "missing auto complete options", TimeSpan.FromSeconds(3));
            app.Tap(c => c.Text(drugName.ToUpper()));
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.ZipCode, 5);
            _PriceMedicinePage.ZipCode.EnterText(zipCode, true);
            if ("Using current location" == _PriceMedicinePage.ZipCode.GetText())
                _PriceMedicinePage.ZipCode.EnterText(zipCode, true);
            _PriceMedicinePage.Search.Click();
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.MapView, 5);
        }
         
        [When("I select the mediciation name field")]
        public void WhenISelectTheMedicationNameField()
        {
            if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                //this is needed to invoke the "recent search" list for ios
                _PriceMedicinePage.DrugName.ClearText();
                _PriceMedicinePage.DrugName.EnterText("o");
            }
            _PriceMedicinePage.DrugName.ClearText();
            _PriceMedicinePage.DrugName.Click();
        }

        [Then("I should see recent search section with following mediciations")]
        public void ThenIShouldSeeRecentSearchSectionWithFollowingMedications()
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.RecentSearch, 5);
            Assert.IsTrue(_PriceMedicinePage.RecentSearch.Displayed(), "missing recent search section.");
            Assert.IsTrue(_PriceMedicinePage.RecentSearch1.Displayed(), "The recent search AMBIEN did not display");
            Assert.IsTrue(_PriceMedicinePage.RecentSearch2.Displayed(), "The recent search PLAVIX did not display");
        }

        [When("I choose (.*) from recent search section")]
        public void WhenIChooseDrugFromRecentSearchSection(string drugName)
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.RecentSearch2, 3); 
            _PriceMedicinePage.RecentSearch2.Click();
        }

        [Then("I should see (.*) in the medication name field on Price Meds page")] 
        public void ThenIShouldSeeDrugnameInTheMedicationNameFieldonPriceMedsPage(string drugName)
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.DrugName, 5);
            Assert.AreEqual(drugName, _PriceMedicinePage.DrugName.GetText());
        }

        [Then("I should see a list of pharmacies")]
        public void ThenIShouldSeeAListOfPharamcies()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.PriceMedsResultPage, 6);
            Assert.IsTrue(_PriceMedsResultsPage.PriceMedsResultPage.Displayed(), "not on Repricing Result Page.");
            if (_PriceMedsResultsPage.ResultsList.Displayed())
            {
                Assert.IsTrue(_PriceMedsResultsPage.ResultsList.Displayed(), "Missing Results List.");
                Assert.IsTrue(_PriceMedsResultsPage.ResultsListItem.Displayed(), "Missing Results List Item.");
            }
            else
            {
                Assert.IsTrue(_PriceMedsResultsPage.ResultsGroupedList.Displayed(), "Missing Results List.");
                Assert.IsTrue(_PriceMedsResultsPage.ResultsListGroupedItem.Displayed(), "Missing Results List Item.");
            }
        }

        [Then("I should be navigated to the search results page")]
        public void ThenIShouldBeNavigatedToTheSearchResultsPage()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.MapView, 10);
            Assert.IsTrue(_PriceMedsResultsPage.MapView.Displayed(), "not on price meds results page.");
        }

        [Then("I should see pricing disclaimer message reads as")]
        public void ThenIShouldSeeMarketingMessageReadsAs(string multiLines)
        {
            Assert.AreEqual(multiLines, _PriceMedicinePage.PricingDisclaimer.GetText());
        }

        [When("I switch to the Map View")]
        public void WhenISwitchToTheMapView()
        {
            _PriceMedsResultsPage.MapView.Click();
        }

        [Then("I should be navigated to the search results map view")]
        public void ThenIShouldBeNavigatedToTheSearchREsultsMapView()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.ListView, 3);
            Assert.IsTrue(_PriceMedsResultsPage.GoogleMapImage.Displayed(), "not on map view");
        }

        [Then("I should be able to switch back to the list view")]
        public void ThenIShouldBeAbleToSwitchBackToTheListView()
        {
            _PriceMedsResultsPage.ListView.Click();
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.ResultsList, 3);
            Assert.IsTrue(_PriceMedsResultsPage.ResultsList.Displayed(), "not on the list view");
        }

        [When("I select the any pharmacy in the results list")]
        public void WhenISelectTheFirstOneInTheResultsList()
        {
            var listCount = app.Query(c => c.Marked("ResultsList").Class("ConditionalFocusLayout")).Length;
            var randomNumber = new Random();
            var pharmacyIndex = randomNumber.Next(0, listCount);
            Console.WriteLine("pharmacy index: " + pharmacyIndex);
            _PriceMedsResultsPage.ResultsListItem.Click();
        }

        [When("I select Filter & Sort icon")] 
        public void WhenISelectFilterSortIcon()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.FilterSort, 5);
            _PriceMedsResultsPage.FilterSort.Click();
        }

        [Then("I should see following options")]
        public void ThenIShouldSeeFollowingOptions(Table table)
        {
            var options = table.Rows.Select(row => row["Option"]).ToList();
            foreach (var option in options)
            {
                switch (option.ToLower())
                {
                    case "drug type":
                        Assert.IsTrue(_PriceMedsResultsPage.DrugType.Displayed(), "missing drug type");
                        break;
                    case "dose form":
                        Assert.IsTrue(_PriceMedsResultsPage.DoseForm.Displayed(), "missing dose form");
                        break;
                    case "dose strength":
                        Assert.IsTrue(_PriceMedsResultsPage.DoseStrength.Displayed(), "missing dose strength");
                        break;
                    case "quantity":
                        Assert.IsTrue(_PriceMedsResultsPage.Quantity.Displayed(), "missing quantity");
                        break;
                    case "sort":
                        Assert.IsTrue(_PriceMedsResultsPage.Sort.Displayed(), "missing sort");
                        break;
                    default:
                        Assert.Fail(option + " is not supported at the moment");
                        break;
                }
            }
        }

        [When("I change all Filter & Sort options in Price Meds")]
        public void WhenIChangeAllFilterAndSortOptionsInPriceMeds()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.DrugType, 3);
            _PriceMedsResultsPage.DrugType.Click();
            _PriceMedsResultsPage.PlavixSelection.Click();
            _PriceMedsResultsPage.DoseForm.Click();
            _PriceMedsResultsPage.TabletSelection.Click();
            _PriceMedsResultsPage.DoseStrength.Click();
            _PriceMedsResultsPage.Selection300Mg.Click();
            _PriceMedsResultsPage.Quantity.Click();
            _PriceMedsResultsPage.Selection15Quanity.Click();
            //This has been temporarily removed
            //_PriceMedsResultsPage.Sort.Click();
            //_PriceMedsResultsPage.SortPharmacySelection.Click();
            _PriceMedsResultsPage.ApplyButton.Click();
        }

        [Then("I should be navigated to the Filter & Sort view")]
        public void ThenIShouldBeNavigatedToTheFilterSortView()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.ViewContainer, 3);
            Assert.IsTrue(_PriceMedsResultsPage.DrugType.Displayed(), "Not on the filter & sort view.");
        }

        [Then("I should be navigated to the About Our Pricing page")]
        public void ThenIShouldBeNavigatedToTheAcountOurPricingPage()
        {
            _LearnAboutPricingPage.WaitForElementPresent(_LearnAboutPricingPage.Title, 3);
            Assert.IsTrue(_LearnAboutPricingPage.PageContainer.Displayed(), "not on the Learn About Pricing Page.");
        }

        [When("I select View Search History in Price Meds")]
        public void WhenISelectViewSearchHistoryInPriceMeds()
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.SearchHistory, 3);
            _PriceMedicinePage.SearchHistory.Click();
        }

        [Then("I should be navigated to the Search History in Price Meds")]
        public void ThenIShouldBeNavigatedToTheSearchHistoryInPriceMeds()
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.DrugSearchHistoryPage, 3);
            Assert.IsTrue(_PriceMedicinePage.DrugSearchHistoryPage.Displayed(), "Not on the Drug Search History Page.");
            if (_MedicineChestPage.SwipeLeftPopupPage.Displayed())
                _PriceMedicinePage.SearchHistoryHeading.Click();
            Assert.IsTrue(_PriceMedicinePage.SearchHistoryHeading.Displayed(), "Missing Search History Heading.");
            Assert.IsTrue(_PriceMedicinePage.SearchHistoryList.Displayed(), "Missing Search History List.");
            Assert.IsTrue(_PriceMedicinePage.ListDrugName.Displayed(), "Missing List Drug Name.");
        }

        [When("I swipe to Delete medication in View Search History")]
        public void WhenISwipeToDeleteMedicationInViewSearchHistory()
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.ListDrugName, 3);
            _PriceMedicinePage.SwipeRightToLeft(_PriceMedicinePage.ListDrugName.Locator);
            _PriceMedicinePage.ListDeleteButton.Click();
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.YesButtoin, 3);
            _PriceMedicinePage.YesButtoin.Click();
        }

        [Then("I should see View Search History message reads as")]
        public void ThenIShouldSeeViewSearcHistoryMessageReadsAs(string multiLines)
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.DrugSearchHistoryMessage, 3);
            Assert.AreEqual(multiLines, _PriceMedicinePage.DrugSearchHistoryMessage.GetText());
        }

        [Given("I Delete all Search History in View Search History")]
        public void GivenIDeleteAllSearchHistoryInViewSearchHistory()
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.DeleteAllButton, 3);
            _PriceMedicinePage.DeleteAllButton.Click();
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.YesButtoin, 3);
            _PriceMedicinePage.YesButtoin.Click();
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.EmptySearchHistoryMessage, 3);
            Assert.IsTrue(_PriceMedicinePage.EmptySearchHistoryMessage.Displayed(), "Missing EmptySearch History Message.");
            app.Back();
        }

        [Then("I should see Price Meds Result message reads as")]
        public void ThenIShouldSeePriceMedsResultMessageReadsAs(string multiLines)
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedsResultsPage.PriceMedsResultMessage, 3);
            Assert.AreEqual(multiLines, _PriceMedsResultsPage.PriceMedsResultMessage.GetText());
        }

        [When("I select Save Search on Price Meds Result")]
        public void WhenISelectSaveSearchOnPriceMedsResult()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.SavedSearchButton, 3);
            _PriceMedsResultsPage.SavedSearchButton.Click();
        }
    }
}