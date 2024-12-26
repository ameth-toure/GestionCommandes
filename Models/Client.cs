namespace GestionCommandes.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
    }
}

// Commande.cs
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