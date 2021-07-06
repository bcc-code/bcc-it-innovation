# BCC Search

## Introduction
BCC Search is a set of services that provide a search experience with data from multiple platforms (persons, articles, litterature, audio, tv etc.).

This project is primarily intended as a technology playground - a place for testing ideas and innovating.


## Components

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


## Learning Goals

- [ ] Microfrontends - technologies, techniques
- [ ] Flutter - app development
- [ ] Microservice architecture
- [ ] Event driven architecture - messaging infrastructure
- [ ] Webhooks
- [ ] Autoscaling
- [ ] Vue.js - frontend development
- [ ] Tailwind UI - frontend component design
- [ ] Machine learning / AI
- [ ] Automated tests - cloudscale
- [ ] Analytics
- [ ] Terraform - Infrastructure deployement
- [ ] RavenDB - document, search database

## Teams
