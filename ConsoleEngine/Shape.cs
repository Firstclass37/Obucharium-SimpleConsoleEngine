using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public interface IShape
    {
        int XStart { get; }
        int YStart { get; }
        ConsoleColor Color { get; }

        void Drow();
        void Clear();
    }
}
