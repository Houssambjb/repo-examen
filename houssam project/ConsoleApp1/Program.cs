using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int pessetes;
            double euros;
            const double CANVI = 166.386;
            string operacio = "";
            //Itrodueix valors

            //Demana Valor entrada
            Console.WriteLine("Escriu eurosCAnvi per pasar a euros pessetesCanvi per a pessetes");
            operacio = Console.ReadLine();

            //Algorisme
            if (operacio == "eurosCANVI")
            {
                Console.WriteLine("Quantes pessetes vols camviar a euros");
                pessetes = Convert.ToInt32(Console.ReadLine());
                euros = Math.Round(pessetes / CANVI);
                Console.WriteLine($"El canvi de {pessetes} pessetes es {euros} euros");

            }
            else if (operacio == "pessetesCANVI")
            {
                Console.WriteLine("Quants euros vols vanviar a pessetes");
                euros = Convert.ToDouble(Console.ReadLine());
                pessetes = (int)(euros * CANVI);
                Console.WriteLine($"El canvi de {euros} euros es {pessetes} pessetes");
            }
            else
                Console.WriteLine("NO SAPS ESCRIURE");
        }
    }
}
