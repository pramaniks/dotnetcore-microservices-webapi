# dotnetcore-microservices-webapi

**Many of you heard of DDD (Domain Driven Design) but like most other material on architecture, they offer insight and paradigms but are but not a straightforward methodology to create architecture that is easy to teach and follow over time.**

>If you think good architecture is expensive, try bad architecture”


# Define the services:
* **There are exactly 5 types of services:**
  * Client — Handles communication with client, no business logic (e.g. REST controller) — who is making the request
  * Manager — Orchestrated business use cases, define the workflow — what needs to be done
  * Engine — Executes business logic — how to implement an activity
  * Resource Access — encapsulates accessing resources (e.g. DB, REST endpoint) — where do I get data from
  * Utility — Cross-cutting concern that is not specific to our business logic (could be used in a coffee machine)

# Conceptual design:
![static-diagram2](https://user-images.githubusercontent.com/20775313/116518672-2f0d0f80-a8ee-11eb-8265-26a97bac848e.jpg)

# Few rules:
There are a couple of different rule sets on how to communicate between these services:
* Flow control only goes from top to bottom
(client → Manager → Engine (optional)→Resource Access)
* Each Service can access any service, as long as it’s top to bottom
* Manager can call other managers but only by triggering an action (asynchronous)
* Every service can access any utility service
* Each service should be independent (potentially a microservice), this means that for instance, it has to have it’s own business objects
* Having only 5 types of services with a clear scope for each is very powerful. It creates a common language when talking about components and makes it very clear to understand responsibilities and boundaries.
* The constraints on who can call whom and how helps with removing coupling and reducing complexity.
