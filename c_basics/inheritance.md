
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
