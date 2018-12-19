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
    static void Main(string[] args)
    {
      Turtle.Speed = 9;
      Turtle.X = 100;
      Turtle.Y = 200;

      int i = 0;
      //while (i < 6)
      //{
      //  Turtle.Move(100);
      //  Turtle.Turn(60);
      //  i++;
      //}

      //Turtle.X = 300;

      //i = 0;
      while (i < 6)
      {
        for (int j = 0; j < 2; j++)
        {
          Turtle.Move(20);
          if (i % 2 == 0)
            Turtle.TurnRight();
          else
              Turtle.TurnLeft();
        }

        i++;
      }
    }
  }
}
