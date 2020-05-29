using System;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList() { 17, 21.9, 1, "a", 3.3, "b", "C", "D",555, 2, "f", "G", 55, 13.5, 0 };
            ArrayList objUpper = new ArrayList(100);

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < obj.Count; i++)
            {
                if (obj[i] is string)
                {
                    obj.RemoveAt(i);
                    if (obj[i] is string) i--;
                }
            }

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
        }
    }
}