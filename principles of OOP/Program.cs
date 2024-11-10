// See https://aka.ms/new-console-template for more information
using static principles_of_OOP.DataAbstraction;
using static principles_of_OOP.Encapsulation;
using static principles_of_OOP.Inheritance;
using static principles_of_OOP.Polymorphism;
Console.WriteLine("===Encapsulation===");
BankAccount bankAccount = new BankAccount(1000);
Console.WriteLine("Начальный баланс: " + bankAccount.GetBalance().ToString());
bankAccount.Deposit(500);
bankAccount.Withdraw(900);

Console.WriteLine("===Inheritance===");
Vehicle vehicle = new Vehicle("KAMAZ", "model X");
vehicle.DisplayInfo();
Car car = new Car("Lada", "Priora", 4);
car.DisplayInfo();
Bicycle bicycle = new Bicycle("Stels", "21 speeds", true);
bicycle.DisplayInfo();

Console.WriteLine("===Polymorphism===");
Animal myDog = new Dog();
Animal myCat = new Cat();
myDog.MakeSound();  
myCat.MakeSound();

Console.WriteLine("===Data Abstraction===");
Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);
Console.WriteLine($"Площадь круга: {circle.GetArea()}");
Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");