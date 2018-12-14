Feature: More Information


Background: 

    Given I am on the home page

Scenario: About Our Pricing - View Privacy Policy TC923

     Given I am on the About Our Pricing Page
     When I select View Privacy Policy tab
     Then I should be navigated to the Privacy Policy page

Scenario: Ask a Pharmacist - Terms Conditions TC909

    Given I am on the More Section Page
    When I am on the Ask a Pharmacist page
    And I select View Terms & Conditions from Ask a Pharmacist page
    Then I should be navigated to the Terms & Conditions page

Scenario: FAQs - Answer to Question TC920

   Given I am on the More Section Page
   When I am on the FAQs page
   And I select the first question on the list
   Then I should be navigated to its answer page

Scenario: Cantact Us - Submit Contact Us inquiry TC012

    Given I am on the More Section Page
    When I am on the Contact Us page
    And I submit a Contact Us inquiry
    Then I should see the Contact Us error message
    """
    Please enter a valid email address
    """
    When I Enter Contact Us contact information
    Then I should see the Contact Us error message
    """
    Please enter the Feedback
    """
    When I Enter Contact Us contact message
    Then I should see more menu options 

Scenario: About Us - About Us section TC013

     Given I am on the More Section Page
     When I am on the About Us page
     And I select Terms And Conditions
     Then I should be navigated to the Terms And Conditions page
     When I select View Privacy Policy
     Then I should be navigated to the Privacy Policy page
     When I select Learn More About MSC Link