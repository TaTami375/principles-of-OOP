// See https://aka.ms/new-console-template for more information
using static Generics.Task1;
using static Generics.Task2;
using static Generics.Task3;
using static Generics.Task4;
using static Generics.Task5;

Console.WriteLine("\n===Task1===");
Pair<int, string> pair = new Pair<int, string>(1, "one");
Console.WriteLine(pair);
pair.SetFirst(2);
pair.SetSecond("two");
Console.WriteLine(pair);


Console.WriteLine("\n===Task2===");
int[] numbers = { 5, 3, 8, 1, 2 };
Console.WriteLine($"Min value: {FindMin(numbers)}");
string[] words = { "apple", "banana", "cherry" };
Console.WriteLine($"Min value: {FindMin(words)}");


Console.WriteLine("\n===Task3===");
Repository<string> repository = new Repository<string>();
repository.Add("First");
repository.Add("Second");
Console.WriteLine(repository.Get(0));
Console.WriteLine(repository.Get(1));


Console.WriteLine("\n===Task4===");
int x = 5, y = 10;
Console.WriteLine($"Before Swap: x = {x}, y = {y}");
Swap(ref x, ref y);
Console.WriteLine($"After Swap: x = {x}, y = {y}");

string first = "Hello", second = "World";
Console.WriteLine($"Before Swap: first = {first}, second = {second}");
Swap(ref first, ref second);
Console.WriteLine($"After Swap: first = {first}, second = {second}");


Console.WriteLine("\n===Task5===");
IStorage<int> storage = new ListStorage<int>();
storage.Add(10);
storage.Add(20);

Console.WriteLine(storage.Get(0));
Console.WriteLine(storage.Get(1));
