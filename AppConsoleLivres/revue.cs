namespace AppConsoleLivres
{
    public class Revue : Livre
    {
        
        public int Numero { get; set; }
        public int Annee { get; set; }

        
        public Revue(string titre, string auteur, int nombrePages, int numero, int annee)
            : base(titre, auteur, nombrePages) 
        {
            Numero = numero;
            Annee = annee;
        }

        
        public new void AfficherInfo()
        {
            base.AfficherInfo(); 
            Console.WriteLine($"Numéro : {Numero}, Année : {Annee}");
        }
    }
}
