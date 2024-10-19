namespace AppConsoleLivres
{
    public class Roman : Livre
    {
        
        public string Genre { get; set; }

        
        public Roman(string titre, string auteur, int nombrePages, string genre)
            : base(titre, auteur, nombrePages) 
        {
            Genre = genre; 
        }

        
        public new void AfficherInfo()
        {
            base.AfficherInfo(); 
            Console.WriteLine($"Genre : {Genre}");
        }
    }
}
