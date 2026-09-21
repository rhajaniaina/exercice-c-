


public class Clients
{
    public string nom { get; }

    public List<Compte> Comptes { get; private set; }

    public Clients(string Nom)
    {
        nom = Nom;
        Comptes = new List<Compte>();
    }

    public void AjouterCompte(Compte compte)
    {
        Comptes.Add(compte);
    }

}
