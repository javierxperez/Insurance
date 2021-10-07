## Quote-API


# Setup

To run the API please do the following:

1) Set Quote.API as the startup project
2) Run the API in your favorite browser or IIS Express 
3) Open up Postman
4) Create a Post request with the endpoint http://localhost:22008/api/v1/quotes/createQuote (Port number may differ please use your project port number when the API is ran)
5) Set the body to use raw JSON.
6) Populate the request body and click Send.

# Example
Request:
{
    "revenue": 10000000,
    "state": "FL",
    "business": "Plumber"
}

Response:
{
    "premium": 24000
}


# Future State
In the future I would implement the following:

1)Authentication would be the first thing I would implement, I would implement this using JWT Authentication or OAuth depending on what makes the most sense . I would add an endpoint to pass in credentials and return back a bearer token if the credentials match what we have in the DB/key vault. This bearer token would be used as part of the authorization header for other requests


2)Enable Authorize on the endpoints, once Authentication has been implemented we would want to deny access to those who don't have proper credentials.


3)Currently this API does not have any kind of documentation for developers to refer to, I am familiar with Swagger, so I would implement Swagger to self document the endpoints and add all necessary components needed to stand it up.


4)Unit Tests play an important role in testing code as part of a build, I would create a Unit test project where I would mock the controller and create tests for various situations


5)We would want to setup a CI/CD pipeline once the project is complete, if we are using AZDO, we can create a build and release pipeline to build the artifacts, run unit tests, and deploy our code to a lower environment first.

6)If we wish to deploy to the cloud we can have a PAAS solution in which we create an Web App/App Service and link it to our release pipeline to deploy our API to. Otherwise we could use some other form of orchestration like using containerized instances.
