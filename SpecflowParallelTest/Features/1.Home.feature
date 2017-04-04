Feature: Home 
REQ-UI-01 – Moderate - The Title should be "UI Testing Site" on every site
REQ-UI-02 – Moderate - The Company Logo should be visible on every site
REQ-UI-03 – High - When I click on the Home button, I should get navigated to the Home page
REQ-UI-04 – Low - When I click on the Home button, it should turn to active status
REQ-UI-09 – Low - The following text should be visible on the Home page in <h1> tag: "Welcome to the Docler Holding QA Department"
REQ-UI-10 – Low - The following text should be visible on the Home page in <p> tag: "This site is dedicated to perform some exercises and demonstrate automated web testing."


@mytag
Scenario: Verify Home Page
Given I navigate to application
When I click on Home Button
Then Home button becomes active
And I am navigated to Home Page
And the Title is UI Testing Site
And the Company Logo is visible
And Welcome text is displayed
And Description text is in p tag