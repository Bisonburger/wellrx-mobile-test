using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class LockedFeaturePage : BasePage
    {
        public Element LockedFeatureStackLayout = new Element(By.Marked, "LockedFeatureStackLayout");
        public Element CreateAccountButton = new Element(By.Marked, "CreateAccountButton");
        public Element CancelButton = new Element(By.Label, "CancelButton");
    }
}
