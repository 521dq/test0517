using System;

namespace tcp
{
    class Program
    {
        static void Main(string[] args)
        {
            string m_ip;
            Console.WriteLine("Input socket ip:");
            m_ip = Console.ReadLine();
            Console.WriteLine("output socket ip: {0}", m_ip);
            Console.ReadKey();
        }
    }
}
