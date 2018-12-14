using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexFoodDetailsPage : BasePage
    {
        //Main Food details page
        public Element ProductInfoPage = new Element(By.Marked, "ProductInfoPage");
        public Element SummaryTabButon = new Element(By.Marked, "SummaryTabButon");
        public Element FoodIndexTabButon = new Element(By.Marked, "FoodIndexTabButon");
        public Element NutritionTabButon = new Element(By.Marked, "NutritionTabButon");
        public Element BetterForMeTabButon = new Element(By.Marked, "BetterForMeTabButon");
        public Element ProductInfoMessage = new Element(By.Marked, "ProductInfoMessage");
        public Element ItemRemovedText = new Element(By.Text, "Item removed from favorites successfully");
        public Element ItemAddedText = new Element(By.Text, "Item added to favorites successfully");

        //Summary Section
        public Element PassiveHeader = new Element(By.Marked, "PassiveHeaderView");
        public Element ProductSummarySection = new Element(By.Marked, "ProductSummarySectionView");
        public Element ProductImage = new Element(By.Marked, "ProductImage");
        public Element AddToListButton = new Element(By.Marked, "AddToListButton");
        public Element FavoriteStar = new Element(By.Marked, "FavoriteStar");
        public Element FoodScoreSectionView = new Element(By.Marked, "FoodScoreSectionView");
        public Element BetterForMeSummarySection = new Element(By.Marked, "BetterForMeSummarySectionView");
        public Element NutrientBreakdownSection = new Element(By.Marked, "NutrientBreakdownSectionView");
        public Element ViewLabelInfoLabelButton = new Element(By.Marked, "ViewLabelInfoLabel");
        public Element NutritionFactsHeader = new Element(By.Marked, "NutritionFactsHeader");
        public Element NutritionFactsText = new Element(By.Marked, "NutritionFactsText");
        public Element NutritionFactsTable = new Element(By.Marked, "NutritionFactsTable");
        public Element NutritionFactsViewMoreButton = new Element(By.Marked, "ViewMoreButton");
        public Element BetterForMeHeader = new Element(By.Marked, "BetterForMeHeader");
        public Element ConditionsLabel = new Element(By.Marked, "ConditionsExtLabel");
        public Element BetterForMeSummaryView = new Element(By.Marked, "BetterForMeSectionView");
        public Element BetterForMeViewMoreButton = new Element(By.Marked, "BetterForMeViewMoreButton");
        public Element LoadingIndecator = new Element(By.Marked, "LoadingIndicator");
    }
}
