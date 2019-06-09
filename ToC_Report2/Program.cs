using System;

namespace ToC_Report2
{

    class Program
    {
        static void Main(string[] args)
        {
            var ctfstring = "S";
            var newcfs = new ContextFreeString();
            // the random numbers don't change much since its based on time and must be doing these operations at around the same time
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(newcfs.DoContextFreeString(ctfstring));
            }

            
        }
    }
}
