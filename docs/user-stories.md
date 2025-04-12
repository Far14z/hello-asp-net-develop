#User Stories

this document contains technical stories for the "hello-asp-net-developers" REST API from the perspective of a developer interacting.

## TS001** Retrieve Greetings via GET Request

**As** a developer,
**I want to** retrieve a greeting message by providing optional first and last names,
**so that** I can test the API with both named and anonymous inputs.

### Acceptance Criteria
**Scenario 1: Anonymous Greeting**
  - **Given** a developer has not provided any names,
  - **When** the developer request aa greeting via GET,
  - **Then** the developer receives a response with the message "Welcome Anonymous ASP .NET Developer".
**Scenario 2: Personalized Greeting**
  - **Given** a developer has provided first and last names,
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with the message "Congrats {firstName} {lastName} ASP .NET Developer".
**Scenario 3: Partial Inputs**
  - **Given** a developer has provided only a first name,
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with the message "Welcome Anonymous ASP .NET Developer".
