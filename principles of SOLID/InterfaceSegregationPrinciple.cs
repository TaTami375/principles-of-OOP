using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_SOLID
{
    internal class InterfaceSegregationPrinciple
    {
        // Интерфейс для устройств, которые умеют печатать
        public interface IPrinter
        {
            void Print(string document);
        }

        // Интерфейс для устройств, которые умеют сканировать
        public interface IScanner
        {
            void Scan(string document);
        }

        // Устройство, которое умеет и печатать, и сканировать
        public class MultiFunctionPrinter : IPrinter, IScanner
        {
            public void Print(string document)
            {
                Console.WriteLine($"Печатаю: {document}");
            }

            public void Scan(string document)
            {
                Console.WriteLine($"Сканирую: {document}");
            }
        }

        // Устройство, которое умеет только печатать
        public class SimplePrinter : IPrinter
        {
            public void Print(string document)
            {
                Console.WriteLine($"Печатаю: {document}");
            }
        }
    }
}
