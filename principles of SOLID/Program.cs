// See https://aka.ms/new-console-template for more information
using static principles_of_SOLID.DependencyInversionPrinciple;
using static principles_of_SOLID.InterfaceSegregationPrinciple;
using static principles_of_SOLID.LiskovSubstitutionPrinciple;
using static principles_of_SOLID.OpenClosedPrinciple;
using static principles_of_SOLID.SingleResponsibility;
Console.WriteLine("===Single Responsibility Principle===");
Employee employee = new Employee("Аркадий  Волож", 1);
SalaryCalculator calculator = new SalaryCalculator();

int hoursWorked = 40;
decimal hourlyRate = 20.5m;
decimal salary = calculator.CalculateSalary(hoursWorked, hourlyRate);

Console.WriteLine($"Разотник: {employee.Name}, Зарплата: {salary}");



Console.WriteLine("\n===Open/Closed Principle===");
Discount percentageDiscount = new PercentageDiscount(10);
Discount fixedDiscount = new FixedAmountDiscount(50);

decimal totalAmount = 500;

Console.WriteLine($"Начальная цена: {totalAmount}");
Console.WriteLine($"После оносительной скидки: {percentageDiscount.Calculate(totalAmount)}");
Console.WriteLine($"После абсолютной скидки: {fixedDiscount.Calculate(totalAmount)}");



Console.WriteLine("\n===Liskov Substitution Principle===");
Bird sparrow = new Sparrow();
sparrow.Eat();
sparrow.Fly();

Bird penguin = new Penguin();
penguin.Eat();

try
{
    penguin.Fly(); 
}
catch (NotImplementedException ex)
{
    Console.WriteLine(ex.Message);
}



Console.WriteLine("\n===Interface Segregation Principle===");
IPrinter simplePrinter = new SimplePrinter();
simplePrinter.Print("Только принтер.");

MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
multiFunctionPrinter.Print("Принтер и сканер.");
multiFunctionPrinter.Scan("Принтер и сканер.");



Console.WriteLine("\n===Dependency Inversion Principle===");
ILogger consoleLogger = new ConsoleLogger();
Application app1 = new Application(consoleLogger);
app1.Run();

ILogger fileLogger = new FileLogger();
Application app2 = new Application(fileLogger);
app2.Run();