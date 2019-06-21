Feature: DeleteUserFeature
	In order delete a user by Id
	As a API consumer
	I want to be to delete a user's information through the API

Scenario: Deleting user by Id
	Given that a user exists in the system
	When I request to delete the user by Id
	Then the user should be deleted
	And the response status code is '200 OK'

Scenario: Deleting non-existing user by Id
	Given that a user does not exist in the system
	When I request to delete the user by Id
	Then the response status code is '404 Not Found'
