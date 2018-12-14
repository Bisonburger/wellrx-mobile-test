using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class DashboardPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "HomePage");
        public Element SavingCardIdLabel = new Element(By.Text, "ID#");
        public Element DashboardMedSearch = new Element(By.Label, "Find Best Price on Meds");
        public Element HomePagePriceMedsSearchBox = new Element(By.Marked, "HomePagePriceMedsSearchBox");
        public Element ScriptSaveLogo = new Element(By.Marked, "ScriptSaveLogo");
        public Element CarouselPositionIndicator = new Element(By.Marked, "CarouselPositionIndicator");
        public Element CarouselFilter = new Element(By.Marked, "CarouselFilter");
        public Element MyWellRxTab = new Element(By.Marked, "MyWellRxTab");
        public Element RecommendedTab = new Element(By.Marked, "RecommendedTab");
        public Element CommunityTab = new Element(By.Marked, "CommunityTab");
        public Element Carousel = new Element(By.Marked, "Carousel");

        #region ManageProfile Carousel Cards
        public Element NotificationLockedView = new Element(By.Marked, "MedicineNotificationCardView");
        public Element LockedShippingListCardViewView = new Element(By.Marked, "LockedShippingListCardViewView");
        public Element NotificationUnlock = new Element(By.Marked, "Unlock_Container");
        public Element BellIcon = new Element(By.Marked, "BellIcon");
        public Element SavingsCard = new Element(By.Marked, "SavingsCard");
        public Element SavingsCardLogo = new Element(By.Marked, "SavingsCardLogo");
        public Element CardHolderName = new Element(By.Marked, "CardHolderName");
        public Element CardHolderID = new Element(By.Marked, "CardHolderID");
        public Element CardHolderGroup = new Element(By.Marked, "CardHolderGroup");
        public Element SavingsCardDisclaimerHeader = new Element(By.Marked, "SavingsCardDisclaimerHeader");
        public Element ManageProfileLockedView = new Element(By.Marked, "ManageProfileLockedView");
        public Element ManageProfileUnlock = new Element(By.Marked, "ManageProfileCardView");
        public Element ShoppingListCardView = new Element(By.Marked, "ShoppingListCardView");
        public Element ReminderNotificationCardView = new Element(By.Marked, "ReminderNotificationCardView");
        public Element ShareAppCardView = new Element(By.Marked, "ShareAppCardView");
        public Element NewFeatureCardView = new Element(By.Marked, "NewFeatureCardView");
        public Element PriceMedsTutorialCardView = new Element(By.Marked, "PriceMedsTutorialCardView");
        public Element BarcodeTutorialCardView = new Element(By.Marked, "BarcodeTutorialCardView");
        public Element VideoCardView = new Element(By.Marked, "VideoCardView");
        #endregion

        #region Tutorial Pages
        public Element PriceMedsTutorialPage = new Element(By.Marked, "PriceMedsTutorialPage");
        public Element PriceMedsTutorialTryItButton = new Element(By.Marked, "TryItButton");
        public Element PriceMedsTutorialSkipForNowButton = new Element(By.Marked, "SkipForNowButton");
        public Element BarcodeTutorialPage = new Element(By.Marked, "BarcodeTutorialPage");
        public Element VideoTutorialPage = new Element(By.Marked, "VideoTutorialPage");
        #endregion

        public Element Ok = new Element(By.Text, "OK");
        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
    }
}
