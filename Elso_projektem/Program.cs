using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//gyűjtemény, kollekció, .NET keretrendszernek
//using System.IO;//Fájlok beolvasására és kiírásához importált osztályokat tartalmazza.

//Egysoros megjegyzés

/*
 * Többsoros megjegyzés
 * aékjsckéac
 * éakéi
 */

namespace Elso_projektem//névtér
{
    internal class Program//Névtéren belüli automatikusan létrejövő osztály
    {
        static void Main(string[] args)//Főprogram
        {
            //változó deklarálása, inicializálása
            //változó típusa szóköz változó neve (nem lehet foglalt szó vagy kulcsszó) = érték vagy kifejezés
            int szam1 = 5;
            int szam2 = 4;
            
            Console.WriteLine("Első programom!!!");
            Console.Write(szam1);
            Console.Write(szam2);
            double szam3 = (szam1 / (double)szam2);//típuskényszerítés
            Console.WriteLine();
            Console.WriteLine(szam1 + szam2);
            Console.WriteLine(szam2 * szam1);
            Console.WriteLine(szam1 / szam2);
            Console.WriteLine(szam3);

            Console.ReadKey();
        }
    }
}
