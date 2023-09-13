
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