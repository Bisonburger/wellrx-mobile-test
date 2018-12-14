using System;
using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class ManageYourProfilePage : BasePage
    {
        public Element ProfileTabButton = new Element(By.Marked, "ProfileTabButton");
        public Element PreferencesTabButton = new Element(By.Marked, "PreferencesTabButton");
        public Element SettingsTabButton = new Element(By.Marked, "SettingsTabButton");
        public Element ScrollView = new Element(By.Marked, "ScrollView");

        #region Profile Tab Elements
        //Account Details Card
        public Element NameLabelHeader = new Element(By.Marked, "NameLabelHeader");
        public Element Header = new Element(By.Text, "Manage Account");
        public Element ManageProfile = new Element(By.Marked, "AccountManagementPage");
        public Element AccountDetailsContentView = new Element(By.Marked, "AccountDetailsContentView");
        public Element AccountDetailsHeader = new Element(By.Marked, "AccountDetailsHeader");
        public Element Name = new Element(By.Marked, "UserFullName");
        public Element Email = new Element(By.Marked, "UserEmail");
        public Element DOB = new Element(By.Marked, "DateOfBirth");
        public Element InviteCode = new Element(By.Marked, "InviteCode");
        public Element ProfileIcon = new Element(By.Marked, "ProfileIcon");
        public Element AccountEdit = new Element(By.Marked, "EditIcon");
        public Element ZipCode = new Element(By.Marked, "ZipCode");
        public Element MobileNumber = new Element(By.Marked, "MobileNumber");
        //Conditions Card
        public Element AccountConditionContentView = new Element(By.Marked, "AccountConditionContentView");
        public Element ConditionsHeader = new Element(By.Marked, "ConditionsHeader");
        public Element NoConditionsText = new Element(By.Marked, "NoConditionsText");
        public Element ConditionTypeText = new Element(By.Marked, "ConditionTypeText");
        public Element ConditionEdit = new Element(By.Marked, "ConditionEdit");
        public Element HealthLabel = new Element(By.Marked, "HealthLabel");
        //Saving Card View
        public Element SavingCardView = new Element(By.Marked, "SavingCardView");
        public Element SavingsCardText = new Element(By.Marked, "SavingsCardText");
        public Element SavingsCardExpandedView = new Element(By.Marked, "SavingsCardExpandedView");
        public Element SavingsCardCancelButton = new Element(By.Marked, "SavingsCardCancelButton");
        public Element SavingsCardDisclaimer = new Element(By.Marked, "SavingsCardDisclaimer");
        //Account Allergy Content Card
        public Element AccountAllergyContentView = new Element(By.Marked, "AccountAllergyContentView");
        public Element AllergensHeader = new Element(By.Marked, "AllergensHeader");
        public Element NoAllergensLayout = new Element(By.Marked, "NoAllergensLayout");
        public Element ProvideAllergenMessage = new Element(By.Marked, "ProvideAllergenMessage");
        public Element AddAllergiesLink = new Element(By.Marked, "AddAllergiesLink");
        public Element AllergiesIcon = new Element(By.Marked, "AllergiesIcon");
        public Element AllergenTypeText = new Element(By.Marked, "AllergenTypeText");
        public Element AllergenEdit = new Element(By.Marked, "AllergenEdit");
        public Element AllergenValues = new Element(By.Marked, "AllergenValues");
        #endregion

        #region Preferences Tab Elements
        //Preferences Dietary Card
        public Element PreferencesDietaryCard = new Element(By.Marked, "PreferencesDietaryCard");
        public Element DietaryHeader = new Element(By.Marked, "DietaryHeader");
        public Element ProvideDietaryMessage = new Element(By.Marked, "ProvideDietaryMessage");
        public Element AddPreferencesDietaryLink = new Element(By.Marked, "AddPreferencesDietaryLink");
        public Element DietPreferencesIcon = new Element(By.Marked, "DietPreferencesIcon");
        public Element DietaryPreferencesText = new Element(By.Marked, "DietaryPreferencesText");
        public Element DietaryPreferencesEdit = new Element(By.Marked, "DietaryPreferencesEdit");
        public Element DietaryValues = new Element(By.Marked, "DietaryValues");
        //perferd Pharmact Card
        public Element AccountPreferencesContentView = new Element(By.Marked, "AccountPreferencesContentView");
        public Element PreferredPharmacyHeader = new Element(By.Marked, "PreferredPharmacyHeader");
        public Element SetPreferredPharmacyText = new Element(By.Marked, "SetPreferredPharmacyText");
        public Element AddPreferredPharmacyLink = new Element(By.Marked, "AddPreferredPharmacyLink");
        public Element PharmacyName = new Element(By.Marked, "PharmacyName");
        public Element PharmacyPhoneNumber = new Element(By.Marked, "PharmacyPhoneNumber");
        public Element PharmacyAddress = new Element(By.Marked, "PharmacyAddress");
        #endregion

        #region Settings Tab Elements
        //Notifications Card
        public Element NotificationSettingsTap = new Element(By.Marked, "NotificationSettingsTap");
        public Element NotificationsHeader = new Element(By.Marked, "NotificationsHeader");
        public Element PillAndRefillReminderText = new Element(By.Marked, "PillAndRefillReminderText");
        public Element EmailNewsletterText = new Element(By.Marked, "EmailNewsletterText");
        public Element NotificationsEdit = new Element(By.Marked, "NotificationsEdit");
        #endregion
    }
}
