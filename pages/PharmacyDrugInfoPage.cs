using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class PharmacyDrugInfoPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "DrugPharmacyPage");
        public Element AddToChest = new Element(By.Marked, "AddMedicationButton");
        public Element DrugInfoEnglish = new Element(By.Marked, "EnglishButton");
        public Element DrugInfoSpanish = new Element(By.Marked, "SpanishButton");
        public Element PharmacyDetailsContentView = new Element(By.Marked, "PharmacyDetailsContentView");
        public Element PharmacyDetailsMessage = new Element(By.Marked, "PharmacyDetailsMessage");
        public Element PassiveHeaderViewForVideoMessages = new Element(By.Marked, "PassiveHeaderViewForVideoMessages");
        public Element GoToLoginPageTap = new Element(By.Marked, "GoToLoginPageTap");
        public Element PharmacyNameLabel = new Element(By.Marked, "PharmacyNameLabel");
        public Element TodaysHoursButton = new Element(By.Marked, "TodaysHoursButton");
        public Element PharmacyAddressLabel = new Element(By.Marked, "PharmacyAddressLabel");
        public Element PharmacyImage = new Element(By.Marked, "PharmacyImage");
        public Element SetPreferredButton = new Element(By.Marked, "SetPreferredButton");
        public Element PreferredLabel = new Element(By.Marked, "PreferredLabel");
        public Element SetPreferredLabel = new Element(By.Marked, "SetPreferredLabel");
        public Element MakeCallButton = new Element(By.Marked, "MakeCallButton");
        public Element GetDirectionsButton = new Element(By.Marked, "GetDirectionsButton");
        public Element SavingsCardLink = new Element(By.Marked, "SavingsCardLink");
        public Element OkButton = new Element(By.Text, "OK");
        public Element DrugNameLabel = new Element(By.Marked, "DrugNameLabel");
        public Element DrugBrandNameLabel = new Element(By.Marked, "DrugBrandNameLabel");
        public Element WatchAndLearnButton = new Element(By.Marked, "WatchAndLearnButton");
        public Element DrugInformation = new Element(By.Marked, "DrugInformation");
        public Element PriceLabel = new Element(By.Marked, "PriceLabel");
    }
}
