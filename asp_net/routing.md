# Routing

## Intro to Routing
By default, each page’s URL is defined by its filename:
+ Index.cshtml is at localhost:8000
+ Privacy.cshtml is at localhost:8000/Privacy

What if we want to override those defaults?

We can add and/or change URL segments by adding a string after the @page directive. For example, if we used this line at the top of Privacy.cshtml…
@page "/Pirates"

Then Privacy.cshtml would now be available at localhost:8000/Pirates.

If we remove the forward slash (/), then we append a segment. Using this line… --> @page "Pirates"

Makes Privacy.cshtml available at localhost:8000/Privacy/Pirates.

## Route Templates
So far, we’ve seen two ways to pass data from the browser to a page model. Once a form is submitted we can:
1. Capture the data using method parameters, like OnPost(string title), or
2. Bind the data to properties using [BindProperty]

