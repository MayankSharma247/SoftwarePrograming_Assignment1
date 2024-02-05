using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static string category;
    public static string nameofpet;
    public static int hungry;
    public static int happy;
    public static int healthy;


    public static void myPet(string category1, string nameofPet1)
    {
        category = category1;
        nameofpet = nameofPet1;
        hungry = 5;
        happy = 5;
        healthy = 5;
    }

    //Creating void Methods
    //here in this function, i am defining all the pet stats according to the givien question.
    public static void DisplayStats()
    {
        Console.WriteLine($"\nPet Stats:\nHunger: {hungry}/10\nHappiness: {happy}/10\nHealth: {healthy}/10");
    }

    //below the function is about for feedfood action according to function.
    public static void FeedFood()
    {
        Console.WriteLine("\nFeeding...");
        hungry = hungry - 2;
        healthy = healthy + 1;
        Console.WriteLine("Pet is fed. Decresed Hunger , health increased.");
    }

    //below the function is about for playing action according to function.
    public static void Playing()
    {
        Console.WriteLine("\nPlaying...");
        happy = happy + 2;
        hungry = hungry + 1;
        Console.WriteLine("Pet is happy! Happiness increased, hunger increased.");
    }

    //below the function is about for resting action according to function.
    public static void Resting()
    {
        Console.WriteLine("\nResting...");
        healthy = healthy + 2;
        happy = happy - 1;
        Console.WriteLine("Pet is resting. Health increased, happiness decreased.");
    }

    ////below the function is about for timepassing action according to function.
    public static void TimePass()
    {
        Console.WriteLine("\nTime is passing...");
        hungry = hungry + 1;
        happy = happy - 1;
        Console.WriteLine("Pet gets hungry, happiness decreases.");
    }

    public static void StatusCheck()
    {
        Console.WriteLine("\nChecking pet status...");
        DisplayStats();
        if (healthy <= 2 || hungry <= 2 || happy <= 2)
        {
            Console.WriteLine("Warning: Pet is not in the good condition and not well. Take care!");
        }
    }



    static void Main()
    {

        Console.WriteLine("Pet Simulation Game");
        Console.WriteLine("1. Start Game");
        Console.WriteLine("2. Exit");

        int option = int.Parse(Console.ReadLine()); //Casting to int

        if (option == 1)
        {
            Console.WriteLine("Choose a pet type (e.g., cat, dog, rabbit): ");
            string petCategory = Console.ReadLine();
            Console.WriteLine("Give your pet a name: ");
            string Name = Console.ReadLine();

            myPet(petCategory, Name);

            Console.WriteLine($"Welcome to the virtual pet simulation!\nYou have a " + petCategory + " named " + Name);

        }
        else
        {
            Environment.Exit(0);
        }

        while (true)
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1. Feed the Pet");
            Console.WriteLine("2. Play with the Pet");
            Console.WriteLine("3. Let the Pet Rest");
            Console.WriteLine("4. Check Pet Status");
            Console.WriteLine("5. Simulate Time Passing");
            Console.WriteLine("6. Exit");

            int selectedanimal = int.Parse(Console.ReadLine()); //Casting to int

            if (selectedanimal == 1)
            {
                FeedFood();
                DisplayStats();


            }
            else if (selectedanimal == 2)
            {
                Playing();
                DisplayStats();

            }
            else if (selectedanimal == 3)
            {
                Resting();
                DisplayStats();


            }
            else if (selectedanimal == 4)
            {
                StatusCheck();

            }
            else if (selectedanimal == 5)
            {
                TimePass();
                DisplayStats();


            }
            else if (selectedanimal == 6)


            {
                Console.WriteLine("Exit.");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");

            }


        }
    }
}