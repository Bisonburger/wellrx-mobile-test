using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class EditProfilePage : BasePage
    {
        public Element Header = new Element(By.Marked, "EditProfileHeading");
        public Element ProfileIcon = new Element(By.Marked, "ProfileIcon");
        public Element FirstName = new Element(By.Marked, "FirstNameEntry");
        public Element LastName = new Element(By.Marked, "LastNameEntry"); 
        public Element Email = new Element(By.Marked, "Email"); 
        public Element ZipCode = new Element(By.Marked, "ZipCode");
        public Element InviteCode = new Element(By.Marked, "InviteCodeexit");
        public Element GenderFemale = new Element(By.Marked, "GenderFemale");
        public Element GenderMale = new Element(By.Marked, "GenderMale");
        public Element SaveUpdates = new Element(By.Marked, "SaveProfileInformationButton");
        public Element Message = new Element(By.Label, "Profile updated successfully");
        public Element Ok = new Element(By.Text, "OK");
    }
}
