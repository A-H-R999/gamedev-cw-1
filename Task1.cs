﻿using System;

namespace Program
{
    class Task1
    {
        static void Main(string[] args)
        {
            String characterName = "Ryuk";
            double speed = 270.5;
            int age = 872;
            String superPower1 = "Invisibility";
            String superPower2 = "Flying";

            Console.WriteLine("My name is {0} and my super powers are {1} & {2}. I'm {3} years old and my speed is {4}",characterName,superPower1,superPower2,age,speed);
            
            String heroName = "Thor";
            double heroHeight = 190.8;
            int heroAge = 430;
            String heroSuperPower1 = "Thunder";
            String heroSuperPower2 = "Rage";
            int ageDifference = age - heroAge;
            
            Console.WriteLine();
            Console.WriteLine("The age difference is " + ageDifference);

        }
    }
}