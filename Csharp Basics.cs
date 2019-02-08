using System;

class Class1{
	static void Main(){
        const byte sample1 = 0x3A;
        byte sample2 = 58;
        int heartRate = 85;
        double deposits = 135002796;
        const float acceleration = 9.800F;
        float mass = 14.6F;
        double distance = 129.763001;
        bool lost = true;
        bool expensive = true;
        int choice = 2;
        const char integral = '\u222B';
        const string greeting = "Hello";
        string name = "Karen";

        if (sample1 == sample2) {
            Console.WriteLine("The samples are equal.\n");
        } else {
            Console.WriteLine("The samples are not equal.\n");
        }

        if (heartRate >= 40 && heartRate <= 80) {
            Console.WriteLine("Heart rate is normal\n");
        } else {
            Console.WriteLine("Heart rate is not normal\n");
        }

        if (deposits >= 100000000) {
            Console.WriteLine("You are exceedingly wealthy\n");
        } else {
            Console.WriteLine("Sorry you are so poor\n");
        }

        float force = mass * acceleration;
        Console.WriteLine("Force = {0}\n", force);
        Console.WriteLine("{0} is the distance.\n", distance);

        if (lost == true && expensive == true) {
            Console.WriteLine("I'm really sorry! I will get the manager.\n");
        } else if (lost == true && expensive == false) {
            Console.WriteLine("Here is coupon for 10% off.\n");
        }

        switch (choice) {
            case 1:
                Console.WriteLine("You chose 1.\n");
                break;
            case 2:
                Console.WriteLine("You chose 2.\n");
                break;
            case 3:
                Console.WriteLine("You chose 3.\n");
                break;
            default:
                Console.WriteLine("You made an unknown choice.\n");
                break;
        }

        Console.WriteLine("{0} is an integral.\n", integral);

        for (int i = 5; i <= 10;) {
            Console.WriteLine("i = {0}", i);
            i += 1;
        }
        Console.WriteLine();

        int age = 0;
        while (age < 6) {
            Console.WriteLine("Age = {0}", age);
            age += 1;
        }
        Console.WriteLine();

        Console.WriteLine("{0} {1}", greeting, name);
    }
}
