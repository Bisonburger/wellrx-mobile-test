using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class MedicineChestDetailsPage : BasePage
    {
        public Element MedChestDetailPage = new Element(By.Marked, "MedChestDetailPage");
        public Element MedicationTabButton = new Element(By.Marked, "MedicationTabButton");
        public Element NotificationsTabButton = new Element(By.Marked, "NotificationsTabButton");
        public Element InformationTabButton = new Element(By.Marked, "InformationTabButton");
        public Element SaveButton = new Element(By.Marked, "SaveButton");
        public Element MoveToArchiveButton = new Element(By.Marked, "MoveToArchiveButton");
        public Element MedChestDetailMessage = new Element(By.Marked, "MedChestDetailMessage");
        public Element MedicationPillImage = new Element(By.Marked, "MedicationPillImage");
        public Element MedicationPillName = new Element(By.Marked, "MedicationPillName");
        public Element MedicationPillInformation = new Element(By.Marked, "MedicationPillInformation");
        public Element TrashIcon = new Element(By.Marked, "TrashIcon");
        public Element AtPreferredIcon = new Element(By.Marked, "AtPreferredIcon");
        public Element PreferredPharmacyText = new Element(By.Marked, "PreferredPharmacyText");
        public Element YesButton = new Element(By.Text, "Yes");
        public Element CancelButton = new Element(By.Text, "Cancel");
        //Medication Tab
        public Element DoseFormRow = new Element(By.Marked, "DoseFormRow");
        public Element StrengthRow = new Element(By.Marked, "StrengthRow");
        public Element QuantityRow = new Element(By.MarkedDescendant, "QuantityRow", 6 , 6 );
        public Element ChooseQuantity30 = new Element(By.Text, "30");
        public Element ChooseStrength300MG = new Element(By.Text, "300 MG");
        //Notfication Tab
        public Element MedicationNotifications = new Element(By.Marked, "MedicationNotifications");
        public Element PillReminderRow = new Element(By.Marked, "PillReminderRow");
        public Element RefillReminderRow = new Element(By.Marked, "RefillReminderRow");
        public Element AlertSetText = new Element(By.Text, "Alert Set");
        //Information Tab
        public Element MedicationInformation = new Element(By.Marked, "MedicationInformation");
        public Element NoInformationAvailableText = new Element(By.Marked, "NoInformationAvailableText");
        public Element MedicationInformationCardsOne = new Element(By.MarkedIndex, "MedicationInformationCards", 1, 1);
        public Element MedicationInformationCardsTwo = new Element(By.MarkedIndex, "MedicationInformationCards", 9, 21);
        public Element MedicationInformationCardsThree = new Element(By.MarkedIndex, "MedicationInformationCards", 18, 11);
        public Element MedicationInformationCardsFour = new Element(By.MarkedIndex, "MedicationInformationCards", 9, 11);
        public Element DrugContentPage = new Element(By.Marked, "DrugContentPage");
        public Element DrugContentMessage = new Element(By.Marked, "DrugContentMessage");
        public Element EnglishButton = new Element(By.Marked, "EnglishButton");
        public Element SpanishButton = new Element(By.Marked, "SpanishButton");
        public Element DrugInformation = new Element(By.Marked, "DrugInformation");
        public Element DrugImagesPage = new Element(By.Marked, "DrugImagesPage");
        public Element DrugImageRepeaterView = new Element(By.Marked, "DrugImageRepeaterView");
        public Element MedicineVideoPage = new Element(By.Marked, "MedicineVideoPage");
        public Element MedicineVideoPageMessage = new Element(By.Marked, "MedicineVideoPageMessage");
        public Element MedicationVideos = new Element(By.Marked, "MedicationVideos");
        public Element BackToDashboardButton = new Element(By.Marked, "BackToDashboardButton");
        public Element LifestyleInteractionsPage = new Element(By.Marked, "LifestyleInteractionsPage");
        public Element LifestyleInteractionsMessage = new Element(By.Marked, "LifestyleInteractionsMessage");
        public Element CautionImage = new Element(By.Marked, "CautionImage");
        public Element NumberOfInteractions = new Element(By.Marked, "NumberOfInteractions");
        public Element InteractionsExtendedText = new Element(By.Marked, "InteractionsExtendedText");
    }
}