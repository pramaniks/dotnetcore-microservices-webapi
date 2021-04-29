# dotnetcore-microservices-webapi

**Many of you heard of DDD (Domain Driven Design) but like most other material on architecture, they offer insight and paradigms but are but not a straightforward methodology to create architecture that is easy to teach and follow over time.**

In the words of Brian Foote and Joseph Yoder
>If you think good architecture is expensive, try bad architecture”


# Define the services:
* **There are exactly 5 types of services:**
  * Client — Handles communication with client, no business logic (e.g. REST controller) — who is making the request
  * Manager — Orchestrated business use cases, define the workflow — what needs to be done
  * Engine — Executes business logic — how to implement an activity
  * Resource Access — encapsulates accessing resources (e.g. DB, REST endpoint) — where do I get data from
  * Utility — Cross-cutting concern that is not specific to our business logic (could be used in a coffee machine)
