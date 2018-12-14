using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class LearnAboutPricing : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "AboutOurPricingPage");
        public Element Title = new Element(By.Marked, "PageHeading");
        public Element TermsConditions = new Element(By.Marked, "TermsAndConditionsButton");
        public Element ViewPrivacyPolicy = new Element(By.Marked, "PolicyButton");

        #region bottom menu options
        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
        #endregion
    }
}
