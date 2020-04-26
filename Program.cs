using System;

namespace aventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, reponse;

            Afficher($"Ma première aventure");
            LigneBlanche();

            do {
                nom = QuestionOuverte($"Quel est votre nom?");
                reponse = QuestionOuiNon($"Est-ce que {nom} est bien votre nom?");
            } while (reponse != "oui");

            Afficher($"{nom} félicitation, votre aventure se terminer ici!");
            LigneBlanche();

            Afficher("Appuyer sur une touche pour quitter.");
            Console.ReadKey();
        }

        ///////////////////////////////////////////////////////
        // Fonctions d'aide
        ///////////////////////////////////////////////////////

        static void Afficher(string message) 
        {
            Console.WriteLine(message);
        }

        static void LigneBlanche() 
        {
            Console.WriteLine();
        }

        static string QuestionOuverte(string question) 
        {
            string reponse;

            Console.WriteLine($"{question}");
            
            reponse = Console.ReadLine();

            return reponse;
        }

        static string QuestionOuiNon(string question) 
        {
            string reponse;

            do 
            {
                Console.WriteLine($"{question} (oui/non)");
                
                reponse = Console.ReadLine();
            } while (reponse != "oui" && reponse != "non");

            return reponse;
        }
    }
}
