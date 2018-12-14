using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class DashboardSetNotficationPage : BasePage
    {
        #region Notfication Card Details
        public Element RemindersPage = new Element(By.Marked, "RemindersPage");
        public Element RemindersPageHeader = new Element(By.Marked, "PageHeading");
        public Element AllRemindersLinkButton = new Element(By.Marked, "AllRemindersLinkButton");
        public Element TodaysRemindersPageMessage = new Element(By.Marked, "TodaysRemindersPageMessage");
        public Element AddReminderButton = new Element(By.Marked, "AddReminderButton");
        public Element RemindersListView = new Element(By.Marked, "RemindersListView");
        public Element GoToDrugPharmacyTap = new Element(By.Marked, "GoToDrugPharmacyTap");
        public Element NoRemindersMessage = new Element(By.Marked, "NoRemindersMessage");
        #endregion

        #region Notfication Pill Details
        public Element MedicationTakenCheckBox = new Element(By.Marked, "MedicationTakenCheckBox");
        public Element SetMoodLinkButton = new Element(By.Marked, "SetMoodLinkButton");
        public Element ReminderNotesEntry = new Element(By.Marked, "ReminderNotesEntry");
        public Element SaveReminderButton = new Element(By.Marked, "SaveReminderButton");
        public Element MoodPage = new Element(By.Marked, "MoodPage");
        public Element EmotionSlider = new Element(By.Marked, "EmotionSlider");
        public Element SetMoodButton = new Element(By.Marked, "SetMoodButton");
        #endregion

        public Element MoodImage = new Element(By.Marked, "MoodImage");
        public Element ReminderDateTimeDisplay = new Element(By.Marked, "ReminderDateTimeDisplay");
        public Element TodaysReminderDrugName = new Element(By.Marked, "TodaysReminderDrugName");
        public Element TodaysReminderPillFormStrength = new Element(By.Marked, "TodaysReminderPillFormStrength");
    }
}
