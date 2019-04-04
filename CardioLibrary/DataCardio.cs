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
            int frequenzaMassima = 0;
            int numeroBattiti = 0;
            int eta = 0;
            Console.WriteLine("inerisci l'eta");
            eta = Convert.ToInt32(Console.ReadLine());
            frequenzaMassima = eta - 220;
            Console.WriteLine("inerisci il numero dei tuoi battiti");
            numeroBattiti = Convert.ToInt32(Console.ReadLine());



        }
            
        
    }
}
