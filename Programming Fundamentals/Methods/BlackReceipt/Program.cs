using System;

namespace BlackReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

         static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------\r\n© SoftUni");
        }

    }
}
