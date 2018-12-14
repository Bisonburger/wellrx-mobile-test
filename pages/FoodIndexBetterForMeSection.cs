using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexBetterForMeSection : BasePage
    {
        //Better For Me Section
        public Element BetterForMeScore = new Element(By.Label, "BetterForMeScore");
        public Element BetterFormeItemName = new Element(By.Label, "ItemName");
        public Element BetterForMeSectionView = new Element(By.Label, "BetterForMeSectionView");
        public Element BetterForMeFoodImage = new Element(By.Label, "FoodImage");
        public Element BetterForMeFoodImageText = new Element(By.MarkedIndex, "FoodImageText", 2, 1);
        public Element BetterForMeFoodImageTextTwo = new Element(By.Label, "FoodImageTextTwo");
        public Element BetterForMeFoodViewMore = new Element(By.Label, "ViewMoreLabel");
        public Element BetterForMeFoodViewPrevious = new Element(By.Label, "ViewPreviousLabel");
    }
}
