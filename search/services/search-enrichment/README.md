# BCC Search Content Permissions API

## Introduction
The search enrichment API uses AI to find things like:
- (unknown) relationships between content (for content suggestions)
- search suggestions
- etc.

## 

Algorithms for that types:

- Collaborative Filtering (similar users)
- Content Based Filtering (similar articles)

## Description:

Day One:

Analyse four tables:
 a) Club Transactions
 b) Users
 c) Activities
 d) Regstrations

Initial ideas of usage of machine learning in applications:

- Need some scope of rating (for showing similar activities - eg. if my friends rate Activity_A and Activity_B similar than i can calculate a ratio - by Collaborative Filterring)
-Suggesting search activities result - based on previous user activities (need to correlate with registration table.)
-



Day Two:

Training Collaborative Filtering model - based on randomize user ratings per activites.




## Sources:

https://notebook.community/saksham/recommender-systems/Collaborative%20Filtering
https://towardsdatascience.com/knn-algorithm-what-when-why-how-41405c16c36f
http://datamine.unc.edu/jupyter/notebooks/Text%20Mining%20Modules/(5)%20Predictive%20Analysis%20of%20Text%20Data.ipynb
https://heartbeat.fritz.ai/build-train-and-deploy-a-book-recommender-system-using-keras-tensorflow-js-b96944b936a7