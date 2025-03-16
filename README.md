# SaiPreethi.ch-ASP.NET-Assignment-Submission

**ASP.NET Order Processing Application**
**Project Overview**
This project is an ASP.NET MVC (or ASP.NET Core MVC) web application that implements business logic for processing customer orders. It calculates a discount based on the order amount and the customer type, providing an interactive and user-friendly interface for customers to enter their order details and see the result.

**Business Logic**
**Discount Calculation:**
If the order amount is $100 or more and the customer is marked as "Loyal," a 10% discount is applied.
If the order amount is below $100 or the customer is not "Loyal," no discount is applied.
**Features**
**Order Entry View:**
Customers can input their order amount and select their customer type (either "New" or "Loyal").
**Results View:**
The application displays the discount applied and the final order total.
Technical Requirements
ASP.NET Application:

Built using ASP.NET MVC or ASP.NET Core MVC framework.
Clean, user-friendly interface with two views: one for entering the order and one for displaying the results.
**Business Logic:**

The discount logic has been implemented accurately to match the provided scenario.
Edge cases such as exactly $100 and invalid inputs (non-numeric values) have been handled.
**Version Control (GitHub):**

The project has been hosted on GitHub.
A logical branching strategy has been followed, with a main branch and feature branches for development.
Commit messages are clear, descriptive, and follow best practices.
CI/CD Integration:

GitHub Actions has been set up for CI/CD pipelines.
The pipeline automatically runs automated tests upon commits to ensure the correctness of the business logic.
**Automated Testing:**

xUnit or a similar testing framework is used to test the discount logic, ensuring it functions as expected.
**Documentation:**

A README file has been provided, detailing the build, run, and test instructions.
The README also briefly describes the branching strategy and CI/CD setup.
Deliverables
Fully Functional ASP.NET Web Application:
Implements the order processing logic and user interface.
Public GitHub Repository:
The repository includes all project files (code, README, CI/CD configuration, tests, etc.).
The commit history is clear, and a logical branching strategy has been followed.
CI/CD Pipeline Integration:
The pipeline ensures that automated tests are run on each commit.
**README File:**
Includes setup instructions, project structure, and an overview of the project.
GitHub Repository Structure
Controllers/ - Contains the MVC controllers for handling business logic.
Views/ - Contains the MVC views for rendering the user interface.
Models/ - Contains models for processing order data (though no database used).
wwwroot/ - Contains static assets like CSS, JavaScript, and images.
Tests/ - Contains unit tests to validate the business logic (discount calculation).
.github/ - GitHub Actions configurations for CI/CD pipeline.
**Branching Strategy**
main: The production-ready branch containing the final working code.
feature/order-entry: A feature branch for developing the order entry page.
feature/results-page: A feature branch for developing the results page.
test/discount-logic: A branch for implementing and testing the discount calculation logic.
How to Build and Run
Clone the repository from GitHub:
_**git clone https://github.com/yourusername/aspnet-order-processing.git**_
Open the solution in Visual Studio or your preferred IDE.
Build the solution.
Run the application using IIS Express or another web server.
Navigate to /OrderEntry to enter an order and /OrderResults to view the results.
Automated Tests
The project uses xUnit for unit testing the business logic.
To run the tests locally, you can use:_
**dotnet test**_
