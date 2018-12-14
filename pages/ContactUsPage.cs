using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class ContactUsPage : BasePage
    {
        public Element ContactUsHeader = new Element(By.Marked, "PageHeading");
        public Element EmailEntry = new Element(By.Marked, "EmailEntry");
        public Element PhoneEntry = new Element(By.Marked, "PhoneEntry");
        public Element CommentsEntry = new Element(By.Marked, "CommentsEntry");
        public Element SubmitButton = new Element(By.Marked, "SubmitForm");
        public Element ErrorText = new Element(By.Text, "Your Feedback could not be submitted");
        public Element ErrorButton = new Element(By.Text, "OK");
        public Element ContactUsError = new Element(By.Label, "ValidationMessageLabel");
        public Element SubmitSucsessMessae = new Element(By.Text, "Your feedback has been submitted. Thank you."); 
    }
}
