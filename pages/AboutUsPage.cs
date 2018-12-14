using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class AboutUsPage : BasePage
    {
        public Element Header = new Element(By.Text, "About Us");
        public Element AboutUsSection = new Element(By.Label, "AboutUsPage");
        public Element TermsAndConditionsButton = new Element(By.Label, "TermsAndConditionsButton");
        public Element PolicyButton = new Element(By.Label, "PolicyButton");
        public Element LearnMoreAboutMSCLinkButton = new Element(By.Label, "LearnMoreAboutMSCLinkButton");
        public Element TermsAndConditionsPage = new Element(By.Label, "TermsAndConditionsPage");
        public Element TermsAndConditionsHeader = new Element(By.Label, "PageHeading");
        public Element PrivacyPolicyPage = new Element(By.Label, "PrivacyPolicyPage");
        public Element PrivacyPolicyHeader = new Element(By.Label, "PageHeading");

        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
    }
}
