using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceStructureDeBAse.exercices
{
    class Serie4
    {
        public static void Exercice1()
        {
            int entry;

            do
            {
                Console.Write("Veuillez entrer un entier positif : ");
                entry = int.Parse(Console.ReadLine());
            } while (!(entry > 0));

            while(entry % 2 == 0)
            {
                entry /= 2;
                Console.WriteLine(entry);
            }
            Console.WriteLine("Nombre impaire atteint !");
        }

        public static void Exercice2()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write("{0}  ",i);
            }
        }

        public static void Exercice3()
        {
            for (int i = 1; i < 101; i++)
            {
                if(i % 2 == 1)
                    Console.Write("{0}  ", i);
            }
        }

        public static void Exercice4()
        {
            int entry;
            do
            {
                Console.Write("Veuillez entrer un entier : ");
                entry = int.Parse(Console.ReadLine());
            } while (entry <= 1);

            for (int i = 1; i < entry+1; i++)
            {
                    Console.Write("{0}  ", i);
            }
        }
    }
}
