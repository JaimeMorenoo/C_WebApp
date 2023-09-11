# CodeAcademy: C# Web App Development

## <ins>What is .NET?</ins>

Formally, .NET is “an open source developer platform, created by Microsoft, for building many different types of applications. You can write .NET apps in C#, F#, Visual C++, or Visual Basic.”

Informally, .NET is the tool that lets you build and run C# programs (we’ll avoid F#, Visual C++, Visual Basic for now).

When you download .NET, you’re really downloading a bunch of programs that:
+Translate your C# code into instructions that a computer can understand
+Provide utilities for building software, like tools for printing text to the screen and finding the current time 
+Define a set of data types that make it easier for you to store information in your programs, like text, numbers, and dates

## <ins>Expression-bodied Definitions</ins>
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


## <ins>Array.Exists()</ins>
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




