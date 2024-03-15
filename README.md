# SimpleTicketBookingCoreTDD
Implement TDD in .NET web application.

Test-Driven Development, or TDD for short, is a method used to write tests before we start our implementation. Before you start, you might list the requirements that need to be fulfilled in your application.
Then you take the first requirement and write a failing test. The test fails and it is RED as you haven’t developed it yet. But the test describes already what your code should do to fulfill the requirement. Now you need to make the test GREEN by writing the necessary code to make the test pass. After you write the code to make the test green you need to Refactor the code. Maybe you can simplify the code or extract a few code lines into a method to make the code more readable and maintainable. After you are done with the first requirement, you can continue with the next requirement. This means you iterate the entire cycle (Red -> Green -> Refactor) for another requirement and so on. So the tests are driving your development. This is the heart of TDD and is known as the TDD cycle.

TDD means writing tests to implement a requirement and continuously iterate through RED GREEN and REFACTOR cycles.

# Advantages of Test-Driven Development
TDD makes you think about the needed API from the beginning. You need to think about what classes, properties, and APIs are needed. This will usually lead to great API design.
After you know the class and properties, another big advantage is that you need to think about what the code should do rather than how it should be done. As you start with the test you don’t need to have any idea about implementation. You just need to write a test for what the code should do. After writing the test you can think of requirements and their development.
While thinking of your requirements, you get quick feedback about your requirements by running the test. The fact that you get quick feedback means you even don’t need a fully working application at all. You just need a class library to build your business logic and don’t need the entire project.
This helps you create modular code. You can decouple the dependencies from the beginning and TDD makes you do that from the beginning. This decoupling of dependency makes you write modular code by isolating the dependencies like a database that is not ready yet and the web API isn't ready when beginning the development.
This leads to a maintainable codebase, as you will have one test per requirement. You can write code to add new functionality and run all the unit tests to ensure that the existing code doesn’t break. You can be confident about your new code as well as the existing code.
These tests will serve as good documentation. For example, the test for the code written by others will help you understand why the code has been written.

# Disadvantage of Test-Driven Development
The only disadvantage is that TDD is not so easy to start by writing tests for beginners. In fact, TDD is an art that every developer should master.

# Scenario

Let’s take a simple scenario where a user needs to book a ticket. The user needs to fill out a form with basic details to book the ticket.

# Understand the First Requirement
The user will submit a form to book a ticket which will make a call to TicketBookingRequestProcessor to book a ticket. The processor must return the same data after the booking is successful. To do this let's first think of the API. The TicketBookingRequestProcessor will use Book to book a ticket and it will receive TicketBookingRequest as input and return TicketBookingResponse as a result.

This simple requirement is good to start with TDD.

1- Create a new C# XUnit test project named TicketBookingCore.Tests.(install FluentAssertion Nuget package)
2- As you need to test TicketBookingRequestProcessor Class, create a new class named TicketBookingRequestProcessorTests.
3- Create a first test method as ShouldReturnTicketBookingResultWithRequestValues.
4- Mark the method with the [Fact] attribute to indicate it as a test.
