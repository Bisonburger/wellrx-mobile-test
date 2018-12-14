using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class MedicineChestReminderPage : BasePage
    {

        public Element ReminderSwitchRow = new Element(By.Marked, "ReminderSwitchRow");
        public Element ToggleSwitch = new Element(By.Marked, "ToggleSwitch");
        public Element SaveButton = new Element(By.Marked, "SaveButton");
        public Element UpperCaseOK = new Element(By.Text, "OK");
        public Element LowerCaseOk = new Element(By.Text, "Ok");
        public Element Cancel = new Element(By.Text, "Cancel");
        public Element DoneButton = new Element(By.Text, "Done");
        public Element DatePicker = new Element(By.Marked, "datePicker");
        public Element AlertMessageEntry = new Element(By.Marked, "AlertMessageEntry");
        public Element FrequencyRow = new Element(By.MarkedDescendant, "FrequencyRow", 6 ,6);

        #region Pill Reminder Elements
        public Element PillReminderPage = new Element(By.Marked, "PillReminderPage");
        public Element PillReminderHeader = new Element(By.Marked, "PillReminderHeader");
        //For the pill reminder "When?" selection
        public Element ReminderIntervalRow = new Element(By.Marked, "ReminderIntervalRow");
        public Element PillReminderIntervalPage = new Element(By.Marked, "PillReminderIntervalPage");
        public Element PillReminderIntervalHeader = new Element(By.Marked, "PillReminderIntervalHeader");
        public Element ReminderTypeRow = new Element(By.Marked, "ReminderTypeRow");
        public Element RepeatDaily = new Element(By.Text, "Daily");
        public Element RepeatInterval = new Element(By.Text, "Interval");
        public Element RepeatCycle = new Element(By.Text, "Cycle");
        public Element DailyOptionsStackLayout = new Element(By.Marked, "DailyOptionsStackLayout");
        public Element CheckboxImage = new Element(By.MarkedIndex, "CheckboxImage", 1, 1);
        public Element IntervalOptionsStackLayout = new Element(By.Marked, "IntervalOptionsStackLayout");
        public Element IntervalRow = new Element(By.Marked, "IntervalRow");
        public Element IntervalDaily = new Element(By.Text, "Daily");
        public Element IntervalWeekly = new Element(By.Text, "Weekly");
        public Element IntervalMonthly = new Element(By.Text, "Monthly");
        public Element CycleOptionsStackLayout = new Element(By.Marked, "CycleOptionsStackLayout");
        public Element CycleRow = new Element(By.Marked, "CycleRow");
        public Element CycleText = new Element(By.Text, "42+7");
        public Element CyclePicker = new Element(By.Marked, "CyclePicker");
        public Element FirstPillTakenRow = new Element(By.Marked, "FirstPillTakenRow");
        public Element FirstPillTakenCalendar = new Element(By.Text, "Date First Pill Taken");
        public Element PlaceboRemindersSwitchRow = new Element(By.Marked, "PlaceboRemindersSwitchRow");
        //For the pill reminder "How Often?" selection
        public Element ReminderFrequencyRow = new Element(By.Marked, "ReminderFrequencyRow");
        public Element PillReminderFrequencyPage = new Element(By.Marked, "PillReminderFrequencyPage");
        public Element PillReminderFrequencyHeader = new Element(By.Marked, "PillReminderFrequencyHeader");
        public Element FrequencyPicker = new Element(By.Marked, "FrequencyPicker");
        public Element FrequencyTime = new Element(By.Text, "3");
        public Element AlertTimeSetting = new Element(By.MarkedIndex, "AlertTimeSetting", 1, 1);
        public Element AlertTimeClock = new Element(By.Text, "Alert Time");
        //For the pill reminder "Start Date" selection
        public Element StartDateRow = new Element(By.Marked, "StartDateRow");
        public Element StartDateCalendar = new Element(By.Text, "Start Date");
        //For the pill reminder "End Date" selection
        public Element EndDateRow = new Element(By.Text, "End");
        public Element EndDateCalendar = new Element(By.Text, "End Date");
        #endregion

        #region Refill Reminder Elements
        public Element RefillReminderPage = new Element(By.Marked, "RefillReminderPage");
        public Element RefillReminderHeader = new Element(By.Marked, "RefillReminderHeader");
        public Element DateFilledRow = new Element(By.Marked, "DateFilledRow");
        public Element QuantityFilledRow = new Element(By.Marked, "QuantityFilledRow");
        public Element FrequencyUnitRow = new Element(By.Marked, "FrequencyUnitRow");
        public Element AlertTimeRow = new Element(By.Marked, "AlertTimeRow");
        public Element AlertIntervalRow = new Element(By.Marked, "AlertIntervalRow");
        public Element AlertIntervalText = new Element(By.Text, "7 days before");
        #endregion
    }
}
