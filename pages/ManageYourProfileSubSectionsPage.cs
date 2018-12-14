using System;
using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class  ManageYourProfileSubSectionsPage : BasePage
    {
        #region Manage Your Profile Sub Section Edit Notifications Page
        public Element EditNotificationSettingsPage = new Element(By.Marked, "EditNotificationSettingsPage");
        public Element EditNotificationsText = new Element(By.Marked, "EditNotificationsText");
        public Element PillAndRefillReminderText = new Element(By.Marked, "PillAndRefillReminderText");
        public Element EmailNewsletterText = new Element(By.Marked, "EmailNewsletterText");
        public Element SaveProfileInformationButton = new Element(By.Marked, "SaveProfileInformationButton");
        public Element PillReminderSwitch = new Element(By.Marked, "PillReminderSwitch");
        public Element EmailNotificationsSwitch = new Element(By.Marked, "EmailNotificationsSwitch");
        public Element ScriptSaveWellRxAlert = new Element(By.Text, "ScriptSave WellRx");
        public Element ScriptSaveWellRxAlertOk = new Element(By.Text, "OK");
        #endregion

        #region Manage Your Profile Sub Section Edit Condition Page
        public Element EditConditionDetailsHeader = new Element(By.Marked, "EditConditionDetailsHeader");
        public Element EditConditionDetailsText = new Element(By.Marked, "EditConditionDetailsText");
        public Element SelectHealthTypeSelections = new Element(By.Marked, "SelectHealthTypeSelections");
        public Element SelectConditionsSelections = new Element(By.Marked, "SelectConditionsSelections");
        public Element SaveConditionButton = new Element(By.Marked, "SaveConditionButton");
        public Element GeneralHealth = new Element(By.Text, "     General Health     ");
        public Element MensHealth = new Element(By.Text, "     Men's Health     ");
        public Element WomensHealth = new Element(By.Text, "     Women's Health     ");
        public Element Diabetes = new Element(By.Text, "     Diabetes     ");
        public Element HeartHealth = new Element(By.Text, "     Heart Health     ");
        public Element PregnancyAndMaternity = new Element(By.Text, "     Pregnancy & Maternity     ");
        #endregion

        #region Manage Your Allergies Sub Section Page
        public Element EditAllergensPage = new Element(By.Marked, "EditAllergensPage");
        public Element EditAllergensMessage = new Element(By.Marked, "EditAllergensMessage");
        public Element EditAllergenHeader = new Element(By.Marked, "EditAllergenHeader");
        public Element EditAllergenText = new Element(By.Marked, "EditAllergenText");
        public Element SelectAllergyOptions = new Element(By.Marked, "SelectAllergyOptions");
        public Element SelectIntoleranceOptions = new Element(By.Marked, "SelectIntoleranceOptions");
        public Element SaveAllergenButton = new Element(By.Marked, "SaveAllergenButton");
        public Element ShellfishFree = new Element(By.Text, "     Shellfish Free     ");
        public Element DairyFree = new Element(By.Text, "     Dairy Free     ");
        #endregion

        #region Manage Your Dietary Preferencess Sub Section Page
        public Element EditDietaryPage = new Element(By.Marked, "EditDietaryPage");
        public Element EditDietaryHeader = new Element(By.Marked, "EditDietaryHeader");
        public Element EditDietaryText = new Element(By.Marked, "EditDietaryText");
        public Element EditDietaryMessage = new Element(By.Marked, "EditDietaryMessage");
        public Element SelectDietaryProgramsOptions = new Element(By.Marked, "SelectDietaryProgramsOptions");
        public Element SelectHealthConsciousDietaryOptions = new Element(By.Marked, "SelectHealthConsciousDietaryOptions");
        public Element SelectLifestyleDietOptions = new Element(By.Marked, "SelectLifestyleDietOptions");
        public Element SaveDietaryButton = new Element(By.Marked, "SaveDietaryButton");
        public Element WeightWatchers = new Element(By.Text, "     Weight Watchers     ");
        public Element LowFat = new Element(By.Text, "     Low Fat     ");
        public Element Vegetarian = new Element(By.Text, "     Vegetarian     ");
        #endregion
    }
}
