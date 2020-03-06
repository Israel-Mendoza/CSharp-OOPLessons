using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human basicHuman = new Human();
            Human antonia = new Human("Antonia");
            Human margarita = new Human("Margarita", "Mendoza");
            Human arturo = new Human("Arturo", "Mendoza", "brown");
            Human israel = new Human("Israel", "Mendoza", "brown", 27);
            
            basicHuman.IntroduceMyself();
            antonia.IntroduceMyself();
            margarita.IntroduceMyself();
            arturo.IntroduceMyself();
            israel.IntroduceMyself();
        }
    }
}