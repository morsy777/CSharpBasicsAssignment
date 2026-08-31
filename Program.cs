// ============ Part A ====================/

// .csproj is the file that contain project configs like .net version, packages and dependencies.
// Program.cs is the entry point of our application.
// obj/ is the dir that conain the compiled output and cached the last build.
// bin/ when we build our project, the IL code is stored in that dir specifically in .dll file or in other word called assembly file.

namespace CSharpBasicsAssignment;

// File-scoped namespace removes the need for a namespace block,
// so the code inside the namespace doesn't need an extra indentation level.

class Program
{
  static void Main()
  {
    Console.WriteLine("Hello");
  }
}

// My project use .sln but .slnx is better in solving git conflicts, also readable and simpler than .sln .

// ============ Part A ====================/