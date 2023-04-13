using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Wilson_Kenny
{
    class Greetings
    {
        /// <summary>
        /// When the user puts their name they say Hello Traverler
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traverler, welcome!");
        }


        /// <summary>
        /// Tells the user when their name is put it says thank you for joining us today at the end
        /// </summary>
        /// <param name="name">Kenny</param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
