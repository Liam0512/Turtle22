using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;

namespace Turtle22
{
    internal partial class Program
    {
        /// <summary>
        /// Buckets program
        /// </summary>
        static void Main2()
        {
            Bucket b = new Bucket(5, "main bucket");

            Bucket b2 = new Bucket(3, "b2");

            // b.PourInto(b2);
            //b2.PourInto(b7);
            //b7.Empty();
            //b.PourInto(b7);

            //  Console.WriteLine("b : " + b.GetCurrentAmount());
            // Console.WriteLine("b2: " + b2.GetCurrentAmount());
            // Console.WriteLine("b7: " + b7.GetCurrentAmount());
            b2.Fill(3);
            b2.PourInto(b);
            b2.Fill(3);
            b2.PourInto(b);
            b.Empty();
            b2.PourInto(b);
            b2.Fill(3);
            b2.PourInto(b);


        }
    }
}
