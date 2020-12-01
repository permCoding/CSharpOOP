using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    public interface IScreen
    {
        int Colors { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        void PrintInfo(Bitmap bmp);
    }
    public class Laptop
    {
        public string Name { get; set; }
        public IScreen screen;
        public Keyboard keyboard;
        public Laptop(string name)
        {
            Name = name;
        }
    }
    public class Screen: IScreen
    {
        public int Colors { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public void PrintInfo(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            // масштабировать - 2
            // - 3 - мб про интерфесы клавы
            Console.WriteLine($"{w}: {h}");
        }
    }
    public class ScreenRotate: IScreen
    {
        public bool Direction { get; set; }
        public int Colors { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public void PrintInfo(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            if (Direction) { }; // повернуть картинку - 1
            // масштабировать - 2
            // - 3
            Console.WriteLine($"{w}: {h}");
        }
    }
    public class Keyboard
    {

    }
}
