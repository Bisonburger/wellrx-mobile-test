using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class DashboardSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.DashboardPage _DashboardPage;
        readonly Pages.SavingscardPage _SavingsCardPage;

        public DashboardSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");
            _SavingsCardPage = FeatureContext.Current.Get<Pages.SavingscardPage>("SavingsCardPage");
        }

        [Given("I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Given("I am on the log in page");
            When("I log in as existing user");
            Then("I should be navigated to the home page");
        }

        [Given("I am on the home page with a Non Personalized Wellness account")]
        public void GivenIAmOnTheHomePageWithANonPersonalizedWellnessAccount()
        {
            Given("I am on the log in page");
            When("I log in as existing user with out Personalized Wellness");
            Then("I should be navigated to the home page");
        }

        [When("I select the toobar item of (Medicine Chest|Price Medicine|Food Index|More|Dashboard)")]
        public void WhenISelectTheToobarItemOf(string toolbarItem)
        {
            switch (toolbarItem.ToLower())
            {
                case "medicine chest":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.BottomMenuOptions.MedChest, 5);
                    _DashboardPage.BottomMenuOptions.MedChest.Click();
                    break;
                case "price medicine":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.BottomMenuOptions.PriceMeds, 5);
                    _DashboardPage.BottomMenuOptions.PriceMeds.Click();
                    break;
                case "food index":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.BottomMenuOptions.FoodIndex, 5);
                    _DashboardPage.BottomMenuOptions.FoodIndex.Click();
                    break;
                case "more":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.BottomMenuOptions.More, 5);
                    _DashboardPage.BottomMenuOptions.More.Click();
                    break;
                case "dashboard":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.BottomMenuOptions.Dashboard, 5);
                    _DashboardPage.BottomMenuOptions.Dashboard.Click();
                    break;

                default:
                    Assert.Fail(toolbarItem + ": Toolbar Item is not supported at the moment.");
                    break;
            }
        }

        [When("I swipe to the left on the Dashboard page to (Medicine Locked Card|Profile Card|Shopping List Card|Notification Card|Barcode Tutorial Card|New Feature Card|Locked Shipping List Card|Video Card)")]
        public void WhenISwipeToTheLeftOnTheDashboardPageTo(string carouselItem)
        {
            int tries = 0;
            int triesNumber = 10;
            switch (carouselItem.ToLower())
            {
                case "medicine locked card":
                    while (!_DashboardPage.NotificationLockedView.Displayed() && tries < triesNumber)
                    {
                        _DashboardPage.SwipeRightToLeft(_DashboardPage.Carousel.Locator);
                        tries++;
                    }
                    break;
                case "profile card":
                    while (!_DashboardPage.ManageProfileUnlock.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;
                case "shopping list card":
                    while (!_DashboardPage.ShoppingListCardView.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;
                case "notification card":
                   while (!_DashboardPage.ReminderNotificationCardView.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;
                case "barcode tutorial card":
                    while (!_DashboardPage.BarcodeTutorialCardView.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;
                case "new feature card":
                    while (!_DashboardPage.NewFeatureCardView.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;
                case "locked shipping list card":
                    while (!_DashboardPage.LockedShippingListCardViewView.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;

                case "video card":
                    while (!_DashboardPage.VideoCardView.Displayed() && tries < triesNumber)
                    {
                        DashBoardCarouselCardSwip();
                        tries++;
                    }
                    break;

                default:
                    Assert.Fail(carouselItem + ": Carousel Item is not supported at the moment.");
                    break;
            }
        }

        [When("I select the Dashboard card of (Medicine Locked Card|Profile Card|Savings Card|Shopping List Card|Notification Card|Share App Card|Price Meds Tutorial Card|Barcode Tutorial Card|Locked Shipping List Card|Video Card)")]
        public void WhenISelectTheDashboardCardOf(string carouselItem)
        {
            switch (carouselItem.ToLower())
            {
                case "medicine locked card":
                    When("I swipe to the left on the Dashboard page to Medicine Locked Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.NotificationLockedView, 3);
                    _DashboardPage.NotificationLockedView.Click();
                    break;
                case "profile card":
                    When("I swipe to the left on the Dashboard page to Profile Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.ManageProfileUnlock, 5);
                    _DashboardPage.ManageProfileUnlock.Click();
                    break;
                case "savings card":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.SavingsCard, 5);
                    _DashboardPage.SavingsCard.Click();
                    Then("I should be on the expanded Savigs Card view");
                    break;
                case "shopping list card":
                    When("I swipe to the left on the Dashboard page to Shopping List Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.ShoppingListCardView, 5);
                    _DashboardPage.ShoppingListCardView.Click();
                    break;
                case "notification card":
                    When("I swipe to the left on the Dashboard page to Notification Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.ReminderNotificationCardView, 5);
                    _DashboardPage.ReminderNotificationCardView.Click();
                    if (_DashboardPage.Ok.Displayed())
                    {
                        _DashboardPage.Ok.Click();
                    }
                    break;
                case "share app card":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.ShareAppCardView, 5);
                    _DashboardPage.ShareAppCardView.Click();
                    if (AppInitializer.CurrentPlatform == Platform.Android)
                    {
                        Thread.Sleep(2000);
                        app.Back();
                        _DashboardPage.WaitForElementPresent(_DashboardPage.MyWellRxTab, 5);
                        _DashboardPage.MyWellRxTab.Click();
                    }
                    break;
                case "price meds tutorial card":
                    _DashboardPage.WaitForElementPresent(_DashboardPage.PriceMedsTutorialCardView, 5);
                    _DashboardPage.PriceMedsTutorialCardView.Click();
                    break;
                case "barcode tutorial card":
                    When("I swipe to the left on the Dashboard page to Barcode Tutorial Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.BarcodeTutorialCardView, 5);
                    _DashboardPage.BarcodeTutorialCardView.Click();
                    break;
                case "locked shipping list card":
                    When("I swipe to the left on the Dashboard page to Locked Shipping List Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.LockedShippingListCardViewView, 5);
                    _DashboardPage.LockedShippingListCardViewView.Click();
                    break;
                case "video card":
                    When("I swipe to the left on the Dashboard page to Video Card");
                    _DashboardPage.WaitForElementPresent(_DashboardPage.VideoCardView, 5);
                    _DashboardPage.VideoCardView.Click();
                    break;

                default:
                    Assert.Fail(carouselItem + ": Carousel Item is not supported at the moment.");
                    break;
            }
        }

        [When("I am on the search page from the dashbard")]
        public void SearchPageFromTheDashbard()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.HomePagePriceMedsSearchBox, 5);
            _DashboardPage.HomePagePriceMedsSearchBox.Click();
        }

        [When("I select the My WellRx tab from the dashbard")]
        public void WhenISelectTheMyWellRxTabFromTheDashbard()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.MyWellRxTab, 5);
            _DashboardPage.MyWellRxTab.Click();
        }

        [When("I select the Recommended tab from the dashbard")]
        public void WhenISelectTheRecommendedTabFromTheDashbard()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.RecommendedTab, 5);
            _DashboardPage.RecommendedTab.Click();
        }

        [When("I select the Community tab from the dashbard")]
        public void WhenISelectTheCommunityTabFromTheDashbard()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.CommunityTab, 5);
            _DashboardPage.CommunityTab.Click();
        }

        [Then("I should be on the last page of Price Meds Tutorial pages")]
        public void ThenIShouldBeOnTheLastPageOfPriceMedsTutorialPages()
        {
            Assert.IsTrue(_DashboardPage.PriceMedsTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.PriceMedsTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.PriceMedsTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
        }

        [When("I select the Tutorial Skip For Now button")]
        public void WhenISelectThePriceMedsTutorialSkipForNowButton()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.PriceMedsTutorialSkipForNowButton, 5);
            _DashboardPage.PriceMedsTutorialSkipForNowButton.Click();
        }

        [When("I select the Tutorial Try It button")]
        public void WhenISelectThePriceMedsTutorialTryItButton()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.PriceMedsTutorialTryItButton, 5);
            _DashboardPage.PriceMedsTutorialTryItButton.Click();
        }

        [Then("I should be on the last page of Barcode Tutorial pages")]
        public void ThenIShouldBeOnTheLastPageOfBarcodeTutorialPages()
        {
            Assert.IsTrue(_DashboardPage.BarcodeTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.BarcodeTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.BarcodeTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.BarcodeTutorialPage.Displayed(), "not on the Price Meds Tutorial Page view");
        }

        [Then("I should be navigated to the New Feature Card")]
        public void ThenIShouldBeNavigatedToTheNewFeatureCard()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.NewFeatureCardView, 5);
            Assert.IsTrue(_DashboardPage.NewFeatureCardView.Displayed(), "not on notification locked view");
        }

        [Then("I should be on the last page of Watch Videos Tutorial pages")]
        public void ThenIShouldBeOnTheLastPageOfWatchVideosTutorialPages()
        {
            Assert.IsTrue(_DashboardPage.VideoTutorialPage.Displayed(), "not on the Video Tutorial Page view.");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.VideoTutorialPage.Displayed(), "not on the Video Tutorial Page view.");
            _DashboardPage.SwipeRightToLeft();
            Assert.IsTrue(_DashboardPage.VideoTutorialPage.Displayed(), "not on the Video Tutorial Page view.");
        }

        [Then("I should not see these Personalized Wellness cards on the Dashboard")]
        public void ThenIShouldNotSeeThesePersonalizedWellnessCardsOntheDashboard()
        {
            Assert.IsFalse(_DashboardPage.BarcodeTutorialCardView.Displayed(), "The Barcode Tutorial Card is present.");
            Assert.IsFalse(_DashboardPage.VideoCardView.Displayed(), "The Video Card is present.");
            DashBoardCarouselCardSwip();
            Assert.IsFalse(_DashboardPage.BarcodeTutorialCardView.Displayed(), "The Barcode Tutorial Card is present.");
            Assert.IsFalse(_DashboardPage.VideoCardView.Displayed(), "The Video Card is present.");
            DashBoardCarouselCardSwip();
            Assert.IsFalse(_DashboardPage.BarcodeTutorialCardView.Displayed(), "The Barcode Tutorial Card is present.");
            Assert.IsFalse(_DashboardPage.VideoCardView.Displayed(), "The Video Card is present.");
        }
        private void DashBoardCarouselCardSwip()
        {
            if (AppInitializer.CurrentPlatform == Platform.Android)
                _DashboardPage.SwipeRightToLeft(_DashboardPage.Carousel.Locator);
            else
                _DashboardPage.SwipeRightToLeft(_DashboardPage.Carousel.Locator, .4);
        }
    }
}