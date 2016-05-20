using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleEngine
{
    public class Star:IShape,IAnimation
    {
        public int XStart { get; private set; }

        public int YStart { get; private set; }

        public ConsoleColor Color { get; private set; }

        public Star(int x, int y, ConsoleColor color)
        {
            XStart = x;
            YStart = y;
            Color = color;
        }

        public void Drow()
        {
            Engine.SetPixel(XStart,YStart,Color);
            Engine.SetPixel(XStart+1,YStart+1,Color);
            Engine.SetPixel(XStart+1,YStart-1,Color);
            Engine.SetPixel(XStart+2,YStart,Color);
        }

        public void Clear()
        {
            //Engine.ClearPixel(XStart, YStart);
            //Engine.ClearPixel(XStart + 1, YStart + 1);
            //Engine.ClearPixel(XStart + 1, YStart - 1);
            //Engine.ClearPixel(XStart + 2, YStart);
            Engine.Clear();
        }

        public void MoveX(int step, int lenght)
        {
            int tempLenght = 0;
            while (tempLenght <= lenght)
            {
                Clear();
                XStart = XStart + step;
                Drow();
                tempLenght++;
                Thread.Sleep(150);
                
            }
            while (tempLenght>=0)
            {
                Clear();
                XStart = XStart - step;
                Drow();
                tempLenght--;
                Thread.Sleep(150);
            }
            

        }

        public void MoveY(int step, int lenght)
        {
            int tempLenght = 0;
            while (tempLenght <= lenght)
            {
                Clear();
                YStart = YStart + step;
                Drow();
                tempLenght++;
                Thread.Sleep(150);

            }
            while (tempLenght >= 0)
            {
                Clear();
                YStart = YStart - step;
                Drow();
                tempLenght--;
                Thread.Sleep(150);
            }
        }

        public void ChangeColor(ConsoleColor colors,int lenght)
        {
            ConsoleColor saveColor = Color;
            int tempLenght = 0;
            while (tempLenght != lenght)
            {
                Clear();
                Color = Color == saveColor? Color = colors: saveColor;
                Drow();
                tempLenght++;
                Thread.Sleep(100);
            }
            Color = saveColor;

        }
    }
}
