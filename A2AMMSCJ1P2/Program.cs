/*
 * Project Name: A2AMMSCJ1P2
 * 
 * Author: Mahjabin Sajadi
 * 
 * Date: 18-02-2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameover
{
    class Program
    {
        static int Operating(int dob)
        {
            return dob = 2021 - dob;

        }
        static double Operating(double b, double h)
        {
            return (b * h) / 2;

        }
        static double Operating(double side)
        {
            return side * side * side;
        }
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            double basee;
            double height;
            double lenght;
            int option;

            firstName = "";
            lastName = "";
            age = 0;
            basee = 0;
            height = 0;
            lenght = 0;
            option = 0;

            Console.WriteLine("Please enter the corresponding number of the function to be executed:");
            Console.WriteLine("1. Display user's deatils.");
            Console.WriteLine("2. Area of Triangle");
            Console.WriteLine("3. Volume of a cube");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter first name: ");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Please enter last name: ");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Please enter year of birth");
                    age = int.Parse(Console.ReadLine());
                    int details = Operating(age);
                    Console.WriteLine("User's details are:" + firstName + " " + lastName + " " + details);
                    break;

                case 2:
                    Console.WriteLine("Please enter base");
                    basee = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter height");
                    height = double.Parse(Console.ReadLine());
                    double area = Operating(basee, height);
                    Console.WriteLine("The area of the triangle is: " + area);
                    break;

                case 3:
                    Console.WriteLine("Please enter side of the cube");
                    lenght = double.Parse(Console.ReadLine());
                    double volume = Operating(lenght);
                    Console.WriteLine("The volume of the cube is: " + volume);
                    break;

                default:
                    Console.WriteLine("Please enter the correct number");
                    break;
            }
            Console.ReadLine();
        }
    }
}

