Feature: 5. Hello 
REQ-UI-12 – High - On the Form page, if you type <value> the input field and submit the form, you should get redirect to the Hello page, and the following text should appear: <result>
@mytag

Scenario Outline: Verify Hello
Given I navigate to application
And I click on Form Button
And I type <Value>
And I click Submit Button
Then I am navigated to Hello Page
Then <Result> is shown
And the Title is UI Testing Site
And the Company Logo is visible

Examples: 
|Value		|   Result|	
|John      |   Hello John!|
|Sophia    |   Hello Sophia!|
|Charlie   |   Hello Charlie!|
|Emily     |   Hello Emily!|
