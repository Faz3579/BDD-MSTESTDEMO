Feature: Frequent Flyer status is calculated based on points
  As a Frequent Flyer member
  I want my status to be upgraded as soon as I earn enough points
  So that I can benefit from my higher status sooner

Scenario: New members should start out as BRONZE members
  Given user "Adam" is not a Frequent Flyer member
  When user "Adam" registers on the Frequent Flyer program
  Then user "Adam" should have a status of BRONZE

Scenario: Existing members status should be changed based on earned points
  Given "William" is a FrequentFlyer member
  And "William" has "90" status points
  When "William" earns "100" extra status points
  Then he should have a status of "Platinum"