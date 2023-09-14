# Page Model Basics

## OnGet()
Page models handle HTTP requests, like GET and POST. We define their response using handler methods. 
One of those handler methods is the OnGet() method. Whenever a user makes a GET request to a page, the page model’s OnGet() method is invoked.

Simplemente el OnGet() pasa valores al @Model dentro de la .cshtml pagina y los puedes usar para mostrar información.

## OnPost()
The OnPost() handler method is invoked when a POST request is sent to a page. This usually happens when a user submits a form (an HTML <form> element).

Usually POST requests come with some information in the form of a query string. For example, say that a form at www.library.com/favorite asks for a book and an author:
 ```html
 <form method="post">
  <div class="form-group">
    <label for="Title">Title</label>
    <input type="text" class="form-control" id="Title" name="Title">
  </div>
  <div class="form-group">
    <label for="Author">Author</label>
    <input type="text" class="form-control" id="Author" name="Author">
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>
 ```
Notice that each <input> has a name attribute — Title and Author, respectively.

OnPost() can capture the values in the query string via matching method parameters. To capture the above values, the method would look like this

```c#
public void OnPost(string title, string author)
{
  Title = title;
  Author = author;
}
```

## Model Binding
In the previous exercise we typed out each parameter name in the form, then copied them over to the OnPost() method, then set them equal to properties. In some cases, we would need a fourth step to convert each value into a valid .NET type…

ASP.NET Core provides a feature that takes care of all that for us: model binding. In model binding, data is retrieved from an HTTP request, it is converted into .NET types, and it is stored in corresponding model properties.

To activate model binding in a page model, make sure that the desired property name matches the name attribute in the <form>, then label it with the attribute [BindProperty].

In the page model:
```c#
[BindProperty]
string Title { get; set; }

[BindProperty]
string Author { get; set; }

// We can then remove the method parameters and assume that the submitted form values are set to their corresponding properties:

// No more method parameters!
// No more Author = author!
public void OnPost()
{ }
```
## asp-for
So far, we’ve built an HTML form in the view page. When submitted it sends a URL query string to our app according to the name attributes of the form. We captured the query values first using method parameters, then using model binding.

Instead of using the name and id attributes in each < input> element, we’ll use the asp-for attribute:

Take this Input Tag Helper, which uses the asp-for attribute:
```c#
<input asp-for="Author">
```
## asp-route-{value}
The Input Tag Helper, with asp-for, allows us to easily create a form that submits data with a POST request.

What Tag Helper and attribute(s) would help us with GET requests?

Similarly, the Anchor Tag Helper, with asp-page and asp-route-{value} attributes, allows us to create < a> links that submit data with a GET request.
+ asp-page — Sets an anchor tag’s href attribute value to a specific page.
+ asp-route-{value} — Adds route values to an href. The {value} placeholder is interpreted as a potential route parameter.

## OnGetAsync()
An asynchronous operation is one that allows the computer to “move on” to other tasks while waiting for the asynchronous operation to complete. Asynchronous programming means that time-consuming operations don’t have to bring everything else in our programs to a halt.
+ Mark the method with async
+ Define the return type as Task
+ Rename it OnPostAsync()

