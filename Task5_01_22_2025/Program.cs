using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_01_22_2025
{

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public void Start()
        {
            Console.WriteLine("Vehicle is starting {0} {1}",Brand,Model);
        }
    }

    public class Car :Vehicle
    {
        public int NumberOfDoors  { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle v = new Vehicle();
            Car c = new Car();
            c.Brand = "Kia";
            c.Model = "2024";
            c.Start();



        }
    }
}
// 1 - constructor
// method to give the fileds initial value 
//2- basic concepts of OOPs 
//    -	Inheritance , polymorohisem , encapsulation, Abstraction
//3- Encapsulation 
//    to save data and to check values

//4- sealed class 
//    its a class cant be inherted 
// 5- Inheritance Concept 
//  It is the inheritance of the data to make the code reusable and adjustable .