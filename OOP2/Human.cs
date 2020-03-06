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
        
        // Constructor without Parameters - Default constructor

        public Human()
        {
            Console.WriteLine("Constructor called... ");
        }

        // Constructor with 1 parameter
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        
        // Constructor with 2 parameters
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        // Constructor with 3 parameters
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        
        
        // Constructor with 4 parameters
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        internal void IntroduceMyself()
        {
            if (age != 0)
            {
                Console.WriteLine(age > 1 
                    ? $"Hello, my name is {firstName} {lastName}! I'm {age} years " +
                      $"old and my eyes are {eyeColor}."
                    : $"Hello, my name is {firstName} {lastName}! I'm {age} year " + 
                      $"old and my eyes are {eyeColor}");
            }
            else
            {
                Console.WriteLine(eyeColor != null
                    ? $"Hello, my name is {firstName} {lastName}! My eyes are {eyeColor}."
                    : $"Hello, my name is {firstName} {lastName}!");
            }
        }
    }
}