using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class TeaserSearchResultsPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "SavingsTeaserResultPage");
        public Element Title = new Element(By.Marked, "PageHeading");
        public Element Email = new Element(By.Marked, "MedicationTeaserEntry");
        public Element YesCreateAccount = new Element(By.Marked, "AgreeReceiveSavingsButton");
        public Element NoThanks = new Element(By.Marked, "DeclineSavingsTeaserButton");
        public Element AccountRequiredHeader = new Element(By.Text, "Account Required");
        public Element AccountRequiredCancel = new Element(By.Text, "Cancel");
        public Element AccountRequiredCreateAccount = new Element(By.Text, "Create Account");

        public Element EmailValidationMsg = new Element(By.Marked, "ValidationMessageLabel");

        #region bottom menu options
        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
        #endregion
    }
}
