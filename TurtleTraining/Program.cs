using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
  class Program
  {
    static int YLine;
    static int size;
    static int leftPos;
    static int step;

    static void WriteT()
    {
      Turtle.X = leftPos + step + size / 3;
      Turtle.Y = YLine;
      Turtle.Angle = 0;
      Turtle.Move(size);
      Turtle.TurnLeft();
      Turtle.Move(size / 3);
      Turtle.Angle = 90;
      Turtle.Move(size / 3 * 2);
      leftPos = Turtle.X;
    }

    static void WriteO()
    {
      Turtle.X = leftPos + step;
      Turtle.Y = YLine;
      Turtle.Angle = 0;
      for (int i = 0; i < 4; i++)
      {
        Turtle.Move(size);
        Turtle.TurnRight();
      }
      leftPos = Turtle.X + size;
    }

    static void WriteP()
    {
      Turtle.X = leftPos + step;
      Turtle.Y = YLine;
      Turtle.Angle = 0;
      Turtle.Move(size);
      for (int i = 0; i < 3; i++)
      {
        Turtle.TurnRight();
        Turtle.Move(size/2);
      }
      leftPos = Turtle.X + size/2;
    }

    static void Main(string[] args)
    {
      Turtle.Speed = 9;

      //Торт
      step = 20;
      leftPos = 180;
      YLine = 200;

      size = 60;
      WriteT();

      size = 30;
      WriteO();
      WriteP();
      WriteT();
    }
  }
}
