Feature: Medicine Chest

 Background:

    Given I am on the home page
    When I select the toobar item of Medicine Chest
    And I need to dissmiss the Med Chest swipe Tutorial
            
Scenario: Medicine Chest - Medicine Chest Life Style, Pharmacist and Share TC042

    Then I should be navigated to the medicine chest page
    And I should see empty chest message
    When I add a secound Medication of Apokyn for Med Chest
    And I need to dissmiss the Med Chest swipe Tutorial
    Given I select Pharmacist Button from Med Chest
    When I select a Medication from Med Chest
    Then I should be on the med chest Medication Details page
    When I select the tab for Med Chest details of Information
    When I select a card for Med Chest Notfication details of Information Cards Four
    Then I should be on the Life Style Interaction page for Notfication details
    When I Delete a medication from Med Chest details
    Then I should see empty chest message
    
Scenario: Medicine Chest - Import section validation TC026

    Then I should be navigated to the medicine chest page
    When I select the Add Medications Button
    And I select the Med Chest Import Option
    
Scenario: Medicine Chest - Add Medication Manual Entry Pill Reminder TC027

    Then I should see empty chest message
    When I add a Medications for Med Chest
    And I select Pill Reminder from Med Chest Manual Entry
    Then I should be on the Pill Reminder page
    When I toggle the Toggle Switch
    And I fill out Pill Reminder information
    And I save the Reminder selections
    When I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    And I should see the Bell notfication icon
    When I swipe to delete a Medications from Med Chest list
    
Scenario: Medicine Chest - Add Medication Manual Entry Refill Reminder TC028

    Then I should see empty chest message
    When I add a Medications for Med Chest
    And I select Refill Reminder from Med Chest Manual Entry
    Then I should be on the Refill Reminder page
    When I toggle the Toggle Switch
    When I fill out Refill Reminder information
    And I save the Reminder selections
    When I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    And I should see the Pill List Refill notfication icon
    When I swipe to delete a Medications from Med Chest list
    
 Scenario: Medicine Chest -  Medicine Chest View Archive section TC029

    When I add a Medications for Med Chest
    And I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    When I swipe to Archive a Medications from Med Chest list
    And I select View Archive Button from Med Chest
    Then I should be on the Med Chest Archive page
    When I swipe to Restore a Medications from Med Chest Archive list
    Then I should see the Med Chest Archive empty message
    When I Archive a Medications from Med Chest details
    And I select View Archive Button from Med Chest
    And I select Delete All in the Archive Section
    Then I should see the Med Chest Archive empty message
    
Scenario: Medicine Chest -  Medicine Chest Reprice section TC030

    When I add a Medications for Med Chest
    And I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    When I add a secound Medication of Apokyn for Med Chest
    Given I validate the full Repricing Section
    Then I should see empty chest message
    
 Scenario: Medicine Chest -  Medicine Chest Medication Details section TC031
 
    Given I am on Medication Details for Med Chest
    When I change Medications information for Med Chest details
    And I select Save Changes for Med Chest details
    Then I should see Med Chest details message reads as
    """"
    Your changes have been saved
    """"
    When I Delete a medication from Med Chest details
    Then I should see empty chest message
    
Scenario: Medicine Chest -  Medicine Chest Notfication Details section TC032

    Given I am on Medication Details for Med Chest
    When I select the tab for Med Chest details of Notifications
    And I select Pill Reminder for Med Chest Notifications Tab
    When I select Refill Reminder for Med Chest Notifications Tab
    And I select Save Changes for Med Chest details
    Then I should see Med Chest details message reads as
    """"
    Your changes have been saved
    """"
    When I Delete a medication from Med Chest details
    Then I should see empty chest message
    
Scenario: Medicine Chest -  Medicine Chest Information Details section TC033

    Given I am on Medication Details for Med Chest
    When I select the tab for Med Chest details of Information
    Then I should be on the med chest Medication Details Notfication tab
    When I select a card for Med Chest Notfication details of Information Cards One
    Then I should be on the Drug Content page for Notfication details
    When I select a card for Med Chest Notfication details of Information Cards Two
    Then I should be on the Drug Videos page for Notfication details
    When I select a card for Med Chest Notfication details of Information Cards Three
    Then I should be on the Drug Images page for Notfication details
    When I Delete a medication from Med Chest details
    Then I should see empty chest message
    
Scenario: Medicine Chest -  Medicine Chest View Medication Interactions TC034

    When I add a Medications for Med Chest
    And I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    When I add a secound Medication of Thrombate iii for Med Chest
    And I select View Interactions from Med Chest
    Then I should be on the Drug Interactions page
    And I should see empty chest message
    
Scenario: Medicine Chest - Medicine Chest Share options section TC040

    Then I should see empty chest message
    When I add a Medications for Med Chest
    And I select Pill Reminder from Med Chest Manual Entry
    Then I should be on the Pill Reminder page
    When I toggle the Toggle Switch
    And I save the Reminder selections
    When I select the Add Medications Button with additional checks
    Then I should be navigated to the medicine chest page with a list
    When I select the Share icon on the Med Chest Page
    Given I validate the full Share section in Med Chest
    When I swipe to delete a Medications from Med Chest list