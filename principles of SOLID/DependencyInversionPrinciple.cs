using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_SOLID
{
    internal class DependencyInversionPrinciple
    {
        // Абстракция для логирования
        public interface ILogger
        {
            void Log(string message);
        }

        // Конкретная реализация логирования в файл
        public class FileLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Logging to file: {message}");
            }
        }

        // Конкретная реализация логирования в консоль
        public class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Logging to console: {message}");
            }
        }

        // Класс, зависящий от абстракции ILogger
        public class Application
        {
            private readonly ILogger _logger;

            public Application(ILogger logger)
            {
                _logger = logger;
            }

            public void Run()
            {
                _logger.Log("Application is running.");
            }
        }
    }
}
