using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static void Metodo_1()
        {
            int frequenzamassima = 0;
            int eta = 0;
            Console.WriteLine("inerisci l'eta");
            eta = Convert.ToInt32(Console.ReadLine());
            frequenzamassima = eta - 220;

        }
            
        
    }
}
