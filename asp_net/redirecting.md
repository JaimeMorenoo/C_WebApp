# Redirecting

## Introduction to Redirecting
So far, every handler method has rendered the same view page. For example, OnGet() in Index.cshtml.cs will always send a response with Index.cshtml, and OnPost() in About.cshtml.cs will always send a response with About.cshtml.

Let’s start with RedirectToPage(). For basic redirection, call it with a string argument and return the result. The string will represent the destination page, written like the URL segment, like "/Privacy" or "/About/Me".

```c#
public IActionResult OnPost()
{
  return RedirectToPage("/Checkout");
}

```
## Page()
Say that we only want to redirect in some cases. Otherwise we want to have the original response, which included the current page.

Now that our handler methods are returning IActionResult values, we need a way to return the current page. The answer is calling and returning the Page() method.

## NotFound()

An HTTP response includes more than just HTML — it also includes an HTTP status code. A popular one is 404, which means that a requested resource was not found. For example, a user requests a profile page of a non-existent person.

We can generate that kind of response using NotFound().

In this example, a request with the username "Machiavelli" will lead to a 404 response:

```c#
public IActionResult OnPost(string username)
{
  if (username == "Machiavelli")
  {
    return NotFound();
  }
  
  return Page();
}
```
## Async Redirects
With redirection, we will now return IActionResult and Task< IActionResult>.
Task< IActionResult> is for asynchronous methods:
```c#
public async Task<IActionResult> OnGetAsync()
```

