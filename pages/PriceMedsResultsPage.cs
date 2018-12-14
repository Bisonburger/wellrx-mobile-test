using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class PriceMedsResultsPage : BasePage
    {
        public Element MedicineName = new Element(By.Marked, "DrugNameEntry");
        public Element ListView = new Element(By.Marked, "ListView");
        public Element MapView = new Element(By.Marked, "MapView");
        public Element FilterSort = new Element(By.Marked, "FilterSort");
        public Element FirstPharmacyResult = new Element(By.MarkedChild, "PharmacyListViewItem", 2);
        public Element GoogleMapImage = new Element(By.Marked, "PharmacyResultsMap");

        #region Filter Sort Section
        public Element ViewContainer = new Element(By.Marked, "PriceMedsSortAndFilterPage");
        public Element PriceMedsSortAndFilterMessage = new Element(By.Marked, "PriceMedsSortAndFilterMessage");
        public Element DrugType = new Element(By.Marked, "DrugTypeRow");
        public Element DoseForm = new Element(By.Marked, "DoseFormRow");
        public Element DoseStrength = new Element(By.Marked, "DoseStrengthRow");
        public Element Quantity = new Element(By.Marked, "QuantityRow");
        public Element Sort = new Element(By.Marked, "SortRow");
        public Element ApplyButton = new Element(By.Marked, "ApplyButton");
        public Element PlavixSelection = new Element(By.Text, "PLAVIX");
        public Element TabletSelection = new Element(By.Text, "Tablet");
        public Element Selection300Mg = new Element(By.Text, "300 MG");
        public Element Selection15Quanity = new Element(By.Text, "15");
        public Element SortPharmacySelection = new Element(By.Text, "Pharmacy A-Z");
        #endregion

        #region List View
        public Element PriceMedsResultPage = new Element(By.Marked, "PriceMedsResultPage");
        public Element ResultsList = new Element(By.Marked, "ResultsList");
        public Element ResultsGroupedList = new Element(By.Marked, "ResultsGroupedList");
        public Element LocationEntry = new Element(By.Marked, "LocationEntry");
        public Element SavedSearchButton = new Element(By.Text, "Save Search");
        public Element PriceMedsResultMessage = new Element(By.Marked, "PriceMedsResultMessage");
        public Element PharmacyDetailsCardView = new Element(By.Marked, "PharmacyDetailsCardView");
        public Element ShowAllOrPreferredPharmaciesButton = new Element(By.Marked, "ShowAllOrPreferredPharmaciesButton");
        public Element ResultsListItem = new Element(By.MarkedDescendant, "ResultsList", 11, 11);
        public Element ResultsListGroupedItem = new Element(By.MarkedDescendant, "ResultsGroupedList", 11, 11);
        #endregion
    }
}
