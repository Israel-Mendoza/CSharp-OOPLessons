using System;

namespace OOP3
{
    public class Box
    {
        // Member variable
        private int length;
        private int width;
        private int height;
        
        public Box(int length, int width, int height)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public int Length
        {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Length must be a positive value!");
                }
                Console.WriteLine($"Length is being set to {value}");
                this.length = value;
            }
        }

        public int Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Width must be a positive value!");
                }
                Console.WriteLine($"Width is being set to {value}");
                this.width = value;
            }
        }
        
        public int Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Height must be a positive value!");
                }
                Console.WriteLine($"Height is being set to {value}");
                this.height = value;
            }
        }

        public int Volume => Height * Width * Length;
        public int FrontSurface => Height * Length;

        public void DisplayInfo()
        {
            Console.WriteLine($"Length: {Length} - Width: {Width} - Height: {Height} - Volume: {Length * Width * Height}");
        }
    }
}