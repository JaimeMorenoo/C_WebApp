# Razor Pages Syntax 2

## Introduction to the Page Model
Now that we have an understanding of how the view page renders C# and HTML, let’s take a look at how we can work with the logic behind it.

In order to add functionality to the view layer, we must add a PageModel class where all the logic will belong. This class is usually found in the cshtml.cs file placed in the same folder as the view page. 

So if we have a view page at Pages/Index.cshtml, the model page will be available in Pages/Index.cshtml.cs.

+ Smaller and more reusable units of code allow for flexibility to create scalable apps with more ease.
+ View pages will be easier to maintain if the model needs to be updated or requires changes. If the view page and the model weren’t separated, and the model changed frequently, the view would be flooded with update requests leading you to spend extra time fixing and tweaking small changes like method calls or property names.
+ Distinct sections also allow for code to be unit tested — a practice of creating tests to test the written code, which ultimately allows for automated testing — a concept that becomes ever more important as a project grows in size and expands functionality.

## Working with the Page Model
Let’s say you want to display information about a user in a user profile page; you can create a class holding properties of interest for that user (username, age, birthday, etc) and simply call the properties in the view page instead of hardcoding them. 

The model you’ll create must inherit from the **PageModel** class to have access to various properties that will be useful when working with HTTP requests.

## View Data
ViewData allows us to pass information from the page model into the view page. ViewData is of type ViewDataDictionary, which acts as a generic dictionary.

```c#
// in the cshtml.cs
public class IndexModel : PageModel
{
  public void OnGet()
  {
    ViewData["MyDogsName"] = "Alfie";
    ViewData["MyDogsAge"] = 7;
  }
// in the cshtml.html
@page
@model RazorTest.Pages.ExampleModel
<div>
  <p>My dog @ViewData["MyDogsName"] is @ViewData["MyDogsAge"] years old</p>
...
</div>
}
```
## Sharing Pages
Most web apps have a common layout that provides the user with a consistent experience as they navigate from page to page. Certain layouts may include a header, footer, menus, and so on, that may be shared amongst different pages.

Let’s say we’re building an application that contains a header throughout most (if not all) of your pages. If we’re creating the markup for all these pages, the header will still need to be added to each one.

That’s a lot of copy-pasting if the header does not change. We can avoid redundancy by essentially storing the header somewhere separate and rendering its content on each page. 

If our website needs an update we can simply change a single file and the changes will be reflected everywhere the content has been inserted.

**PASOS**
1. Add the footer and header content in the appropriate place in**_Layout.cshtml**.
2. Navigate to _ViewStart.cshtml, Open some code blocks and assign the Layout property to "_Layout"
3. Add a @RenderBody() method between the footer element and the header element.

## Working with ViewImports
On top of sharing layouts, we’re also provided with a file where we can include directives that will become available globally throughout the rest of our pages. This saves us work in typing and makes maintenance easier.

There are a number of directives that you’ll be able to include in _ViewImports.cshtml, three of the most common ones that are added by default are @namespace, @using, and @addTagHelpers.

We just need to add this to _ViewImport.cshtml
@using starting_app (depends on the name of your project)
@namespace starting_app.Pages (depends on the name of your project)
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

## Using Partials
In certain cases, we might end up reusing snippets of HTML, such as forms, on different pages. We can also use these “partials” to break up more complex pages into smaller sections.

Basicamente es como guardar un form en un _Form.cshtml y despues se usa poniendo < partial name="_Form">

## Tag Helpers
Tag Helpers are very useful ways to create HTML elements with server-side attributes. For example, when we use an anchor tag, <a>, we usually have an href attribute to direct the user to a specific page when they click it. Razor Pages provides handy Tag Helpers that help us generate links and other useful information.

We’re using one of the predefined Tag Helpers provided by ASP.NET: < partial …>. The partial one has the following optional attributes:

for: Assigns an expression to be evaluated against the current model. This is one way to pass data to the partial.
< partial name="_ItemPartial" for="Item" />



