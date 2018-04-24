# DNN Platform Documentation

The documentation site for the open source Content Management System DNN (formerly DotNetNuke).

The project uses the `react-static` static site generator.

If you are building this locally, make sure you've installed `react-static` and `yarn`. Then you can type `yarn install` to install dependencies and `yarn start` to load the site locally for development.

Note on usage

* Every individual page needs to have a JSX file in the `src/containers` folder
* Each page also must have a route specified in `static.config.js`.
* Page content comes from the `/content` folder. 
* The name of the `.md` file should match the JSX file: i.e. `/src/containers/Api.js` should have `/content/api.md` as its markdown file.
* A page may have 1 or more markdown files associated with it, allowing more flexibility in the layout of content on the page. To do so, create a folder in `/content` with the name of the page (matching the JSX component). Place your `.md` files in that folder, giving them whatever names you desire. These filenames will then be used to identify the content block in the JSX file.
* Groups of pages can be gathered together in a `collection`. These are stored in `/content/collections`. Create a folder for each collection and place your `.md` files in there. The collection folder name does not have to match a page name. Instead, in `static.config.js` the `GetRouteData` will be given the collection as an array of objects (You need to import the array). Within a route, then you can manipulate that array and pass it as data to a page JSX component.