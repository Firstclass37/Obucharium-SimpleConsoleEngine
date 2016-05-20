using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
         Star star = new Star(3,3,ConsoleColor.DarkYellow);
         Engine.Drow(star);
         Engine.MoveXAnimation(star,2,10);
         Engine.MoveYAnimation(star,1,20);
         Engine.ChangeColorAnimation(star,ConsoleColor.Gray,20);

         Console.ReadKey();
        }
    }

}
