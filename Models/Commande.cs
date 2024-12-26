namespace GestionCommandes.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public string DateCommande { get; set; }
        public decimal Montant { get; set; }
        public string Etat { get; set; }
    }
}