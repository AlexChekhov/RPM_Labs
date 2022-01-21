using System;
using MyLibrary;

namespace labs
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck mallarDuck = new MallarDuck();
            RedheadDuck redheadDuck = new RedheadDuck();

            Duck[] ducks =
            {
                mallarDuck, redheadDuck
            };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Quack());
            }
        }
    }
}
