# BCC IT Innovation

## Introduction
The purpose of this repository is to facilitate collective learning of new techniques, technologies and exploration of ideas during Innovation Days.


## Innovation Days - Summer 2021


### Topics
1. **Terraform** - infrastructure deployment automation
2. **Microfrontends** - independently deployable UI modules
3. **Vue.js** - front-end app development
4. **Tailwind** - front-end UI development
5. **Microservices** - modular, event driven architecture
6. **Flutter** - cross-platform app development
7. **Webhooks** - public event APIs
8. **ML/AI** - artificial intelligence
9. **Automated Testing** - cloud scale
10. **Hasura** - Real time GraphQL
11. **RavenDB** - Document database
12. **GO** - Programming language


### Reference Architecture: Search Sevice
As a teaser / use case for experimenting with the above topics, a reference microservice-based architecture for a multi-source search service has been provided. (See "search" folder)

![image](https://user-images.githubusercontent.com/1876625/124805543-f2980880-df5b-11eb-9217-e1261e6838e0.png)


#### Components

* **app** - flutter based mobile app
* **ui** - microfrontend UI for search
* **services** - core backend search services
  - **search-api** - main "process api" that coordinates searches
  - **search-api-hooks** - a webhook adapter used for exposing search and content events to other (3rd party) systems
  - **search-content** - the core service for storing document content and performing keyword search. Provides an API for external systems to push their content.
  - **search-content-permissions** - service which determines which content a specific user has access to. This is used by search-content and search-enrichment services to filter results.
     The service implements a rules engine as well as allowing permission checks to be delegated to 3rd party services.
  - **search-enrichtment** - AI powered service which enriches the search experience by discovering _related content_ and suggesting search phrases based on previous searches
  - **search-log** - a simple log of searches performed, and ideally the types of profiles that perfomed these searches. Used as input to the search-enrichment service, and also as a lookup for "my searches" etc.
* **providers** - content provider services, that push content to the search-content service. These may be scheduled tasks or event-triggered cloud functions.



#### Open Source References for Inspiration

[Meilisearch](https://www.meilisearch.com)

#### Third Party

[Elastic Enterprise Search](https://www.elastic.co/enterprise-search)

[Algolia](https://www.algolia.com)

