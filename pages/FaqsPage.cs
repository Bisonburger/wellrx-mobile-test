using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FaqsPage : BasePage
    {
        public Element Header = new Element(By.Label, "PageHeading");
        public Element FirstQuestion = new Element(By.MarkedChild, "QuestionsList", 2, 3);

        public AnswerSection Answer = new AnswerSection();

        public BottomMenuOptionsSection BottomMenuOptions = new BottomMenuOptionsSection();
        public MoreMenuItemsSection MoreMenuOptions = new MoreMenuItemsSection();
    }
}
