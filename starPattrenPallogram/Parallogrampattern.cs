using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starPattrenPallogram
{
    public class Parallogrampattern
    {
        public void parallogram()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }
                for (int k =1 ; k <= 5; k++)
                {
                    Console.Write("*");
                }
               
                Console.WriteLine();
            }
            Console.ReadLine();

        }       
    }
        
}
