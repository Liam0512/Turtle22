using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    internal partial class Program
    {
        /// <summary>
        /// Turtle program
        /// </summary>
        public static Random rnd = new Random();
        static void Main1()
        {
            Turtle t1 = new Turtle();

            //t1.MoveBackward(200);

           t1.SetVisible(false);
            t1.SetDelay(0);
            t1.TailDown();
            t1.TailUp();
            t1.TurnRight(60);
            t1.MoveForward(200);
            t1.TurnRight(120);
            t1.MoveForward(200);
            t1.TurnRight(120);
            t1.MoveForward(200);
            t1.TailUp();
            t1.MoveForward(500);
            t1.TurnLeft(120);
            t1.MoveForward(200);
            t1.TailDown();
            for (int i = 0; i < 360; i++)
            {
                t1.MoveForward(5);
                t1.TurnLeft(1);

            }
            t1.MoveForward(286.4766976);
            t1.TurnLeft(90);
            for (int i = 0; i < 3; i++)
            {
                t1.MoveForward(572.9577951);
                t1.TurnLeft(90);
            }
            t1.MoveForward(286.4766976);
            t1.TurnLeft(90);
            t1.TailUp();
            t1.MoveForward(286.4766976);
            double x;
            double y;
            for (int i = 0; i < 500; i++)
            {
                x = rnd.NextDouble() * 275;
                y = rnd.NextDouble() * 360;
                t1.TurnLeft(y);
                t1.MoveForward(x);
                t1.TailDown();
                t1.MoveForward(5);
                t1.TailUp();
                t1.MoveBackward(x + 5);
                x = rnd.NextDouble() * 300;
                y = rnd.NextDouble() * 360;
            }
        }
    }
}
