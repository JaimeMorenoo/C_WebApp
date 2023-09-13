# Razor Pages Syntax 1

## Structure of a Razor View Page
In order for a file to behave as a Razor view page, the first line in the file must be @page. The @page directive indicates that the file is a Razor Page and the ASP.NET compiler will treat it as such. This means that we can now write C# code in our view page and HTML markup.

In order for the Razor engine to interpret code as C# instead of HTML, we must prepend the keyword with the “@“ symbol, otherwise, it will read the code as HTML.

```c#
@page
<!-- Add the page directive above this line -->


<div class="text-center">
    <h2>Hey there! My name is:</h2>
  
<!--   Insert a header with your name below -->
    <h1>Jaime</h1>
  
    <br>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>
```

## Writing C# in a Razor Page
All C# expressions are preceded with the character “@“. For example:
```c#
<h1>@DateTime.Now.ToShortDateString()</h1>
```
We can use code blocks if our code exceeds one line or we want to declare variables.
```c#
@{
  int num1 = 6;
  int num2 = 4;
  int result = num1 + num2;
}

<h3> The result of @num1 + @num2 is: @result</h3>
```
## Conditionals in Razor Pages: If Statements
When writing if/else statements, we don’t need to prepend the else if or else lines with an “@“ sign:
```c#
@if (value % 2 == 0)
{
  <p>The value was even.</p>
}
else if (value >= 1337)
{
  <p>The value is large.</p>
}
else
{
  <p>The value is odd and small.</p>
}
```
## Conditionals in Razor Pages: Switch Statements
Similar to if statements, switch cases operate the same way — by prefixing the keyword with the “@“ sign:
```c#
@{ int number = 2 }

@switch (number)
{
  case 1: <h1>The value is 1!</h1>
  break;
  case 2: <h1>The value is 2!</h1>
  break;
  default: ...
}

```
## Working with Loops
There are a number of different types of loops in C# that can be written in Razor syntax. Let’s say we have a list of names we’ll be looping over:
```c#
@{
  List<string> names = new List<string>()
  {
    "Scott Allen",
    "James Dorf",
    "Tim Alston",
    "Jane Rashid",
    "John Doe"
  };
}

<ul>
  @for (int i = 0; i < names.Count; i++)
  {
    <li>@names[i]</li>
  }
</ul>

```