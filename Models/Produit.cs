namespace GestionCommandes.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int QuantiteStock { get; set; }
        public double PrixUnitaire { get; set; }
    }
}