namespace AppConsoleLivres
{
    public class Livre
    {
        
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        
        public Livre(string titre, string auteur, int nombrePages)
        {
            Titre = titre;
            Auteur = auteur;
            this.NombrePages = nombrePages; 
        }

        
        public void AfficherInfo()
        {
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Nombre de pages : {NombrePages}");
        }
    }
}
