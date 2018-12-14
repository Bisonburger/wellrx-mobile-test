using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class WelcomePage : BasePage
    {
        public Element PageContainer = new Element(By.Marked, "WelcomePage");

        public Element YesInviteCode = new Element(By.Marked, "HaveInviteCodeButton");
        public Element InviteCodeOrGroupNumber = new Element(By.Marked, "InviteCodeEntry");
        public Element Continue = new Element(By.Marked, "SaveInviteCodeButton");
        public Element YesGroupNumConfirmation = new Element(By.Text, "OK");

        public Element NoInviteCode = new Element(By.Marked, "NoInviteCodeButton");
        public Element AlreadyHaveAccount = new Element(By.Marked, "HaveAccountLinkButton");
    }
}
