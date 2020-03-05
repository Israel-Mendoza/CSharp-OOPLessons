using System;

namespace OOP2
{
    public class Human
    {
        // Initializing member variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;
        
        // Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        public void IntroduceMyself()
        {
            if (age > 1)
                Console.WriteLine($"Hello, my name is {firstName} {lastName}! I'm {age} years " +
                                  $"old and my eyes are {eyeColor}.");
            else
                Console.WriteLine($"Hello, my name is {firstName} {lastName}! I'm {age} year " +
                                  $"old and my eyes are {eyeColor}.");
        }
    }
}