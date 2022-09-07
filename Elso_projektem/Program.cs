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
            //Számtípusok
            int szam1 = 5;
            int szam2 = 4;

            int szam6 = 8, szam7 = 9, szam10;
            
            Console.WriteLine("Első programom!!!");
            Console.Write(szam1);
            Console.Write(szam2);
            double szam3 = ((double)szam1 / szam2);//típuskényszerítés
            double szam4 = szam1 / 2.0;
            Console.WriteLine();
            Console.WriteLine(szam1 + szam2);
            Console.WriteLine(szam2 * szam1);
            Console.WriteLine(szam1 / szam2);
            Console.WriteLine(szam3);
            Console.WriteLine(szam4);
            double szam5 = szam1 * szam2 / szam3;
            Console.WriteLine(szam5);

            //Karaktertípus
            char karakter = 'a';
            char karakter2 = 'b';
            string osszefuz = karakter.ToString() + karakter2.ToString();
            Console.WriteLine("Szöveg: {0}{1}",karakter,karakter2);
            Console.WriteLine(osszefuz);

            //Szöveges változók
            string szoveg = "almafa";
            string szoveg2 = szoveg.Replace('a', 'e');
            string szoveg3 = szoveg + " " + szoveg2 + "Tegyél valamit";
            Console.WriteLine(szoveg2);
            Console.WriteLine(szoveg3);
            Console.WriteLine($"{karakter} {karakter2} Ide írok {szoveg3}");
            string ures = null;

            //Bool
            bool igaz = true;
            bool hamis = false;
            Console.WriteLine($"{igaz} {hamis}");

            //Kiírás
            Console.WriteLine("1.feladat\n\tMásodik feladat");
            Console.ReadKey();
        }
    }
}
