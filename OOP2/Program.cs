using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human israel = new Human("Israel", "Mendoza", "brown", 27);
            Human arthur = new Human("Arthur", "Peterson", "green", 32);
            Human ana = new Human("Ana", "Wagner", "green", 1);
            
            israel.IntroduceMyself();
            arthur.IntroduceMyself();
            ana.IntroduceMyself();
        }
    }
}