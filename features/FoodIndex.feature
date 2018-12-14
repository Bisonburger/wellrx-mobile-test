Feature: FoodIndex
  As a user, I should be able to search for food items to match my health conditions
  
 Background:

    Given I am on the home page
    When I select the toobar item of Food Index

Scenario: Food Index - Food Index View Favorites Section TC005
    
    When I select the Search Product from Food Index
    And I search for a food item with 702014604631
    Then I should be on the food details summary tab
    When I select the Favorite Star for a food item
    When I select the toobar item of Food Index
    And I select Favorites Products in Food Index
    Then I should be on the Food Index Favorites page
    When I select Sort in Favorites for Food Index
    Given I select a Food Item in Favorites
    When I swipe to remove food item in Favorites
    Then I should see Favorites list is empty message

Scenario: Food Index - More Details Section TC006

    Then I should be on the food index page
    When I select the More Details from Food Index
    Then I should be on the More Details prompt

Scenario: Food Index - Scan Product Section TC007

    When I select the Scan Product from Food Index
    Then I should be on the Scan Product page
    When I select Search Product button
    Then I should be on the Search Product page
    When I select Scan Barcode from Food Index
    Then I should be on the Scan Product page

Scenario: Food Index = Product Search Summry tab TC008

    When I select the Search Product from Food Index
    And I search for a food item with 702014604631
    Then I should be on the food details summary tab
    And I should see food details summary tab Circular Graph
    When I select Label Information
    Then I should see the Nutrition Facts
    When I scroll to the Better For Me View More
    Then I should see Better For Me Options

Scenario: Food Index = Product Search Food Index tab TC009

    When I select the Search Product from Food Index
    And I search for a food item with 702014604631
    And I select the Food Index tab
    Then I should be on the Food Index Tab
    When I select How Is This Generated button
    Then I should be on the Food Index Calculation page
    When I scroll to the All Conditions View
    And I select the Condition Picker
    Then I should be on the lower part of Food Index

Scenario: Food Index = Product Search Nutrition tab TC010

    When I select the Search Product from Food Index
    And I search for a food item with 702014604631
    And I select the Nutrition tab
    Then I should be on the food details Nutrition tab
    When I select Complete Label Information
    Then I should see the Complete Nutrition Facts

Scenario: Food Index - Product Search Better For Me tab TC011

    When I select the Search Product from Food Index
    And I search for a food item with 702014604631
    And I select the Better For Me tab
    Then I should be on the food details Better For Me tab
    When I select the Better For Me View More options
    Then I should be on the food details Better For Me tab
    When I select the Better For Me Food item
    Then I should be on the food details summary tab
    
Scenario: Food Index = Product Search Summry View More Options TC037

    When I select the Search Product from Food Index
    And I search for a food item with 702014604631
    When I select Nutrition Facts View More option
    Then I should be on the food details Calorie Breakdown
    When I select the Summary tab
    And I select Better For Me View More
    Then I should be on the food details Better For Me tab