Feature: Teaser Search



 Scenario: Teaser Search - Search Savings - Autocomplete TC747
    Given I am on the teaser search page
    When I search plavix with 85711 zip code via autocomplete options
    Then I should be navigated to the teaser search results page

 Scenario: Teaser Search - Search Savings - No Autocomplete TC737
    Given I am on the teaser search page
    When I enter plavix as drug name without using the autocomplete
    Then I should be navigated to the teaser search page
    And I should see plavix in the medication field
    When I enter 85711 in the zip code field
    And I choose to see savings
    Then I should be navigated to the teaser search results page

 Scenario: Teaser Search - Invalid Zipcode TC745
    Given I am on the teaser search page
    When I attempt to search plavix with invalid zip code
    Then Let's See The Savings button should be disabled

 Scenario: Teaser Search - Invalid medication TC746
    Given I am on the teaser search page
    When I attempt to search invalid drug with valid zip code
    Then I should be prompt with message reads as
    """
    There are no pharmacies available for 'invalid'. Please try again with a different location or drug.
    """

Scenario: Teaser Search - No Thanks TC738
    Given I am on the teaser search page
    When I choose not to search savings
    Then I should be navigated to the savings card page

    #These tests are no longer valid due to code changes
#Scenario: Teaser Search Result - Create an account - Yes TC740
#   Given I am on the teaser search results page
#    When I choose Yes on create an account
#    Then I should see email validation message
#    When I enter abc@yahoo.com in the email field
#    And I select Yes from teaser search results page
#    Then I should be navigated to the create account page

# Scenario: Teaser Search Result - Create an account - No Thanks TC739
#    Given I am on the teaser search results page
#    When I choose No Thanks on create an account
#    Then I should be navigated to the savings card page

# Scenario: Teaser Search Result - Email Field Validation TC748
#    Given I am on the teaser search results page
#    When I enter abc.com in the email field
#    When I choose Yes on create an account
#    Then I should see email validation message