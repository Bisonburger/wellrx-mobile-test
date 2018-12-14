using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class LogInPage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "LoginPage");
        public Element Email = new Element(By.Marked, "EmailEntry");
        public Element Password = new Element(By.Marked, "PasswordEntry");
        public Element RememberMe = new Element(By.Marked, "RememberMeCheckbox");
        public Element LogIn = new Element(By.Marked, "LogInButton");
        public Element ValidationMessage = new Element(By.Marked, "ValidationMessageLabel");
        public Element ForgotPassword = new Element(By.Marked, "ForgotPasswordLinkButton");
        public ForgotPasswordSection ForgotPasswordDialog = new ForgotPasswordSection();
        public Element AlertTitle = new Element(By.Id, "alertTitle");
        public Element ForgotPasswordTitle = new Element(By.Text, "Enter your Email Address");
        public Element AlertNoThanks = new Element(By.Text, "No, thanks");
    }
}
