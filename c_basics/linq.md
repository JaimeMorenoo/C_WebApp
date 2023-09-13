## Linq
Imagine you’re building a new game in C#, with dozens of characters to manage in your database. How would you access them all? What if you need to apply a filter? What if you needed to format each character name?

You might think of storing characters in a list and running through each element with a foreach loop. You’d have to write nested if statements, re-format each element, and store each result in a new list.

The result isn’t pretty.

Suppose that we want to find all the names in a list which are longer than 6 letters and return them in all uppercase letters. You can see what it would look like in Program.cs in the code editor.

And remember that this only works in a running C# file. What if the database was stored in a separate server somewhere and it was implemented with SQL instead of C#?

The solution is LINQ. It works for complex selections and transformations, and it works on local and remote data sources. Each selection/transformation is called a query, and LINQ gives us new syntax and methods to write them.

Imagine LINQ like an add-on to C# and .NET.

## Var
Every LINQ query returns either a single value or an object of type IEnumerable<T>. For now, all you need to know about that second type is that:
+ It works with foreach loops, just like arrays and lists
+ You can check its length with Count()

Since the single value type and/or the parameter type T is not always known, it’s common to store a query’s returned value in a variable of type var.

var is just an implicitly typed variable — we let the C# compiler determine the actual type for us. Here’s one example:
```c#
string[] names = { "Tiana", "Dwayne", "Helena" };
var shortNames = names.Where(n => n.Length < 4);
```

In this case shortNames is actually of type IEnumerable<string>, but we don’t need to worry ourselves about that as long as we have var!

## Method and Query Syntax
In LINQ, you can write queries in two ways: in query syntax and method syntax.

Query syntax looks like a multi-line sentence. If you’ve used SQL, you might see some similarities:
```c#
var longLoudHeroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();
```
Method syntax looks like plain old C#. We make method calls on the collection we are querying:
```c#
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

    // Query syntax
        var queryResult = from x in heroes
            where x.Contains("a")
            select $"{x} contains an 'a'";


    // Method syntax
        var methodResult = heroes
        .Where(x => x.Contains("a"))
        .Select(x => $"{x} contains an 'a'");
     

```

## Basic Query Syntax

### Where

In method syntax, each query operator is written as a regular method call.

The where operator is written as the method Where(), which takes a lambda expression as an argument. Remember that lambda expressions are a quick way to write a method. In this case, the method returns true if h is less than 8 characters long.

Where() calls this lambda expression for every element in heroes. If it returns true, then the element is added to the resulting collection.

```c#
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

var heroesWithI = heroes.Where(h => h.Contains("i"));
```
### Select
To transform each element in a sequence — like writing them in uppercase — we can use the select operator. In method syntax it’s written as the method Select(), which takes a lambda expression:
```c#
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var loudHeroes = heroes.Select(h => h.ToUpper());
```
We can combine Select() with Where() in two ways:

1. Use separate statements:
```c#
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
```
2. Chain the expressions:
```c#
var longLoudHeroes = heroes
  .Where(h => h.Length > 6)
  .Select(h => h.ToUpper());
```
