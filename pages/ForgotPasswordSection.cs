using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class ForgotPasswordSection
    {
        public Element Email = new Element(By.Class, "EditText");
        public Element Ok = new Element(By.Text, "Ok");
        public Element Cancel = new Element(By.Text, "Cancel");
        public Element Message = new Element(By.Label, "LoginMessage");
        public Element ForgotMessage = new Element(By.Text, "Enter your Email Address");
        public Element ConfirmationHeader = new Element(By.Text, "ScriptSave WellRx");
    }
}