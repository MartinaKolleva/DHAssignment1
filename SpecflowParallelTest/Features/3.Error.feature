Feature: 3. Error
REQ-UI-07 – High - When I click on the Error button, I should get a 404 HTTP response code 

@mytag
Scenario: Verify Error Page
Given I navigate to application
When I click on Error Button
Then I get HTTP error
