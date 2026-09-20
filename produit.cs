public class Produit
{
    public string reference { get; }
    public string nom { get; private set;}
    public decimal prix { get; private set;}
    public decimal quantite {get; private set;}

    public Produit(string Reference, string Nom, decimal Prix,decimal Quantite)
    {
        if (Reference == null)
        {
            throw new ArgumentException("un produit ne peut etre créer sans référence");
        }

        if (Prix < 0)
        {
            throw new ArgumentException("le Prix ne peut etre negatif");
        }
        reference = Reference;
        nom = Nom;
        prix = Prix;
        quantite = Quantite;
    }

    public Produit(string Reference, string Nom, decimal Prix)
    : this(Reference, Nom, Prix, 0m)
{
}
    

    
    public void AjouterStock(decimal quantiteAjoutee)
    {
        if (quantiteAjoutee < 0)
        {
            throw new ArgumentException("le stock ajouté ne peut etre negatif");
        }
        quantite = quantite + quantiteAjoutee;
    }

    public void RetirerStock(decimal quantiteRetirer)
    {
        if (quantiteRetirer > quantite)
    {
        throw new ArgumentException("Stock insuffisant");
    }
        quantite = quantite - quantiteRetirer;
    }

}
