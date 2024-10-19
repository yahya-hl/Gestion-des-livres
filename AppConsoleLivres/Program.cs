namespace AppConsoleLivres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans l'application AppConsoleLivres !");

            Revue revue1 = new Revue(" Programmation", "ahmed", 120, 1, 2023);
            Revue revue2 = new Revue(" Science", "yahya", 150, 2, 2024);
            Revue revue3 = new Revue(" Technologie", "amina", 100, 3, 2022);

            
            revue1.AfficherInfo();
            Console.WriteLine(); 
            revue2.AfficherInfo();
            Console.WriteLine();
            revue3.AfficherInfo();
        }
    }
}
