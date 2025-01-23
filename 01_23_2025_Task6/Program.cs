using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _01_23_2025_Task6
{

    interface IPlayable
    {
        void play();
    }

    public class Guitar : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar");
        }
    }
    public class Piano : IPlayable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano");
        }
    }
    public abstract class Animal

    {
        public abstract void makeSound();

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }
    public class Dog :Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Your in makeSound (method) in Dog Class....(Dog barks)....(Dog barks)....");
        }
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping. in Dog Class");
        }
    }
    public class cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Your in makeSound (method) in Cat Class....(Cat meows)....(Cat meows)....");
        }
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping. in Dog Class");

        }
    }
    class Calculator
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("in Two integers.(methods)\t" + num1 + num2);
        }
        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine("in Three integers.(methods)\t" + num1 + num2 + num3);

        }
        public void Add(double num1, double num2)
        {
            Console.WriteLine("in Two double.(methods)\t \t" + num1 + num2);

        }
    }//fd
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Your in Super Class Shape .. .");

        }

    }

    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Your in Sub Class Circle .. .");
        }
    }
    class Rectangle: Shape
    {
        public override void draw()
        {
            Console.WriteLine("Your in Sub Class Rectangle .. .");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();

            calc.Add(1,2);

            calc.Add(3.3, 2.2);

            calc.Add(1, 2,5);



            Console.WriteLine("\n\n\n");


            Shape c = new Circle();
            c.draw();

            Console.WriteLine("\n\n\n");

            Dog dog = new Dog();
            dog.makeSound();

            cat cat = new cat();
            cat.makeSound();

            Console.WriteLine("\n\n\n");

            Guitar guitar = new Guitar();
            guitar.play();

            Piano piano = new Piano();

            piano.play();
        }
    }
}
