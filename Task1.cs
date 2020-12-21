using System;

namespace Program
{
    class Task1
    {
        static double playerSpeed;
        static int[] charPowerValues = new int[] { 25, 60, 40 };
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
            String heroSuperPower2 = "Flying";
            int ageDifference = age - heroAge;
            
            Console.WriteLine();
            Console.WriteLine("The age difference is " + ageDifference);

            Console.WriteLine(superPower1 == heroSuperPower1 || superPower1 == heroSuperPower2 
                           || superPower2 == heroSuperPower1 || superPower2 == heroSuperPower2); // Bonus

            setSpeed(2.5);

            Console.WriteLine("The current player speed is " + getSpeed());

            powerComparison(charPowerValues);

        }

        static void setSpeed(double newSpeed)
        {
            playerSpeed = newSpeed;
        }

        static double getSpeed()
        {
            return playerSpeed;
        }

        static void powerComparison(int[] newPowerValue)
        {
            if (newPowerValue[0] > newPowerValue[2])
            {
                Console.WriteLine("The 1st hero is more powerful");
            }
            else if (newPowerValue[0] < newPowerValue[2])
            {
                Console.WriteLine("The 3rd hero is more powerful");
            }
            else
            {
                Console.WriteLine("Neither is more powerful");
            }
        }
    }
}
