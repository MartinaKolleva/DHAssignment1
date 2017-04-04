Feature: 2.Form
REQ-UI-01 – Moderate - The Title should be "UI Testing Site" on every site
REQ-UI-02 – Moderate - The Company Logo should be visible on every site
REQ-UI-05 – High - When I click on the Form button, I should get navigated to the Form page
REQ-UI-06 – Low - When I click on the Form button, it should turn to active status
REQ-UI-11 – High - On the Form page, a form should be visible with one input box and one submit button

@mytag
Scenario: Verify Form Page
Given I navigate to application
When I click on Form Button
Then Form button becomes active
And I am navigated to Form Page
And the Title is UI Testing Site
And the Company Logo is visible
And there is an Input Box
And there is a Submit Button