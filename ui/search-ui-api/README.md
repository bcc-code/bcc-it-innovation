# BCC Search UI API (BFF - backend for frontend)

## Introduction
A simple backend for the Search UI which exchanges an OIDC identity token for an OAuth access token that can be used to make requests to search services.

The responsibility of the BFF is:
1. User authentication (not authorization)
2. Service aggregation / service gateway - make multiple services available to the frontend through the same API
3. Token exchanges
