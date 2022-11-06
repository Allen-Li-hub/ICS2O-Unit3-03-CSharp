// Created by: Allen
// Created on: Oct 2022
//
// This program calculates Volume of Sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        float radiusOfSphere;
        float volumeOfSphere;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the radius (cm): ");
        radiusOfSphere = Convert.ToInt32(Console.ReadLine());

        volumeOfSphere = (float)(4.0 / 3 * Math.PI * radiusOfSphere * radiusOfSphere * radiusOfSphere);

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volumeOfSphere.ToString("0.00") + " cm³. ");

        Console.WriteLine("\nDone.");
    }
}