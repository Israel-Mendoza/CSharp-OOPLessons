using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human israel = new Human();
            israel.firstName = "Israel";
            israel.lastName = "Mendoza";
            israel.IntroduceMyself();
            
            Human arthur = new Human();
            arthur.firstName = "Arthur";
            arthur.lastName = "Peterson";
            arthur.IntroduceMyself();
        }
    }
}