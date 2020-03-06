using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box(10, 5, 30);
            myBox.DisplayInfo();
            Console.WriteLine($"myBox's front surface are is {myBox.FrontSurface}");
        }
    }
}