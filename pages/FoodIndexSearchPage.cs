using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexSearchPage : BasePage
    {
        //Search Page
        public Element BarcodeScanningPage = new Element(By.Marked, "BarcodeScanningPage");
        public Element SearchPageHeader = new Element(By.Marked, "PageHeading");
        public Element SearchTextBox = new Element(By.Marked, "SearchEntry");
        public Element ScanBarcodeButton = new Element(By.DeviceClass, "android.support.v7.widget.ActionMenuView", 1, 2, "_UIButtonBarButton");

        //Search Results Page
        public Element SearchResultsPage = new Element(By.Marked, "ProductSearchAutoCompletePage");
        public Element SearchResultsList = new Element(By.Marked, "AutoCompleteListView");
        public Element SearchResultsItem = new Element(By.MarkedChild, "AutoCompleteListView", 1, 1);
    }
}
