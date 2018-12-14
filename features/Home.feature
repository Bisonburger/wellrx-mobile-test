Feature: Home
    

Scenario: Home Page - Bottom Tab Menu Navigation TC1187

    Given I am on the home page
    When I select the toobar item of Medicine Chest
    Then I should be navigated to the medicine chest page
    When I select the toobar item of Price Medicine
    Then I should be navigated to the price medicine page
    When I select the toobar item of Food Index
    Then I should be on the food index page
    When I select the toobar item of More
    Then I should be on the more page


Scenario: More Menu - Navigation - About Us TC922

    Given I am on the home page
    When I select the toobar item of More
    Then I should see more menu options
    When I choose About Us
    Then I should be navigated to About Us page

Scenario: More Menu - Navigation - FAQs TC918

    Given I am on the home page
    When I select the toobar item of More
    Then I should see more menu options
    When I choose FAQs
    Then I should be navigated to FAQs page
    
Scenario: Home Page - Bottom Tab Menu Navigation Non Personalized Wellness TC038

    Given I am on the home page with a Non Personalized Wellness account
    Then I should not see the Food Index tab
    When I select the toobar item of Medicine Chest
    Then I should be navigated to the medicine chest page
    When I select the toobar item of Price Medicine
    Then I should be navigated to the price medicine page
    When I select the toobar item of More
    Then I should be on the more page
