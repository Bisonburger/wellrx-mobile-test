Feature: PriceMeds

Background:

Given I am on Price Meds page
     
Scenario: Price Meds - Learn About Pricing and Pricing Disclaimer Message TC043

    Then I should see pricing disclaimer message reads as
    """
    Results shown are for the most commonly dispensed form, strength and quantity for the drug you are searching. You can use the filters on the next screen to refine your search to better match your exact prescription.
    """
    When I select Learn About Our Pricing link
    Then I should be navigated to the About Our Pricing page   

Scenario: Price Meds - Drug Search bar validation and Map View TC044

    # This is not able to be tested since the debug build is prefilled with a drugname and zipcode
    # Then the search button should be disabled
    When I enter Pla in the mediciation field
    Then I should see a list of matching mediciations that starts with Pla  
    When I search plavix with 85711 zip code via autocomplete from the Price Meds page
    Then I should be navigated to the search results page
    And I should see a list of pharmacies
    When I switch to the Map View
    Then I should be navigated to the search results map view
    And I should be able to switch back to the list view

  Scenario: Price Meds - Search Result - Drug Info - Add to Medicine Chest TC045
  
    When I search plavix with 85711 zip code via autocomplete from the Price Meds page
    Then I should be navigated to the search results page
    When I select the any pharmacy in the results list
    Then I should be navigated to the pharmacy drug info page
    And I should have the option to add the medicine to my medicine chest
    When I select Add To Med Chest from the pharmacy page
    Then I should see the Add to Med Chest message
    When I select the toobar item of Medicine Chest
    Then I should be navigated to the medicine chest page with a list
    When I swipe to delete a Medications from Med Chest list

 Scenario: Price Meds - Search Result - Drug Info - Drug Details Page TC046
 
    When I search plavix with 85711 zip code via autocomplete from the Price Meds page
    Then I should be navigated to the search results page
    When I select the any pharmacy in the results list
    Then I should be navigated to the pharmacy drug info page
    When I select Todays Hours on Pharmacy Details
    And I select Savings Card Link on Pharmacy Details
    Then I should be on the expanded Savigs Card view
    When I select Peffered on Pharmacy Details
    Then I should see the Pharmacy Details message reads as
    """"
    Your preferred pharmacy was successfully updated.
    """"
    When I select Watch And Learn from the pharmacy page
    Then I should be on the Drug Videos page for Notfication details
    And I should have the options see the drug info in English or Spanish

 Scenario: Price Meds - Recent Search and Search History TC047
 
    When I search plavix with 85711 zip code via autocomplete from the Price Meds page
    And I select Save Search on Price Meds Result
    Then I should see Price Meds Result message reads as
    """"
    Search is saved successfully!
    """"
    When I select the toobar item of Price Medicine
    And I search ambien with 85258 zip code via autocomplete from the Price Meds page
    And I select the toobar item of Price Medicine
    When I select the mediciation name field
    Then I should see recent search section with following mediciations
    When I choose PLAVIX from recent search section
    Then I should see PLAVIX in the medication name field on Price Meds page
    When I select View Search History in Price Meds
    Then I should be navigated to the Search History in Price Meds
    When I swipe to Delete medication in View Search History
    Then I should see View Search History message reads as
    """"
    Your search has been deleted successfully!
    """"
    Given I Delete all Search History in View Search History

  Scenario: Price Meds - Search Result - Sort and Filter Options TC048
  
    When I search plavix with 85711 zip code via autocomplete from the Price Meds page
    Then I should be navigated to the search results page
    When I select Filter & Sort icon
    Then I should be navigated to the Filter & Sort view
    And I should see following options
    |Option|
    |Drug Type|
    |Dose Form|
    |Dose Strength|
    |Quantity|
 #  This has been temporarily removed
 #  |Sort|
    When I change all Filter & Sort options in Price Meds
    Then I should be navigated to the search results page