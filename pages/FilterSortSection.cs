using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FilterSortSection
    {
        public Element ViewContainer = new Element(By.Marked, "PriceMedsSortAndFilterPage");
        public Element DrugType = new Element(By.Marked, "Drug Type");
        public Element DoseForm = new Element(By.Marked, "Dose Form");
        public Element DoseStrength = new Element(By.Marked, "Dose Strength");
        public Element Quantity = new Element(By.Marked, "Quantity");
        public Element Sort = new Element(By.Marked, "Sort");
    }
}
