using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public  interface IAnimation
    {
        void MoveX(int step,int lenght);
        void MoveY(int ystep, int lenght);
        void ChangeColor(ConsoleColor color , int lenght);
    }
}
