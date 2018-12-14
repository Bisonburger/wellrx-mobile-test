using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class AskPharmacistPage : BasePage
    {
        public Element Header = new Element(By.Text, "Ask a Pharmacist");
        public Element ViewTermConditions = new Element(By.Marked, "ViewTermsAndConditions");
        public Element MakeCall = new Element(By.Marked, "MakeCallFrame");

        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
    }
}
