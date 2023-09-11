# CodeAcademy: C# Web App Development

## What is .NET?

Formally, .NET is “an open source developer platform, created by Microsoft, for building many different types of applications. You can write .NET apps in C#, F#, Visual C++, or Visual Basic.”

Informally, .NET is the tool that lets you build and run C# programs (we’ll avoid F#, Visual C++, Visual Basic for now).

When you download .NET, you’re really downloading a bunch of programs that:
+Translate your C# code into instructions that a computer can understand
+Provide utilities for building software, like tools for printing text to the screen and finding the current time 
+Define a set of data types that make it easier for you to store information in your programs, like text, numbers, and dates

## Expression-bodied Definitions
Expression-bodied definitions are the first “shortcut” for writing methods.

```c#
bool isEven (int num){
    return num % 2 == 0;
}
// Could be written this way:
bool isEven (int num) => num % 2 == 0;

// Another example:
static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}");
```


## Array.Exists()
```c#
static bool IsBig(int n) => n > 100;

int[] nums = {0, 555, 252, 3, 9, 101};

bool hasBigNum = Array.Exists(nums, IsBig);
// Array.Exists() will iterate the array to check if the bool is true. If one is true it will print true.

string [] spaceRocks = {“metoro”,”meteor”,”metorite”}
//This will check if the string s (meteor) is in the array
bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteor");
// We can make this even closer
bool makesContact = Array.Exists(spaceRocks, s => s == "meteor");
```


## Classes

```c#
//Creating a class
class Forest {
    public string name;
    public int age;
}

// Using it
Forest f = new Forest();
f.name = "Amazon";
f.age = 14;
```
### Properties
Properties are another type of class member, it controls the access to that field.
+ A get() method, or getter: called when the property is accessed
+ A set() method, or setter: called when the property is assigned a value

```c#
public int Area
{
  get { return area; }
  set 
  { 
    if (value < 0) { area = 0; }
    else { area = value; }
  }
}
// If the Area class is set to < 0 it will automatically be 0 as you cannot have a negative Area.

Forest f = new Forest();
// set() is called
f.Area = -1; 
// get() is called; prints 0
Console.WriteLine(f.Area);

// Its better to set it automatically with
{get; set;}
```
### Public vs. Private
As it is now, any code outside of the Forest class can “sneak past” our properties by directly accessing the field:
```c#
f.Age = 32; // using property
f.age = -1; // using field
```
+ Public — a public member can be accessed by any class
+ Private — a private member can only be accessed by code in the same class

When we switch a field from public to private it will no longer be accessible from Main(), although code inside the Forest class — like properties — can still access it. 

Recall our imaginary Area property. Say we want programs to get the value of the property, but we don’t want programs to set the value of the property. Then we either:
1. Don’t include a set() method, or
2. Make the set() method private.

### Constructor
C# has a special type of method, called a constructor, that does just that. It looks like a method, but there is no return type listed and the method name is the name of its enclosing class:

```c#
class Forest
{
  public int Area;
 
  public Forest(int area)
  {
    Area = area;
  }

// Constructor is called here
Forest f = new Forest(400);
}

```

### Review
+ In general, static means “associated with the class, not an instance”.
+ A static member is always accessed by the class name, rather than the instance name, like Forest.Area.
+ A static method cannot access non-static members.
+ A static constructor is run once per type, not per instance. It is invoked before the type is instantiated or a static member is accessed.
+ Either of these would trigger the static constructor of Forest:





