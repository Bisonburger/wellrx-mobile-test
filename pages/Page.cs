//using System;

//namespace WellRx.UITests.Pages
//{
//    public static class Page
//    {
//        static WelcomePage _welcomePage;
//        static CreateAccountPage _createAccountPage;
//        static SavingsTeaserPage _savingsTeaserPage;
//        static TeaserSearchResultsPage _teaserSearchResultsPage;
//        static LogInPage _logInPage;
//        static HomePage _DashboardPage;
//        static MedicineChestPage _medicineChestPage;
//        static PriceMedicinePage _priceMedicinePage;
//        static SavingscardPage _savingscardPage;
//        static AboutUsPage _aboutUsPage;
//        static FaqsPage _faqsPage;
//        static ManageYourProfilePage _manageYourProfilePage;
//        static EditProfilePage _editProfilePage;
//        static TermsConditionsPage _termsConditionsPage;
//        static LearnAboutPricing _learnAboutPricingPage;
//        static PrivacyPolicyPage _privacyPolicyPage;
//        static PriceMedsResultsPage _priceMedsResultsPage;
//        static ChangePasswordPage _changePasswordPage;
//        static AskPharmacistPage _askPharmacistPage;
//        static PharmacyDrugInfoPage _pharmacyDrugInfoPage;
//        static OnBoardingPage _onBoardingPage;
//        static OnBoardingPageScanSave _onBoardingPageScanSave;
//        static OnBoardingPageGroceryGuidance _onBoardingPageGroceryGuidance;
//        static OnBoardingPriceMedsPage _onBoardingPriceMedsPage;
//        static OnBoardingTryBarcodeScannerPage _onBoardingTryBarcodeScannerPage;
//        static OnBoardingPriceMedsTeaserSavingsPage _onBoardingPriceMedsTeaserSavingsPage;
//        static OnBoardingBarcodeScannerPage _onBoardingBarcodeScannerPage;

//        public static OnBoardingBarcodeScannerPage OnBoardingBarcodeScannerPage => _onBoardingBarcodeScannerPage ?? (_onBoardingBarcodeScannerPage = new OnBoardingBarcodeScannerPage());
//        public static OnBoardingPriceMedsTeaserSavingsPage OnBoardingPriceMedsTeaserSavingsPage => _onBoardingPriceMedsTeaserSavingsPage ?? (_onBoardingPriceMedsTeaserSavingsPage = new OnBoardingPriceMedsTeaserSavingsPage());
//        public static OnBoardingTryBarcodeScannerPage OnBoardingTryBarcodeScannerPage => _onBoardingTryBarcodeScannerPage ?? (_onBoardingTryBarcodeScannerPage = new OnBoardingTryBarcodeScannerPage());
//        public static OnBoardingPriceMedsPage OnBoardingPriceMedsPage => _onBoardingPriceMedsPage ?? (_onBoardingPriceMedsPage = new OnBoardingPriceMedsPage());
//        public static OnBoardingPageGroceryGuidance OnBoardingPageGroceryGuidance => _onBoardingPageGroceryGuidance ?? (_onBoardingPageGroceryGuidance = new OnBoardingPageGroceryGuidance());
//        public static OnBoardingPage OnBoardingPage => _onBoardingPage ?? (_onBoardingPage = new OnBoardingPage());
//        public static OnBoardingPageScanSave OnBoardingPageScanSave => _onBoardingPageScanSave ?? (_onBoardingPageScanSave = new OnBoardingPageScanSave());
//        public static WelcomePage WelcomePage => _welcomePage ?? (_welcomePage = new WelcomePage());
//        public static CreateAccountPage CreateAccountPage => _createAccountPage ?? (_createAccountPage = new CreateAccountPage());
//        public static SavingsTeaserPage SavingsTeaserPage => _savingsTeaserPage ?? (_savingsTeaserPage = new SavingsTeaserPage());
//        public static TeaserSearchResultsPage TeaserSearchResultsPage => _teaserSearchResultsPage ?? (_teaserSearchResultsPage = new TeaserSearchResultsPage());
//        public static LogInPage LogInPage => _logInPage ?? (_logInPage = new LogInPage());
//        public static HomePage HomePage => _DashboardPage ?? (_DashboardPage = new HomePage());
//        public static MedicineChestPage MedicineChestPage => _medicineChestPage ?? (_medicineChestPage = new MedicineChestPage());
//        public static PriceMedicinePage PriceMedicinePage => _priceMedicinePage ?? (_priceMedicinePage = new PriceMedicinePage());
//        public static SavingscardPage SavingscardPage => _savingscardPage ?? (_savingscardPage = new SavingscardPage());
//        public static AboutUsPage AboutUsPage => _aboutUsPage ?? (_aboutUsPage = new AboutUsPage());
//        public static FaqsPage FaqsPage => _faqsPage ?? (_faqsPage = new FaqsPage());
//        public static ManageYourProfilePage ManageYourProfilePage => _manageYourProfilePage ?? (_manageYourProfilePage = new ManageYourProfilePage());
//        public static EditProfilePage EditProfilePage => _editProfilePage ?? (_editProfilePage = new EditProfilePage());
//        public static TermsConditionsPage TermsConditionsPage => _termsConditionsPage ?? (_termsConditionsPage = new TermsConditionsPage());
//        public static LearnAboutPricing LearnAboutPricing => _learnAboutPricingPage ?? (_learnAboutPricingPage = new LearnAboutPricing());
//        public static PrivacyPolicyPage PrivacyPolicyPage => _privacyPolicyPage ?? (_privacyPolicyPage = new PrivacyPolicyPage());
//        public static PriceMedsResultsPage PriceMedsResultsPage => _priceMedsResultsPage ?? (_priceMedsResultsPage = new PriceMedsResultsPage());
//        public static ChangePasswordPage ChangePasswordPage => _changePasswordPage ?? (_changePasswordPage = new ChangePasswordPage());
//        public static AskPharmacistPage AskPharmacistPage => _askPharmacistPage ?? (_askPharmacistPage = new AskPharmacistPage());
//        public static PharmacyDrugInfoPage PharmacyDrugInfoPage => _pharmacyDrugInfoPage ?? (_pharmacyDrugInfoPage = new PharmacyDrugInfoPage());

//        public static void Reset()
//        {
//            _welcomePage = null;
//            _createAccountPage = null;
//            _savingsTeaserPage = null;
//            _teaserSearchResultsPage = null;
//            _logInPage = null;
//            _DashboardPage = null;
//            _medicineChestPage = null;
//            _priceMedicinePage = null;
//            _savingscardPage = null;
//            _aboutUsPage = null;
//            _faqsPage = null;
//            _manageYourProfilePage = null;
//            _editProfilePage = null;
//            _termsConditionsPage = null;
//            _learnAboutPricingPage = null;
//            _privacyPolicyPage = null;
//            _priceMedsResultsPage = null;
//            _changePasswordPage = null;
//            _askPharmacistPage = null;
//            _pharmacyDrugInfoPage = null;
//            _onBoardingPage = null;
//            _onBoardingPageScanSave = null;
//            _onBoardingPageGroceryGuidance = null;
//            _onBoardingPriceMedsPage = null;
//            _onBoardingTryBarcodeScannerPage = null;
//            _onBoardingPriceMedsTeaserSavingsPage = null;
//            _onBoardingBarcodeScannerPage = null;
//        }
//    }
//}
