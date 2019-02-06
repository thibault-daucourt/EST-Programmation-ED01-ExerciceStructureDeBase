using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceStructureDeBAse.exercice
{
    class Serie3
    {
        public static void Exercice1()
        {
            Console.Write("Veuillez entrer un entier : ");
            int entry = int.Parse(Console.ReadLine());

            if (entry == 13)
                Console.WriteLine("Vous avez saisi le nombre 13. Par superstition?");
            else
                Console.WriteLine("Vous avez saisi le nombre {0} .Merci !",entry);
        }

        public static void Exercice2()
        {
            Console.Write("Veuillez entrer un entier : ");
            int BigEntry = int.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer un autre entier : ");
            int SmallEntry = int.Parse(Console.ReadLine());

            if(SmallEntry > BigEntry)
            {
                int temp = SmallEntry;
                SmallEntry = BigEntry;
                BigEntry = temp;
            }

            int closeness = BigEntry - SmallEntry;

            if(closeness < 10)
                Console.WriteLine("Proches");
            else
                Console.WriteLine("Lointains");
        }

        public static void Exercice3()
        {
            Console.Write("Veuillez entrer un entier : ");
            int bigEntry = int.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer un autre entier : ");
            int mediumEntry = int.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer un troisième entier : ");
            int smallEntry = int.Parse(Console.ReadLine());

            int temp;

            if(smallEntry > mediumEntry)
            {
                temp = smallEntry;
                smallEntry = mediumEntry;
                mediumEntry = temp;
            }

            if (mediumEntry > bigEntry)
            {
                temp = bigEntry;
                bigEntry = mediumEntry;
                mediumEntry = temp;
            }

            if (smallEntry > mediumEntry)
            {
                temp = smallEntry;
                smallEntry = mediumEntry;
                mediumEntry = temp;
            }

            Console.WriteLine("le nombre le plus grand est {0}", bigEntry);
        }

        public static void Exercice4()
        {
            Console.Write("Veuillez entrer l'opérande 1: ");
            int entry1 = int.Parse(Console.ReadLine());

            Console.Write("Veuillez entrer l'opérande 2: ");
            int entry2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", entry1, entry2, entry1 + entry2);
            Console.WriteLine("{0} - {1} = {2}", entry1, entry2, entry1 - entry2);
            Console.WriteLine("{0} * {1} = {2}", entry1, entry2, entry1 * entry2);
            if( entry2 == 0)
                Console.WriteLine("{0} / {1} = {2}", entry1, entry2, "Erreur");
            else
                Console.WriteLine("{0} / {1} = {2}", entry1, entry2, Math.Round((float)entry1 / entry2, 3));
        }

        public static void Exercice5 ()
        {
            Console.Write("Veuillez entrer votre age : ");
            int age = int.Parse(Console.ReadLine());

            int enterPrice = 5;
            int categorie = 1;

            // si tu es un enfant tu paies pas de frais supp
            if (age < 4)
                categorie = 0;
            // si tu es un adulte tu payer une majoration par rapport aux jeunes/vieux
            else if (age <= 15 && age < 65)
                categorie = 2;

            enterPrice += categorie * 20;

            Console.WriteLine("Prix d'entrée : {0} CHF", enterPrice);
        }
    }
}
