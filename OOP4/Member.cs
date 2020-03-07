using System;

namespace OOP4
{
    public class Member
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Member(string fName, string lName, int age, double initialSalary)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            this.salary = initialSalary;
        }
        
        /* Deconstruction / Finalizer only to be created when you want to do something as the 
            object is destroyed */
        ~Member()
        {
            // Clean out statements
            Console.WriteLine("Deconstruction of Member object...");
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                else
                {
                    Console.WriteLine("First name cannot be an empty string.");
                }
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    Console.WriteLine("Last name cannot be an empty string");
                }
            }
        }

        public int Age
        {
            get => age;
            set => age = (value > 0) ? value : -value;
        }

        public double Salary => salary;

        public void SelfIntroduction(bool isFriend)
        {
            if (isFriend) SharingPrivateInfo();
            else
            {
                Console.WriteLine($"Hello, I'm {FirstName} {LastName}. I'm {Age} years old.");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"Hi, dude... Well, my salary is {Salary:c2}");
        }
    }
}