using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE:  TODO Be sure to follow best practice when creating your classes

            // DONE:  Create a class Animal
            // DONE:  give this class 4 members that all Animals have in common


            // DONE:  Create a class Bird
            // DONE:  give this class 4 members that are specific to Bird
            // DONE:  Set this class to inherit from your Animal Class

            // DONE:  Create a class Reptile
            // DONE:  give this class 4 members that are specific to Reptile
            // DONE:  Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird birdie = new Bird();

            birdie.Age = 2;
            birdie.CanFly = true;
            birdie.ChirpSound = "tweet";
            birdie.FeatherColor = "yellow";
            birdie.CoatType = "feathers";
            birdie.Legs = 2;
            birdie.Name = "Tweety";
            birdie.WingSpan = 4;

            Console.WriteLine($"The type of animal is a bird, it's name is {birdie.Name}, it is {birdie.Age} old, it makes a {birdie.ChirpSound} sound");
            Console.WriteLine($"it's color is {birdie.FeatherColor}, it has {birdie.Legs} number of legs and it's wing span is {birdie.WingSpan} inches!");

            if (birdie.CanFly == true)
            {
                Console.WriteLine("Yes the birdie can fly");

            }
            else
            {
                Console.WriteLine("No the birdie cannot fly");
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile snake = new Reptile();

            snake.HasLegs = false;
            snake.Legs = 0;
            snake.Name = "Slither";
            snake.CoatType = "scales";
            snake.ReptileType = "snake";
            snake.ScaleColor = "green";
            snake.TailLength = 5;
            snake.Age = 1;

            Console.WriteLine($"My new pet repitle is a {snake.ReptileType}, it's name is {snake.Name}, it's color is {snake.ScaleColor}, and it's length is {snake.TailLength} feet!");

            if (snake.HasLegs == false && snake.Legs == 0)
            {
                Console.WriteLine("It's probably a snake");
            }
            else
            {
                Console.WriteLine("Some type of lizzard probably");
            }

        }
    }
}
