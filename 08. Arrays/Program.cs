using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Arrays
{
    /* Dit programma laat alle studenten uit de kllas op het scherm zien en toont 
     * vervolgens het aantal leerlingen */

    class Program
    {
        static void Main(string[] args)
        {
            string[] arrNames = {   "Maurits Annema", "Tom Bastian", "Stefan Beckers", "Dennis Engelen", "Julean Hommel",
                                    "Nando Kools", "David Lei", "Bo Loomans", "Cedric Louis-Guerin", "Jules Paays", "Michael Pisters",
                                    "Mark Rendes", "Kevin Ung", "Shunui Zheng" };

            Array.Sort(arrNames);

            Console.WriteLine("Overzicht klas 1IMV-A14M");
            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < arrNames.Length; i++)
            {
                Console.WriteLine("{0}). {1}", i + 1, arrNames[i]);
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("In deze klas zitten {0} studenten.", arrNames.Length);

            Console.ReadLine();
        }
    }
}
