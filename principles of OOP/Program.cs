// See https://aka.ms/new-console-template for more information
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
myDog.MakeSound();  // Output: Woof! Woof!
myCat.MakeSound();  // Output: Meow! Meow!