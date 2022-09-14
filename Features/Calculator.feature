Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](deletenow/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Navigation
Scenario: Navigation test
	Given I am on site 
	When I click Elements
	Then I am on Elements page

@ignore
Scenario: Generate Random email
	Given I have domain name as test@abc.com email
