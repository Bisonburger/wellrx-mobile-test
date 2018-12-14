using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class MedicineChestPage : BasePage
    {
        #region Main med chest page
        public Element MedChestPage = new Element(By.Marked, "MedChestPage");
        public Element MedChestHeader = new Element(By.Marked, "PageHeading");
        public Element EmptyChestMsg = new Element(By.Text, "Your Medicine Chest is Empty...");
        public Element MedChestCreateAccount = new Element(By.Marked, "CreateAccountBtn");
        public Element MedChestListView = new Element(By.Marked, "MedChestListView");
        public Element PillListImage = new Element(By.Marked, "PillListImage");
        public Element PillListName = new Element(By.Marked, "PillListName");
        public Element PillListBellIcon = new Element(By.Marked, "PillListBellIcon");
        public Element PillListRefillIcon = new Element(By.Marked, "PillListRefillIcon");
        public Element DeleteButton = new Element(By.Marked, "DeleteButton");
        public Element ArchiveButton = new Element(By.Marked, "ArchiveButton");
        public Element AddMedications = new Element(By.Marked, "AddMedications");
        public Element RepriceButton = new Element(By.Marked, "RepriceButton");
        public Element ViewArchiveButton = new Element(By.Marked, "ViewArchiveButton");
        public Element NextButton = new Element(By.Marked, "NextButton");
        public Element SelectAllLinkButton = new Element(By.Marked, "SelectAllLinkButton");
        public Element MedicationsButton = new Element(By.Marked, "MedicationsButton");
        public Element RemindersButton = new Element(By.Marked, "RemindersButton");
        public Element DrugInteractionButton = new Element(By.Marked, "DrugInteractionHeader");
        public Element DrugInteractionText = new Element(By.Marked, "DrugInteractionText");
        public Element PharmacistButton = new Element(By.Marked, "PharmacistButton");
        #endregion

        #region Add Medication section
        public Element ManualEntryTabButton = new Element(By.Marked, "ManualEntryTabButton");
        public Element ImportTabButton = new Element(By.Marked, "ImportTabButton");
        public Element ManuallyEnterBtn = new Element(By.Marked, "ManuallyEnterBtn");
        public Element DrugNameContainer = new Element(By.Marked, "DrugNameContainer");
        public Element DrugFormRow = new Element(By.Marked, "DrugFormRow");
        public Element ChooseFormTablet = new Element(By.Text, "Tablet");
        public Element DrugStrengthRow = new Element(By.Marked, "DrugStrengthRow");
        public Element ChooseStrength75MG = new Element(By.Text, "75 MG");
        public Element DrugQuantityRow = new Element(By.Marked, "DrugQuantityRow");
        public Element ChooseQuantity15 = new Element(By.Text, "15");
        public Element PillReminderRow = new Element(By.Marked, "PillReminderRow");
        public Element RefillReminderRow = new Element(By.Marked, "RefillReminderRow");
        public Element AddMedicationsError = new Element(By.Marked, "AddMedicationsError");
        #endregion

        #region Drug interaction page
        public Element DrugInteractionsPage = new Element(By.Marked, "DrugInteractionsPage");
        public Element DrugInteractionsMessage = new Element(By.Marked, "DrugInteractionsMessage");
        public Element DrugInteractionsHeader = new Element(By.Marked, "DrugInteractionsHeader");
        public Element NumberOfInteractionsFoundLabel = new Element(By.Marked, "NumberOfInteractionsFoundLabel");
        public Element SeveritySubHeaderText = new Element(By.Marked, "SeveritySubHeaderText");
        public Element SeverityInteractionsText = new Element(By.Marked, "SeverityInteractionsText");
        #endregion

        public Element ShareButton = new Element(By.DeviceClass, "android.support.v7.view.menu.ActionMenuItemView", 1 , 1, "_UIButtonBarButton");
        public Element IosShareButton = new Element(By.Marked, "ShareButton");
        public Element SwipeLeftPopupPage = new Element(By.Marked, "SwipeLeftPopupPage");
        public Element MedChestError = new Element(By.Marked, "MedChestError");
        public Element CancelButton = new Element(By.Text, "Cancel");
        public Element YesButton = new Element(By.Text, "Yes");
        public Element NoButton = new Element(By.Text, "No");
    }
}
