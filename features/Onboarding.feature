Feature: OnBoarding

Scenario: OnBoarding - Verifying OnBoarding Slide1-3 TC001

    When I choose to move forward without an invite code
    Given I am on the onboard page
    Then I should see onboarding text as follows
    """
    Save up to 80% on brand-name and generic medications at your local pharmacies (more than 62,000 of them, nationwide).
    """
    When I swipe to next page
    Then I should see onboarding scan save page and text as follows
    """
    Scan the barcode on your food package to reveal its WellRx Health Index and discover “better for you” alternatives.
    """
    When I swipe to next page
    Then I should see the onboarding grocery guidance page and text as follows
    """
    Nutritional data science & AI personalization. Discover the food products in your grocery store that align with your nutritional goals.
    """
    When I select the continue link on the On Boarding pages

Scenario: OnBoarding - Verifying OnBoarding Skip for Now PriceMeds with Barcode Scanner Slide4-7 TC002

    When I choose to move forward without an invite code
    Given I am past the tutorial screens
    Then I should be on the Try Price Meds page
    When I select Skip For Now on the On Boarding pages
    Then I should be on the Try Barcode Scanning page
    When I select Skip For Now on the Barcode Scanner page
    And I choose Save to Dashboard
    Then I should be navigated to the home page

Scenario: OnBoarding - Verifying OnBoarding Try It Now PriceMeds with Barcode Scanner Slide4-7 TC003
  
    When I choose to move forward without an invite code
    Given I am past the tutorial screens
    Then I should be on the Try Price Meds page
    When I select Try It on the On Boarding pages
    Then I should be navigated to the teaser search page
    When I enter Zoloft as drug name without using the autocomplete
    When I enter 85032 in the zip code field
    And I choose to see savings
    Then I should be navigated to the onboarding teaser savings page
    When I select Continue on Teaser Savings page
   
 Scenario: OnBoarding - Verifying OnBoarding Try It Now with Barcode Scanner Slide4-7 TC004
 
    When I choose to move forward without an invite code
    Given I am past the tutorial screens
    Then I should be on the Try Price Meds page
    When I select Skip For Now on the On Boarding pages
    Then I should be on the Try Barcode Scanning page
    When I select Try It Now on the Barcode Scanner page
    Then I should be navigated to the onboarding barcode scanner page
    
 Scenario: OnBoarding - Verifying OnBoarding without Personalized Wellness TC036
 
    When I input an invite code that does not have Personalized Wellness
    Then I should see onboarding text as follows
    """
    Save up to 80% on brand-name and generic medications at your local pharmacies (more than 62,000 of them, nationwide).
    """
    When I swipe to next page
    Then I should be on the Manage Your Meds page
    When I select the continue link on the On Boarding pages
    Then I should be on the Try Price Meds page
    When I select Skip For Now on the On Boarding pages
    When I choose Save to Dashboard
    Then I should be navigated to the home page