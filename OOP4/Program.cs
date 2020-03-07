using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Member newMember = new Member("Julián", "Chávez", 23, 11_500);
            Member oldMember = new Member("Israel", "Mendoza", 27, 23_400);
            newMember.SelfIntroduction(false);
            oldMember.SelfIntroduction(true);
            Console.WriteLine("Creating and destroying a Member object: ");
            TestDeconstructor();
            Console.WriteLine("At this point, the last member should have been destroyed!!!");
            Console.Read();

        }

        static void TestDeconstructor()
        {
            Member testMember = new Member("Otaku", "Apestoso", 11, 0);
            testMember.SelfIntroduction(true);
        }
    }
}