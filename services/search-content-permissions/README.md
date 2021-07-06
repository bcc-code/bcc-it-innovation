# BCC Search Content Permissions API

## Introduction
The content permissions API implements the rules engine required to determine whether a user has permission to see content in search results.

Each document in the search-content database is stored with a permissions ruleset. This might be a simple as "public", but could also be limited to 
attributes that can be determined from user claims (e.g. country, organization etc.).

In addition, to support more complex permission scenarios, a permission rule may specify that the permission check needs to be delegated (sent to another service).
In this case, the permissions API performs the delegated request (and may cache the results etc).

Optimization: The permisisons API may even listen to content added/removed events in order to preevaluate permissions.




