using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class PriceMedicinePage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "MedChestPage");
        public Element Title = new Element(By.Marked, "PageHeading");
        public Element PriceMedication = new Element(By.Marked, "PriceMedicationLinkButton");
        public Element SearchPharmacies = new Element(By.Marked, "SearchPharmaciesLinkButton");

        #region drug search
        public Element DrugName = new Element(By.Marked, "DrugNameEntry");
        public Element ZipCode = new Element(By.Marked, "SearchMedicationLocationEntry");
        #endregion

        #region drug name autocomplete
        public Element RecentSearch = new Element(By.Marked, "DrugSearchListView");
        public Element RecentSearch1 = new Element(By.MarkedChild, "DrugSearchListView", 2, 1);
        public Element RecentSearch2 = new Element(By.MarkedChild, "DrugSearchListView", 3, 2);
        public Element RecentSearchDrugName = new Element(By.Marked, "DrugName");
        #endregion

        #region Drug Search History Page
        public Element DrugSearchHistoryPage = new Element(By.Marked, "DrugSearchHistoryPage");
        public Element DrugSearchHistoryMessage = new Element(By.Marked, "DrugSearchHistoryMessage");
        public Element SearchHistoryHeading = new Element(By.Marked, "SearchHistoryHeading");
        public Element DeleteAllButton = new Element(By.Marked, "DeleteAllButton");
        public Element SearchHistoryList = new Element(By.Marked, "SearchHistoryList");
        public Element ListDrugName = new Element(By.Marked, "ListDrugName");
        public Element FilterDisplayText = new Element(By.Marked, "FilterDisplayText");
        public Element LocationText = new Element(By.Marked, "LocationText");
        public Element ListDeleteButton = new Element(By.Marked, "ListDeleteButton");
        public Element EmptySearchHistoryMessage = new Element(By.Marked, "EmptySearchHistoryMessage");
        public Element YesButtoin = new Element(By.Text, "Yes");
        #endregion

        public Element PricingDisclaimer = new Element(By.Marked, "PricingDisclaimerLabel");
        public Element Search = new Element(By.Marked, "SearchPriceMedsButton");
        public Element SearchHistory = new Element(By.Marked, "ViewSearchHistoryButton");
        public Element LearnAboutPricing = new Element(By.Marked, "LearnAboutOurPricingLinkButton");
        public Element LearnAboutPricingPageContainer = new Element(By.Marked, "AboutOurPricingPage");
    }
}
