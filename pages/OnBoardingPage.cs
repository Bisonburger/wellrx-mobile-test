using WellRx.UITests.Base;

namespace WellRx.UITests.Pages
{
    public class OnBoardingPage : BasePage
    {
        public Element OnBoardingPageContainer = new Element(By.Marked, "OnboardInitialTextFirstScreen");
        public Element OnBoardingLabelPriceMeds = new Element(By.Marked, "OnboardLabelPriceMeds");

        #region On Boarding Page Grocery Guidance     
        public Element OnBoardingPageGroceryGuidanceContainer = new Element(By.Marked, "OnboardingGroceryGuidanceLabel");
        public Element OnBoardingContinueLink = new Element(By.Marked, "OnBoardingContinueLink");
        #endregion

        #region On Boarding Page Scan Save
        public Element OnBoardingPageScanSaveContainer = new Element(By.Marked, "OnboardingScanSaveLabel");
        #endregion

        #region On Boarding Price Meds Page
        public Element OnBoardingPriceMedsContainer = new Element(By.Marked, "OnboardingPriceMedsText");
        public Element TryItOnboardingButton = new Element(By.Marked, "TryItPriceMedsButton");
        public Element SkipForNowOboardingButton = new Element(By.Marked, "SkipForNowPriceMedsButton");
        #endregion

        #region On Boarding Price Meds Teaser Savings Page
        public Element OnBoardingPriceMedsTeaserSavingsText = new Element(By.Marked, "TeaserSavingsLowestPriceFound");
        public Element TeaserSavingsContinueButton = new Element(By.Marked, "TeaserSavingsContinueButton");
        #endregion

        #region On Boarding Try Barcode Scanner Page
        public Element OnBoardingTryBarcodeScannerText = new Element(By.Marked, "OnboardingTryBarcodeScannerText");
        public Element BarcodeScannerTryItOnboardingButton = new Element(By.Marked, "BarcodeScannerTryItButton");
        public Element BarcodeScannerSkipForNowOboardingButton = new Element(By.Marked, "BarcodeScannerSkipForNowButton");
        #endregion

        #region On Boarding Barcode Scanner Page
        public Element BarcodeScannerProductSearchText = new Element(By.Marked, "SearchProductText");
        public Element BarcodeScannerCancelButton = new Element(By.Marked, "CancelScanTap");
        public Element BarcodeScannerProductSearchButton = new Element(By.Marked, "SearchProductTap");
        public Element ScanStatusMessageLabel = new Element(By.Label, "ScanStatusMessageLabel");
        public Element BarcodeScanningPage = new Element(By.Label, "BarcodeScanningPage");
        public Element SearchProductButton = new Element(By.DeviceClass, "android.support.v7.widget.ActionMenuView", 1, 2, "_UIButtonBarButton");
        public Element UnableToScanMessage = new Element(By.Id, "message");
        public Element UnableToScanSearchButton = new Element(By.Text, "Search");
        public Element UnableToScanRetryButton = new Element(By.Text, "Retry");
        #endregion

        #region On Boarding No Wellness Page
        public Element GeneralTutorialPage = new Element(By.Marked, "GeneralTutorialPage");
        public Element OnboardingNoWellnessLabel = new Element(By.Marked, "OnboardingNoWellnessLabel");
        #endregion
    }
}
