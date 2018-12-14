using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class MoreMenuItemsSection : BasePage
    {
        public Element MenuContainer = new Element(By.Marked, "MoreMenuItemsPage");
        public Element ManageAccount = new Element(By.Text, "Edit Profile");
        public Element ChangePassword = new Element(By.Text, "Change Password");
        public Element ApplyInviteCode = new Element(By.Text, "Apply Invite Code");
        public Element AskPharmacist = new Element(By.Text, "Ask a Pharmacist");
        public Element AboutUs = new Element(By.Text, "About Us");
        public Element AboutUsTwo = new Element(By.TextIndex, "About Us", 3, 3);
        public Element FAQs = new Element(By.Text, "FAQs");
        public Element ContactUs = new Element(By.Text, "Contact Us");
        public Element Feedback = new Element(By.Text, "Feedback");
        public Element Settings = new Element(By.Text, "Settings");
        public Element HelpSupport = new Element(By.Text, @"Help/Support");
        public Element SignInSignUpButton = new Element(By.Label, "Sign In/Sign Up");
        public Element LogOut = new Element(By.Text, "Log Out");

        #region logout confirmation dialog
        public Element YesLogOut = new Element(By.Text, "Yes");
        public Element NoLogOut = new Element(By.Text, "No");
        #endregion
    }
}
