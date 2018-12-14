using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class FoodIndexPage : BasePage
    {
        public Element Header = new Element(By.Marked, "FoodIndexHeader");
        public Element MoreDetailsButton = new Element(By.Marked, "MoreDetailsButton");
        public Element SearchProductButton = new Element(By.Marked, "SearchProductButton");
        public Element ScanProductButton = new Element(By.Marked, "ScanProductButton");
        public Element FavoritesProductsButton = new Element(By.Marked, "FavoritesProductsButton");

        //More Details Prompt
        public Element MoreDetailsPromptHeader = new Element(By.Text, "Food Index Calculation");
        public Element MoreDetailsPromptOkButton = new Element(By.Text, "OK");

        #region View Favorites
        public Element FavoritesListItemsPage = new Element(By.Marked, "FavoritesListItemsPage");
        public Element FavoritesListItemsMessage = new Element(By.Marked, "FavoritesListItemsMessage");
        public Element FavoritesListEmptyMessage = new Element(By.Marked, "FavoritesListEmptyMessage");
        public Element FavoritesPageHeading = new Element(By.Marked, "FavoritesPageHeading");
        public Element SortLabel = new Element(By.Marked, "SortLabel");
        public Element FavoriteList = new Element(By.Marked, "FavoriteList");
        public Element ListImage = new Element(By.Marked, "ListImage");
        public Element ListNumber = new Element(By.Marked, "ListNumber");
        public Element ListDelete = new Element(By.Marked, "ListDelete");
        public Element ListItemName = new Element(By.Marked, "ListItemName");
        public Element SortIndexHighToLow = new Element(By.Text, "Index High to Low");
        #endregion
    }
}
