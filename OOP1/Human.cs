using System;

namespace OOP1
{
    public class Human
    {
        // Member variable
        public string firstName;
        public string lastName;

        public void IntroduceMyself()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }
    }
}