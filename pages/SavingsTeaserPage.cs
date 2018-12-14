using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class SavingsTeaserPage : BasePage
    {
        public Element DashoardSearchBar = new Element(By.Marked, "search_bar");
        public Element PageContainer = new Element(By.Marked, "SavingsTeaserPage");
        public Element DrugName = new Element(By.Marked, "DrugNameEntry");
        public Element KeyboardDone = new Element(By.Text, "Done");
        public Element ZipCode = new Element(By.Marked, "ZipCodeTeaserEntry");
        public Element SeeSavings = new Element(By.Marked, "SeeSavingsTeaserButton");
        public Element NoThanks = new Element(By.Marked, "DeclineSavingsTeaserButton");
        public Element Message = new Element(By.Label, "TeaserSeachError");
        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
    }
}
