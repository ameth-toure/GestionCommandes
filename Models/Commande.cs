namespace GestionCommandes.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public double Montant { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}