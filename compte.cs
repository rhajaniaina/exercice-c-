public class Compte
{
    public string numero { get; }
    public string titulaire { get; }
    public decimal solde { get; private set; }



    public Compte(string Numero, string Titulaire)
    {
        numero = Numero;
        titulaire = Titulaire;
        solde = 0m;
    }

public class CompteEpargne : Compte
    {
        public decimal TauxInterets { get; }
        
        public CompteEpargne(string Numero,string Titulaire,decimal tauxinterets) : base(Numero, Titulaire)
        {
            TauxInterets = tauxinterets;
        }
    }

    public Compte(string Numero, string Titulaire, decimal Solde)
    {
        numero = Numero;
        titulaire = Titulaire;
        solde = Solde;
    }

    public void Crediter(decimal montant)
    {
        solde = solde + montant;
    }

    public void Debiter(decimal montant)
    {
        solde = solde - montant;
    }
}

