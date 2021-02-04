/***********************************************************************************************
 * Kurzbeschreibung:      
 * Lese 10 Namen ein und speichere diese in ein String Array.
 * Nach der Eingabe sollen zunächst alle Namen ausgegeben werden.
 * Danach sollen nur jene Namen ausgegeben werden, welche mehr als einmal eingegeben wurden.
*/


using System;


namespace Dubletten
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            bool foundBefore;
            bool foundAfter;

            //Einlesen
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Name Nr. {0} eingeben:", i + 1);
                names[i] = Console.ReadLine();
            }

            //Alle Namen ausgeben
            Console.WriteLine("\nEingegebene Namen:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Dubletten ausgeben
            Console.WriteLine("\nFolgende Namen wurden mehrfach eingegeben:");
            for (int i = 0; i < names.Length; i++)
            {
                foundBefore = false;
                foundAfter = false;
                for (int u = 0; u < names.Length; u++)
                {
                    if ((i != u) && (names[i] == names[u]))
                    {
                        if (u < i)
                        {
                            foundBefore = true;
                        }
                        else
                        {
                            foundAfter = true;
                        }
                    }
                }
                if (foundAfter && !foundBefore)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }

    }
}

