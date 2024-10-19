namespace AppConsoleLivres
{
    public class Revue : Livre
    {
        
        public int Numero { get; set; }
        public int Annee { get; set; }

        // Constructeur de la classe enfant Revue
        public Revue(string titre, string auteur, int nombrePages, int numero, int annee)
            : base(titre, auteur, nombrePages) // Appel du constructeur parent
        {
            Numero = numero;
            Annee = annee;
        }

        // Méthode pour afficher les détails spécifiques à la Revue
        public new void AfficherInfo()
        {
            base.AfficherInfo(); // Appel de la méthode de la classe parent
            Console.WriteLine($"Numéro : {Numero}, Année : {Annee}");
        }
    }
}
