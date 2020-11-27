using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                { 
                    continue; 
                }
                //break;   
                System.Console.WriteLine(i);
            }

            System.Console.ReadLine();
        }
    }
}
