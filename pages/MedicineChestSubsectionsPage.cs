using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class MedicineChestSubsectionsPage : BasePage
    {
        #region Archive Section
        public Element ArchivedDrugsPage = new Element(By.Marked, "ArchivedDrugsPage");
        public Element MedChestArchivedListView = new Element(By.Marked, "MedChestArchivedListView");
        public Element ArchivePageHeading = new Element(By.Marked, "ArchivePageHeading");
        public Element DeleteAllContainer = new Element(By.Marked, "DeleteAllContainer");
        public Element ArchiveSwipeDelete = new Element(By.Marked, "ArchiveSwipeDelete");
        public Element ArchiveSwipeRestore = new Element(By.Marked, "ArchiveSwipeRestore");
        public Element EmptyArchiveListMessage = new Element(By.Marked, "EmptyArchiveListMessage");
        public Element ArchiveMedicationName = new Element(By.Marked, "ArchiveMedicationName");
        public Element ArchiveMedicationText = new Element(By.Marked, "ArchiveMedicationText");
        #endregion

        #region Reprice Section
        //Select Medications
        public Element RepricingSelectPage = new Element(By.Marked, "RepricingSelectPage");
        public Element SelectMedicationsHeading = new Element(By.Marked, "SelectMedicationsHeading");
        public Element PillListImage = new Element(By.Marked, "PillListImage");
        public Element PillListName = new Element(By.Marked, "PillListName");
        public Element PillListText = new Element(By.Marked, "PillListText");
        //Select Method
        public Element RepricingMethodPage = new Element(By.Marked, "RepricingMethodPage");
        public Element RepricingMethodHeader = new Element(By.Marked, "RepricingMethodHeader");
        public Element RepricingMethodList = new Element(By.Marked, "RepricingMethodList");
        public Element MethodSelectionOne = new Element(By.MarkedIndex, "MethodSelection", 1, 1);
        public Element MethodSelectionTwo = new Element(By.MarkedIndex, "MethodSelection", 2, 2);
        public Element MethodSelectionThree = new Element(By.MarkedIndex, "MethodSelection", 3, 3);
        public Element MethodSelectionDetails = new Element(By.Marked, "MethodSelectionDetails");
        //Select Location
        public Element RepricingLocationPage = new Element(By.Marked, "RepricingLocationPage");
        public Element RepricingLocationHeader = new Element(By.Marked, "PageHeading");
        public Element SearchMedicationLocationEntry = new Element(By.Marked, "SearchMedicationLocationEntry");
        public Element UseLocationLinkButton = new Element(By.Marked, "UseLocationLinkButton");
        #endregion

        #region Share sections
        public Element SharePageHeading = new Element(By.Marked, "PageHeading");
        public Element MedicationsButton = new Element(By.Marked, "MedicationsButton");
        public Element RemindersButton = new Element(By.Marked, "RemindersButton");
        public Element SelectMedicationsPage = new Element(By.Marked, "SelectMedicationsPage");
        public Element ShareMedicationButton = new Element(By.Marked, "ShareMedicationButton");
        public Element DateRangeStackLayout = new Element(By.Marked, "DateRangeStackLayout");
        public Element StartDateRow = new Element(By.Marked, "StartDateRow");
        public Element EndDateRow = new Element(By.Marked, "EndDateRow");
        public Element ReminderListView = new Element(By.Marked, "ReminderListView");
        public Element SelectRemindersCheckBox = new Element(By.Marked, "SelectRemindersCheckBox");
        #endregion

        public Element SelectAllLinkButton = new Element(By.Marked, "SelectAllLinkButton");
        public Element MedicationListView = new Element(By.Marked, "MedicationListView");
        public Element NextButton = new Element(By.Marked, "NextButton");
        public Element PassiveHeader = new Element(By.Marked, "PassiveHeader");
        public Element SwipeLeftPopupPage = new Element(By.Marked, "SwipeLeftPopupPage");
        public Element MedChestError = new Element(By.Marked, "MedChestError");
        public Element YesButton = new Element(By.Text, "Yes");
        public Element NoButton = new Element(By.Text, "No");
        public Element OkButton = new Element(By.Text, "Ok");
    }
}
