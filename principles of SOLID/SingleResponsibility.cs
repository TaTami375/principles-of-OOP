using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_SOLID
{
    internal class SingleResponsibility
    {
        // Класс, отвечающий за хранение данных о сотруднике
        public class Employee
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public Employee(string name, int id)
            {
                Name = name;
                Id = id;
            }
        }

        // Класс, отвечающий за расчет зарплаты
        public class SalaryCalculator
        {
            public decimal CalculateSalary(int hoursWorked, decimal hourlyRate)
            {
                return hoursWorked * hourlyRate;
            }
        }
    }
}
