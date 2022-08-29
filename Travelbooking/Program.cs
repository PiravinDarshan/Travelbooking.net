using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travelbooking
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string packages = File.ReadAllText("C:\\Travel Agency Offers.tsv");
                Console.WriteLine(packages);         
            }
            catch(Exception e)
            {
                Console.WriteLine("The message could not be read");
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}