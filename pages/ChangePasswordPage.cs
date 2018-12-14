using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class ChangePasswordPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "ChangePasswordPage");
        public Element Header = new Element(By.Text, "Change Password");

        public Element CurrentPassword = new Element(By.Marked, "CurrentPasswordEntry");
        public Element NewPassword = new Element(By.Marked, "NewPasswordEntry");
        public Element VerifyNewPassword = new Element(By.Marked, "VerifyPasswordEntry");
        public Element UpdatePassword = new Element(By.Label, "UpdatePassword");
        public Element ForgotPassword = new Element(By.Marked, "ForgotPasswordLinkButton");

        public Element Message = new Element(By.Label, "ChangePasswordMessage");
        public Element MessageOkButton = new Element(By.Text, "OK");

        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
    }
}
