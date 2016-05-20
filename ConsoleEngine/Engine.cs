using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public  static class Engine
    {
        public static void Drow(IShape shape)
        {
            shape.Drow();
        }

        public static void SetPixel(int x,int y,ConsoleColor color)
        {
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = color;
            Console.Write("█");
            Console.ResetColor();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        //public static void ClearPixel(int x,int y)
        //{
          //  Console.ForegroundColor = ConsoleColor.Black;
          //  Console.SetCursorPosition(x,y);
          //  Console.Write(string.Empty);

        //}

        public static void MoveXAnimation(IAnimation animation,int step,int lenght)
        {
            animation.MoveX(step, lenght);
        }

        public static void MoveYAnimation(IAnimation animation,int step,int lenght)
        {
            animation.MoveY(step,lenght);
        }

        public static void ChangeColorAnimation(IAnimation animation, ConsoleColor color,int lenght)
        {
            animation.ChangeColor(color,lenght);
        }
    }
}
