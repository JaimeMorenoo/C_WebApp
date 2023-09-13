## References
In C# there is one type of reference that can be used for all objects. It’s aptly called Object.

Every class is derived from Object. Whether it’s the class’ superclass or the superclass’ superclass’ superclass, Object is at the top of the class’ inheritance hierarchy.

Since references can be upcast to any type in its inheritance hierarchy, then all types can by referenced as Objects:

```c#
Object o1 = new Dissertation();
Object o2 = new Diary();
Object o3 = new Random();
Object o4 = new Forest("Amazon");
```

If that’s so, why not use Object references for everything? Because the functionality of an object is limited by its reference type. We lose all of a specific type’s specific functionality when we reference it as an Object type. We would also lose the automatic type-checking that saves us from type errors.

When we do use them, Object references can be very useful! For example, if we’re not sure what type a variable is, we can safely store it as an Object. We can also assume that any object has access to the standard Object members for basic manipulation.

Object has a few useful members and they’re accessible by every type. Here are some important ones:
+ Equals(Object) — returns true if the current instance and the argument are equal (using value equality for value types and referential equality for reference types)
+ GetType() — returns the type of the objec
+ ToString() — returns a string describing the object

```c#
Object o1 = new Object();
// t is System.Object
Type t = o1.GetType();

string s = o1.ToString();
// Prints "System.Object"
Console.WriteLine(s);

Object o2 = o1;
// Equals true
bool b = o1.Equals(o2);
```
### Overriding Object Members

The Equals() and ToString() methods in Object are virtual, so they can be overridden.

For example, we can override ToString() in the Diary class:
```c#
class Diary
{
  /* other members omitted */

  public override string ToString()
  {
    return $"This Diary is currently on page {CurrentPage}."; 
  }
}
```
### Conclusion
+ Every type, eventually, inherits from Object
+ Object members include Equals(), ToString(), and GetType()
+ The ToString() method allows Console.WriteLine() to work for all types