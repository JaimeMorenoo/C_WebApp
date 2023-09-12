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
+ A static member is always accessed by the class name, rather than the instance name, like Forest.Area and not f.Area.
+ A static method cannot access non-static members.
+ A static constructor is run once per type, not per instance. It is invoked before the type is instantiated or a static member is accessed.
+ Either of these would trigger the static constructor of Forest:


## Interfaces

The must start with an I to remember ourselves that it is an **Interface**
```c#
interface IAutomobile
{
  string Id { get; }
  double Speed {get;}
  void Vroom();
}
```
Notice that the property and method bodies are not defined. An interface is a set of actions and values, but it doesn’t specify how they work.

### Implementing the Interface
In C#, we must first clearly announce that a class implements an interface using the colon syntax:
```c#
class Sedan : IAutomobile
{
}
// This will error, it must have the properties and methods the highway patrol asked for (Speed, LicensePlate, Wheels, and Honk()).

//So we do the following:
class Sedan : IAutomobile
{
  public string LicensePlate
  { get; }
  
  // and so on...
}
```
When you create an Interface you can use it with many different classes as long as it has the properties of the interface.
```c#
using System;

namespace LearnInterfaces
{
  class Truck : IAutomobile
  {
  	public string LicensePlate
    { get; }

    public double Speed
    { get; private set; } // We need to create a set here in order to be able to change the value in a method. We do it private so only this class method can do it

    public int Wheels
    { get; }
     
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public double Weight {get;}

    public Truck(double speed, double weight){
      this.Speed = speed;
      this.Weight = weight;
      this.LicensePlate = Tools.GenerateLicensePlate();
      if(weight < 400){
        this.Wheels = 8;
      }
      else{
        this.Wheels = 12;
      }
    }

    public void SpeedUp(){
      this.Speed += 5;
    }
    public void SlowDown(){
      this.Speed -= 5;
    }

  }
}
```

## Inheritance

In the interfaces the properties had to be used. Here in class Inheritance it is not necessary.

Lets create a vehicle class:
```c#
using System;

namespace LearnInheritance
{
class Vehicle{
public string LicensePlate {get;}
public double Speed {get; private set;}
public int Wheels {get;}

public void Honk(){
  Console.WriteLine("Honk!");
}

public void SpeedUp(){
  this.Speed += 5;
}

public void SlowDown(){
  this.Speed -= 5;
}

}  
}
```
And now in the Sedan class we can make it inherit vehicle.
```c#
using System;

namespace LearnInheritance
{
  class Sedan : Vehicle
  {
    
  }
}
```

### Virtual & Override

If we want to change how a method works, we need to name it virtual just in case a class that inherits will change it
```c#
// In the Vehicle Class:
public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }

// In the class that inherits:
public override void SpeedUp(){
    this.Speed += 5;
    if(this.Speed > 15){
      this.Speed = 15;
    }
  }

    public override void SlowDown(){
    this.Speed -= 5;
    if(this.Speed < 0){
      this.Speed = 0;
    }
  }
```
### Abstract

This is like the Vehicle class telling its subclasses: “If you inherit from me, you must define a Describe() method because I won’t be giving you any default functionality to inherit.” In other words, abstract members have no implementation in the superclass, but they must be implemented in all subclasses.






