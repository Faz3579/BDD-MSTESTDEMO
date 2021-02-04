#### CVS Health - DevSecOps Software Engineering - POC on Behavior Driven Development (BDD) for .NET using SpecFlow Frame work, MSTestTest Plans, dotCover and ReSharper.

#### Behavior Driven Development (BDD):

Behavior-Driven Development (BDD) is a set of software engineering practices designed to help teams build and deliver more valuable, higher quality software faster. It draws on Agile and lean practices including test-driven Development (TDD) and Domain-Driven Design (DDD). But most importantly, BDD provides a common language based on simple, structured sentences expressed in English (or in the native language of the stakeholders) that facilitate communication between project team members and business stakeholders.

#### Gherkin:

Gherkin is the format for cucumber specifications. It is a domain specific language which helps you to describe business behavior without the need to go into detail of implementation. This text acts as documentation and skeleton of your automated tests. Gherkin is based on Treetop Grammar which exists in 37+ languages. Therefore, you can write your gherkin in 37+ spoken languages.

#### syntax:
    Given- When- Then
    •   Given: Some given context (Preconditions).
    •   When : Some Action is performed (Actions).
    •   Then : Particular outcome/consequence after the above step (Results).
    
#### SpecFlow:

SpecFlow is inspired by Cucumber framework in the Ruby on Rails world. Cucumber uses plain English in the Gherkin format to express user stories. Once the user stories and their expectations are written, the Cucumber gem is used to execute those stores. SpecFlow brings the same concept to the .NET world and allows the developer to express the feature in plain English language. It also allows to write specification in human-readable Gherkin Format.

#### MSTest:

MSTest is one type of framework that provides the facility to test the code without using any third-party tool. It helps in writing effective unit tests using MSTest framework to test software applications.
https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest

#### dotCover:

dotCover is a . NET unit testing and code coverage tool that works right in Visual Studio and in JetBrains Rider, helps you know to what extent your code is covered with unit tests, provides great ways to visualize code coverage, and is Continuous Integration ready.
https://www.jetbrains.com/dotcover/documentation/


#### Introduction:

This project is to give an overview of BDD test automation Project for .NET using the SpecFLow framework. It contains a simple behavior scenarios that has My Flying High Website(Earn&View Points, check user status, Earned Points of user). To test a feature the developer writes a step definition file which is then run by SpecFlow to test each scenario.

This project consists of .NET files which will give an idea of how  MSTest work with BDD framework.

MSTest framework is used for Unit-testing.

SpecFLow framework is used for BDD.

BDD Features implemented in this project
The following feature was implemented in this project:

    Feature :  Frequent Flyer status is calculated based on points As a Frequent Flyer member I want my status to be upgraded as soon as I earn enough points So that I can benefit from my higher status sooner

    Scenario : New members should start out as BRONZE members Given user is not a Frequent Flyer member When user registers on the Frequent Flyer program Then user should have a status of BRONZE

    Scenario Outline : Given "William" is a "initialStatus" FrequentFlyer member And "William" has "initialStatusPoints" status points When he earns "extraPoints" extra status points Then he should have a status of "finalStatus"

    Examples : Status points required for each level | initialStatus | initialStatusPoints | extraPoints | finalStatus | | Bronze | 0 | 300 | Silver | | Bronze | 100 | 200 | Silver | | Silver | 0 | 699 | Gold | | Gold | 0 | 1500 | Platinum |

#### Tech Stack:
    C#       :: .NET Core

    SpecFlow :: SpecFlow is the #1 .NET open-source framework for Behavior Driven Development, Acceptance Test Driven Development and Specification by Example. Helps teams bind automation to feature files and share the resulting examples as Living Documentation across the team and stakeholders.

    Gherkin  :: It is the Given-When-Then spec language.

    MSTest   :: MSTest is a number-one open-source test framework that is shipped along with the Visual Studio IDE. It is also referred to as the Unit Testing Framework.
    
    dotCover :: Code Coverage tool

    IDE      :: Visual Studio, Visual Studio Code.
    
#### Extensions:
    SpecFlow for Visual Studio 2019

#### Packages/Dependencies:

    jetbrains.dotCover.CommandLineTools(2020.3.2)
    jetbrains.dotCover.DotNetCliTool(2020.3.2)
    Microsoft.NET.Test.Sdk(16.40)
    MSTest.TestAdapter(2.12)
    MSTest.TestFramework(2.1.2)
    SpecFlow.Assit.Dynamic(14.2)
    SpecFlow.Nunit(3.5.14)
    SpecFlow.Tools.MsBuild.Generation(3.5.14)
    
#### Code Structure:
    Feature                      :: Contains feature files which are written in gherkin scripts 

    Model/Response.cs            :: Contains response object properties 

    Model/UserDetails.cs         :: Contains user properties like (user name, reward points, status etc) .

    Sevice/FrequenService.cs     :: Contains services for making changes to user profiles .

    Steps/                       :: Contains MSTest step definitions which follow BDD approach

#### How to use this project:
    #To buid code 
    dotnet run build

    #To run actual test plans 
    dotnet run test
    
    
    
#### Frequently Asked Questions

#### What are “step definitions” in SpecFlow?

The step definitions provide the connection between your feature files and application interfaces. For better reusability, the step definitions can include parameters. This means that it is not necessary to define a new step definition for each step that just differs slightly. For example, the steps When I perform a simple search on 'Domain' and When I perform a simple search on 'Communication' can be automated with a single step definition, with ‘Domain’ and ‘Communication’ as parameters.

#### How long should Gherkin scenarios be?

Scenarios should be bite-sized. Each scenario should focus on one individual behavior. There’s no hard rule, but I recommend single-digit step counts.

#### Can BDD test frameworks be used for unit testing?

Yes, but I don’t recommend it. BDD frameworks shine for black-box feature testing. They’re a bit too verbose for code-level unit tests.

#### What is White Box Testing?

White box testing focuses on activities that require you to actually know the underlying source code of a program. Because the developer has written the code, he or she should understand it and have the ability to modify and test the actual code directly.

#### What is Black Box Testing?

Black box testing is the opposite. When performing black box testing activities, you are treating the program as a literal black box — meaning that you can't see into the actual source code of a feature, nor would you necessarily understand the underlying code of a particular feature. You act is if you have no idea how the program should work.

#### How many Gherkin scenarios should one story have?

There’s no hard rule, but I recommend no more than a handful of rules per story, and no more than a handful of examples per rule. If you do Example Mapping and feel overwhelmed by the number of cards for a story, then the story should probably be broken into smaller stories.

#### Can BDD be used with manual testing?

Yes! BDD is not merely an automation tool – it is a set of pragmatic practices to help teams develop better software. Gherkin scenarios are first and foremost behavior specs that help a team’s collaboration and accountability. They function secondarily as test cases that can be executed either manually or with automation.

#### How is BDD different from TDD (Test-Driven Development)?

BDD is an evolution of TDD. In TDD, developers (1) write unit tests and watch them fail, (2) develop the feature to make the tests pass, (3) refactor the code to make it stronger, and (4) repeat the cycle. In BDD, teams do this same loop with feature tests (a.k.a “acceptance” or “black-box” tests) as well as unit tests.

#### What is the difference between a scenario and a scenario outline?

A scenario is a procedure of Given-When-Then steps that covers one example for one behavior. If there are any parameters for steps, then a scenario has exactly one combination of possible inputs. A scenario outline is a Given-When-Then procedure that can have multiple examples of one behavior provided as a table of input combos. Each input row will run the same steps once, just with different parameter inputs.

#### In Gherkin, is it good or bad practice to have multiple Scenario Outlines with Examples tables in one feature file?

The short answer is yes, it is perfectly fine to have multiple Scenario Outlines within one feature file. 

However, the unspoken concern with this question is the potential size of the feature file. If one Feature has multiple Scenario Outlines with large feature tables, then the feature file could become unreadable. Remember, Gherkin is a specification language, not a programming language. A feature file should look more like a meaningful behavior example than a giant wall of text or a low-level test script. Make sure to follow good Gherkin guidelines:

    1.Follow the Golden Gherkin Rule: Treat other readers as you would want to be treated.
    2.Follow the Cardinal Rule of BDD: One scenario, one behavior.
    3.Write declarative steps, not imperative ones.
    4.Try to limit the number of steps in each scenario to single digits.
    5.Use only a few rows and columns per example table.

#### ARE GHERKIN SCENARIOS WITH MULTIPLE WHEN-THEN PAIRS OKAY?

One of the dead giveaways to violations of the Cardinal Rule of BDD is when a Gherkin scenario has multiple When-Then pairs, like this:

    Feature: Yahoo Searching 
    Scenario: Yahoo Image search shows pictures 
    Given the user opens a web browser 
    And the user navigates to "https://www.yahoo.com/" 
    When the user enters "CVS" into the search bar 
    Then links related to "CVS" are shown on the results page 
    When the user clicks on the "Images" link at the top of the results page 
    Then images related to "CVS" are shown on the results page

    A When-Then pair denotes a unique behavior. In this example, the behaviors of performing a search and changing the search to images 
    could and should clearly be separated into two scenarios, like this:
    
    Feature: Yahoo Searching 
    Scenario: Search from the search bar 
    Given a web browser is at the Yahoo home page 
    When the user enters "CVS" into the search bar 
    Then links related to "CVS" are shown on the results page 
    
    Scenario: Image search 
    Given Yahoo search results for "CVS" are shown 
    When the user clicks on the "CVS" link at the top of the results page 
    Then images related to "CVS" are shown on the results page


#### No Double-Quotes Around Step Parameters

How do you know if something is a step parameter? “Double quotes” make it easy. However, Gherkin does not enforce double quotes around parameters. It is merely by programmer’s convention, but it’s a really helpful convention indeed.####No Tags make it super easy to filter scenarios at runtime. No tags? Good luck remembering long paths and names at runtime, or running related scenarios across different feature files together.

#### More Than 10 Steps per Scenario

Again, any longer is too much to comprehend. Scenarios should be short and sweet – they should concisely describe behavior. Too many steps means the scenario is too imperative or covers more than one behavior.

#### Multiple Behaviors per Scenario

Scenarios should not have multiple personality disorder: one scenario, one behavior. Don’t break the Cardinal Rule of BDD! So many people break this rule when they first start BDD because they are locked into procedure-driven thinking. Then, when tests fail, nobody knows exactly what behavior is the culprit. One scenario, one behavior.

#### Difference between Unit Testing vs BDD

The difference is that while JUnit aims at tests, Cucumber aims at collaboration with non-technical people. Non technical people will not understand what a unit test does. They will, however, be able to understand and validate an example written in Gherkin.
