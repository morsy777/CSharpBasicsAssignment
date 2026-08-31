// ============ Part A ====================//

// .csproj is the file that contain project configs like .net version, packages and dependencies.
// Program.cs is the entry point of our application.
// obj/ is the dir that conain the compiled output and cached the last build.
// bin/ when we build our project, the IL code is stored in that dir specifically in .dll file or in other word called assembly file.

namespace CSharpBasicsAssignment;

// File-scoped namespace removes the need for a namespace block,
// so the code inside the namespace doesn't need an extra indentation level.

// My project use .sln but .slnx is better in solving git conflicts, also readable and simpler than .sln .


class Program
{
  static void Main()
  {
    RunValueVsReferenceDemo();
  }

  // ============ Part B ====================//
  static void RunTypesDemo()
  {
    // 1.
    int num = 10;
    long bigNum = 100L;
    double price = 10.5;
    decimal salary = 5000.50m;
    bool isActive = true;
    char grade = 'A';
    string name = "Mohamed";
    var age = 23;

    Console.WriteLine($"{num} - {num.GetType()}");
    Console.WriteLine($"{bigNum} - {bigNum.GetType()}");
    Console.WriteLine($"{price} - {price.GetType()}");
    Console.WriteLine($"{salary} - {salary.GetType()}");
    Console.WriteLine($"{isActive} - {isActive.GetType()}");
    Console.WriteLine($"{grade} - {grade.GetType()}");
    Console.WriteLine($"{name} - {name.GetType()}");
    Console.WriteLine($"{age} - {age.GetType()}");

    // 2.
      // Implicit:
    int x = 10;
    long y = x;

    char c = 'A';
    int asciiCode = c;

      // No Cast is needed because we convert from smaller to larger and C# consider this conversion doesn't cause conflict
    Console.WriteLine(y);
    Console.WriteLine(asciiCode);

      // Explicit:
    double value = 9.7;

    int result1 = (int)value;
    int result2 = Convert.ToInt32(value);

      // int removes the fraction part, while Convert.ToInt32 rounds the value.
    Console.WriteLine(result1);
    Console.WriteLine(result2);

      // Integer division
    int a = 5 / 2;
    double b = 5.0 / 2;

    // a = 2 because we divide int/int, while double = 2.5 because we divide double/int

    Console.WriteLine(a);
    Console.WriteLine(b);

     // Boxing / Unboxing
    int numBox = 42;

    object obj = numBox;
    Console.WriteLine(obj);

    int unboxed = (int)obj;
    Console.WriteLine(unboxed);

      // Parsing
    string input = "42";
    int parsed = int.Parse(input);
    Console.WriteLine(parsed);

    string badInput = "abc";

    if (int.TryParse(badInput, out int parsedBad))
      Console.WriteLine(parsedBad);
    else
      Console.WriteLine("TryParse failed.");

      // float to decimal
    float f = 10.5f;

    // decimal d = f; xxxxx
    // float to decimal is not an implicit conversion, 
    // because decimal is more precise than float and use base-10
    // while float less precise and use base-2

    decimal d = (decimal)f;
    Console.WriteLine(d);
  }

  static void RunValueVsReferenceDemo()
  {
    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;
    p2.X = 99;

    // Struct is value type so when we assign value type
    //  to another variable, a copy of the value is created
    //  and the both variable are completely independent.
    Console.WriteLine($"P1.X = {p1.X} || P2.X = {p2.X}");









  }




}




