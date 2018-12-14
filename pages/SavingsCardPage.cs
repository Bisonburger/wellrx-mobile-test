using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class SavingscardPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "SavingsCardPage");
        public Element SaveToDashboard = new Element(By.Marked, "GoToDashboardButton");

        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
    }
}
