using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceStructureDeBAse.exercices
{
    class serie2
    {
        public static void  Exercice1() {

            Console.WriteLine("Veuillez entrer la longueur du coté du pentagone régulier dont vous voulez connaitre la surface : ");
            int entry = int.Parse(Console.ReadLine());

            Double surface = PentagoneSurface(entry);

            Console.WriteLine("La surface d'un pentagone régulier de cote de longueur {0} est {1} !", entry, surface);
        }

        public static double PentagoneSurface(int side)
        {
            return ((3 * Math.Sqrt(3))/2)*Math.Pow(side,2);
        }

        public static void Exercice2()
        {
            Console.WriteLine("Veuillez un nombre entier entre 0 et 99 ");
            int entry = int.Parse(Console.ReadLine());

            int unité = entry % 10;

            int decade = entry / 10; // division entière car un nombre netier divise un nombre entier

            Console.WriteLine("Le nombre {0} contient {1} dizaine et {2} unités !", entry, decade, unité);
        }
    }

        
}
