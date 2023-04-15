using System;

namespace GitConflictDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour !");
            Console.WriteLine("Bienvenue dans notre application !");
<<<<<<< HEAD
            Console.WriteLine("Ceci est la branche principale !");
=======
            Console.WriteLine("Ceci est la branche feature !");
>>>>>>> feature/BranchDeConflit
            Console.WriteLine("Appuyez sur une touche pour quitter.");
            Console.ReadKey();
        }
    }
}

