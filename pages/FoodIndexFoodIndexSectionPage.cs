using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexFoodIndexSectionPage : BasePage
    {
        //Food Index Section
        public Element ConditionText = new Element(By.Label, "ConditionText");
        public Element FoodDeterminantSmartLabel = new Element(By.Label, "FoodScoreSectionView");
        public Element CalorieLabel = new Element(By.Label, "CalorieLabel");
        public Element IngredientsCountLabel = new Element(By.Label, "IngredientsCountLabel");
        public Element FoodIndexScoreLabel = new Element(By.Label, "FoodScoreLayout");
        public Element NoFoodIndexLabel = new Element(By.Label, "NoFoodIndexLabel");
        public Element HowIsThisGeneratedButton = new Element(By.Label, "HowIsThisGeneratedLinkButton");
        public Element Index_FoodScoreSectionView = new Element(By.Label, "FoodScoreSectionView");
        public Element DailyValueCalorieSectionView = new Element(By.Label, "DailyValueCalorieSectionView");
        public Element FoodConditionScoreSectionView = new Element(By.Label, "FoodConditionScoreSectionView");
        public Element FoodIndexCalculationText = new Element(By.Label, "FoodIndexCalculationText");
        public Element FoodIndexCalculationOk = new Element(By.Label, "OkButton");
        public Element DailyValueHeader = new Element(By.Label, "DailyValueHeader");
        public Element DailyValueText = new Element(By.Label, "DailyValueText");
        public Element GeneralHealthView = new Element(By.Label, "GeneralHealthView");
        public Element WomensHealth = new Element(By.Label, "WomenHealth");
        public Element MenHealth = new Element(By.Label, "MenHealth");
        public Element ConditionHealthView = new Element(By.Label, "ConditionHealthView");
        public Element SelectAConditionText = new Element(By.Label, "SelectAConditionText");
        public Element ConditionPicker = new Element(By.Label, "ConditionPicker");
        public Element ViewIndexByOther = new Element(By.Label, "ViewIndexByOther");
        public Element AllConditionsView = new Element(By.Label, "AllConditionsView");
        public Element TwoConditionsView = new Element(By.Label, "TwoConditionsView");
        public Element SelectCoditionHeader = new Element(By.Label, "alertTitle");
        public Element SelectCoditionOk = new Element(By.Text, "OK");
        public Element SelectCoditionCancel = new Element(By.Text, "Cancel");
        public Element SelectCoditionDone = new Element(By.Text, "Done");
    }
}
