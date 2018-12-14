using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class BottomMenuOptionsSection : BasePage
    {
        public Element Dashboard = new Element(By.Text, "Dashboard");
        public Element MedChest = new Element(By.Text, "Med Chest");
        public Element PriceMeds = new Element(By.Text, "Price Meds");
        public Element FoodIndex = new Element(By.Text, "Food Index");
        public Element More = new Element(By.Text, "More");
    }
}
