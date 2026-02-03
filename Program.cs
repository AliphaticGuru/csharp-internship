// See https://aka.ms/new-console-template for more information
// Console.WriteLine("What is your name?");
// var name = Console.ReadLine();
// var currentDate = DateTime.Now;
// Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}, at {currentDate:t}!");
// Console.Write($"{Environment.NewLine}Press enter to end...");
// Console.Read();

// Task 1
Console.Write($"press enter to start task...:");
Console.ReadLine();

string name = "John Doe";
int age = 25;
bool isAdmin = true;

// Console.WriteLine($"{name}, {age}, {isAdmin}");
Console.WriteLine($"Name -> {name}");
Console.WriteLine($"Age -> {age}");
Console.WriteLine($"Admin priviledge -> {isAdmin}");

// Task 2
Console.Write($"Continue to task 2...:");
Console.ReadLine();

Console.Write("Enter a number lets see ... :");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num}");

if (num % 2 == 0)
{
    Console.WriteLine("it is an even number");
} else
{
    Console.WriteLine("it is an odd number");
}

// Task 3
Console.Write($"Continue to task 3...:");
Console.ReadLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i}");
}

// Task 4
Console.Write($"Continue to task 4...:");
Console.ReadLine();

int[] items = {2,4,6,8,10};

foreach (int item in items)
{
    Console.WriteLine(item);
}

// Task 5
Console.Write($"continue to task 5...:");
Console.ReadLine();

static void Greet(string name)
{
    // name = Console.ReadLine();
    Console.WriteLine($"Hello, ! {name}");
}

// static void Main()
// {
    Greet("Alice");
    Console.Write("Welcome Aboard!, What is your name?");
    name = Console.ReadLine();
    Greet(name);
// }

// Main();

