using System;
using PropertiesExamples;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //var radius = new Circle();
            ////double r = radius.Radius;
            //radius.Radius = 15.00;
            //Console.WriteLine(radius.Radius);
            Customer customer = new Customer(101,"Shipu",Cities.Dhaka,true,5000);
            //Console.BackgroundColor = ConsoleColor.Blue;
            customer.City = Cities.Rajshahi;
            Console.WriteLine(customer.City);

        }
    }
    public class Circle
    {
        double _Radius = 12.50;
        public double Radius
        {
            get { return _Radius; }
            set 
            {
                if (value > _Radius)
                {
                    _Radius = value;
                    
                }
                else
                {
                    Console.WriteLine("Enter a valid number");
                }
                
            }
        }
    }
}
