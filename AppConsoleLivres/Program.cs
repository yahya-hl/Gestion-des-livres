namespace AppConsoleLivres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livre> livres = new List<Livre>();
            //etape1
            Console.WriteLine("Bienvenue dans l'application AppConsoleLivres !");
            //etape3
            Revue revue1 = new Revue(" Programmation", "ahmed", 120, 1, 2023);
            Revue revue2 = new Revue(" Science", "yahya", 150, 2, 2024);
            Revue revue3 = new Revue(" Technologie", "amina", 100, 3, 2022);

            
            revue1.AfficherInfo();
            Console.WriteLine(); 
            revue2.AfficherInfo();
            Console.WriteLine();
            revue3.AfficherInfo();
            //etape4
            Roman roman1 = new Roman("Le Petit Prince", "Antoine de Saint-Exupéry", 96, "Fiction");
            Roman roman2 = new Roman("1984", "George Orwell", 328, "Dystopie");
            Roman roman3 = new Roman("Les Misérables", "Victor Hugo", 1232, "Roman historique");

            
            roman1.AfficherInfo();
            Console.WriteLine(); 
            roman2.AfficherInfo();
            Console.WriteLine();
            roman3.AfficherInfo();
            Console.WriteLine();

            //etape5
            livres.Add(revue1);
            livres.Add(revue2);
            livres.Add(revue3);
            livres.Add(roman1);
            livres.Add(roman2);
            livres.Add(roman3);


            foreach (var livre in livres)
            {
                livre.AfficherInfo();
                Console.WriteLine(); 
            }
        }
    }
}
