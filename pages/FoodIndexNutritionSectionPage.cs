using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexNutritionSectionPage : BasePage
    {
        //Nutrition Section
        public Element NutrientHighlightsSection = new Element(By.Label, "NutrientHighlightsSectionView");
        public Element NutrientHighlightsHeader = new Element(By.Label, "NutrientHighlightsHeader");
        public Element ServingSizeSubtitle = new Element(By.Id, "ServingSizeSubtitle");
        public Element IngredientsLabel = new Element(By.Id, "IngredientsLabel");
        public Element CircularGraph = new Element(By.Label, "CircularGraph");
        public Element IngredientsSectionView = new Element(By.Label, "IngredientsSectionView");
        //Fat Calorie Section View
        public Element FatCalorieSectionView = new Element(By.Label, "FatCalorieSectionView");
        public Element CalorieBreakdownHeader = new Element(By.Label, "CalorieBreakdownHeader");
        public Element CalorieBreakdownText = new Element(By.Label, "CalorieBreakdownText");
        public Element CaloriesFromFatText = new Element(By.Label, "CaloriesFromFatText");
        public Element FatCalorieLabel = new Element(By.Label, "FatCalorieLabel");
        //Complete Nutrients Section View
        public Element CompleteNutrientsSectionView = new Element(By.Label, "CompleteNutrientsSectionView");
        public Element CompleteLabelInformationButton = new Element(By.Label, "CompleteLabelInformationButton");
        public Element NutritionLabelLayout = new Element(By.Label, "NutritionLabelLayout");
        public Element NutritionFactsHeader = new Element(By.Label, "NutritionFactsHeader");
        public Element NutritionFactsText = new Element(By.Label, "NutritionFactsText");
    }
}
