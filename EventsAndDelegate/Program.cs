using System;

namespace EventsAndDelegate
{
    class Program
    {
        public delegate void MyMarriageCeremony();
        public event MyMarriageCeremony marriageevent;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
