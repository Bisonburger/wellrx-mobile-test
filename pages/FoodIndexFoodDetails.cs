using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexFoodDetails : BasePage
    {
        //Main Food details page
        public Element ProductInfoPage = new Element(By.Label, "ProductInfoPage");
        public Element SummaryTabButon = new Element(By.Label, "SummaryTabButon");
        public Element FoodIndexTabButon = new Element(By.Label, "FoodIndexTabButon");
        public Element NutritionTabButon = new Element(By.Label, "NutritionTabButon");
        public Element BetterForMeTabButon = new Element(By.Label, "BetterForMeTabButon");

        //Summary Section
        public Element PassiveHeader = new Element(By.Label, "PassiveHeaderView");
        public Element ProductSummarySection = new Element(By.Label, "ProductSummarySectionView");
        public Element ProductImage = new Element(By.Label, "ProductImage");
        public Element AddToListButton = new Element(By.Label, "AddToListButton");
        public Element FoodScoreSectionView = new Element(By.Label, "FoodScoreSectionView");
        public Element NutrientHighlightsSection = new Element(By.Label, "NutrientHighlightsSectionView");
        public Element NutrientHighlightsHeader = new Element(By.Label, "NutrientHighlightsHeader");
        public Element ServingSizeSubtitle = new Element(By.Id, "ServingSizeSubtitle");
        public Element IngredientsLabel = new Element(By.Id, "IngredientsLabel"); 
        public Element BetterForMeSummarySection = new Element(By.Label, "BetterForMeSummarySectionView");
        public Element NutrientBreakdownSection = new Element(By.Label, "NutrientBreakdownSectionView");
        public Element ViewLabelInfoLabelButton = new Element(By.Label, "ViewLabelInfoLabel");
        public Element NutritionFactsHeader = new Element(By.Label, "NutritionFactsHeader");
        public Element NutritionFactsText = new Element(By.Label, "NutritionFactsText");
        public Element NutritionFactsTable = new Element(By.Label, "NutritionFactsTable");
        public Element NutritionFactsViewMoreButton = new Element(By.Label, "ViewMoreButton");
        public Element BetterForMeHeader = new Element(By.Label, "BetterForMeHeader");
        public Element ConditionsLabel = new Element(By.Label, "ConditionsExtLabel");
        public Element BetterForMeSummaryView = new Element(By.Label, "BetterForMeRepeaterFlexView");
        public Element BetterForMeViewMoreButton = new Element(By.Label, "BetterForMeViewMoreButton");



        //Food Index Section

        //Nutrition Section

        //Better For Me Section
        public Element BetterForMeScore = new Element(By.Label, "BetterForMeScore");
        public Element BetterFormeItemName = new Element(By.Label, "ItemName");

    }
}
