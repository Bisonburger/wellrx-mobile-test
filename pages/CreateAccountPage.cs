using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class CreateAccountPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "CreateAccountPage");
        public Element Title = new Element(By.Marked, "PageHeading");

        public Element FirstName = new Element(By.Marked, "FirstNameEntry");
        public Element LastName = new Element(By.Marked, "LastNameEntry");
        public Element Email= new Element(By.Marked, "EmailEntry");
        public Element Password = new Element(By.Marked, "PasswordEntry");
        public Element DOB = new Element(By.Marked, "DobInfo");
        public Element ZipCode = new Element(By.Marked, "ZipCodeEntry");
        public Element InviteCode = new Element(By.Marked, "InviteCodeEntry");
        public Element UserAgreementCheckbox = new Element(By.Marked, "UserAgreementCheckbox");
        public Element TermsConditiionsLink = new Element(By.Text, "Terms & Conditions");
        public Element PrivacyPolicyLink = new Element(By.Text, "Privacy Policy");
        public Element Notifications = new Element(By.Marked, "NotificationsCheckbox");


        public Element SaveNewAccount = new Element(By.Marked, "SaveNewAccountButton");
        public Element ValidationMessage = new Element(By.Marked, "ValidationMessageLabel");
        public Element AlreadyHaveAccount = new Element(By.Marked, "AccountExistsLinkButton");

        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
    }
}
