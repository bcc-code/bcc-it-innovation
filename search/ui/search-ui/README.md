# BCC Search UI (Microfrontend)

## Introduction
A set of microfrontend / widgets / webcomponents for a rich search experience:

- Search box with suggestions, autocomplete etc
- Result list(s) that support different content types (persons, audio, video etc.)
- Suggested content lists (AI powered search)
- etc.
- The microfrontend should use Vue.js as the Javascript framework and TailwindCSS as the CSS / component framework.
- The microfrontend should accept an access token (e.g. JWT) as a parameter and pass this as the authorization header to requests to the search-ui-api.

# Building Micro Frontends with React, Vue, and Single-spa


This code goes along with the blog post [Building Micro Frontends with React, Vue, and Single-spa](https://dev.to/dabit3/building-micro-frontends-with-react-vue-and-single-spa-52op) on [Dev.to](https://dev.to)

## Getting started

1. Clone the repo

```sh
git clone https://github.com/dabit3/micro-frontend-example.git
```

2. Install dependencies

```
yarn

# or

npm install
```

3. Start the app

```sh
npm start
```

4. Visit the following URLS:

```sh
# renders both apps
http://localhost:8080/

# renders only react
http://localhost:8080/react

# renders only vue
http://localhost:8080/vue
```