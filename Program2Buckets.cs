using System;
using System.Collections.Generic;
using System.Linq;
using System;
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
            Bucket b = new Bucket(20, "main bucket");
            b.Fill(16);

            Bucket b2 = new Bucket(2, "b2");
            Bucket b7 = new Bucket(7, "b7");

            b.PourInto(b2);
            b2.PourInto(b7);
            b7.Empty();
            b.PourInto(b7);

            Console.WriteLine("b : " + b.GetCurrentAmount());
            Console.WriteLine("b2: " + b2.GetCurrentAmount());
            Console.WriteLine("b7: " + b7.GetCurrentAmount());
        }
    }
}