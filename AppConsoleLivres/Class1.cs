namespace AppConsoleLivres
{
    public class Livre
    {
        
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }
        public string ISBN { get; set; }

        
        public Livre(string titre, string auteur, int anneePublication, string isbn)
        {
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
            ISBN = isbn;
        }

        
        public void AfficherInfo()
        {
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Année : {AnneePublication}, ISBN : {ISBN}");
        }
    }
}
