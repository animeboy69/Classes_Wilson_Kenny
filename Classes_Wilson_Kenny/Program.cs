using System;

namespace Classes_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tells the user greeting
            Greetings greetings = new Greetings();
            // Tells the user welcome when the user puts their name
            greetings.Welcome();

            // Asks the user for their name
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();


            // Says hello to the user 
            greetings.Hello(userName);
        }
    }
}
