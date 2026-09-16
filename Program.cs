Compte CompteFadel = new Compte(7897, "Fadel", 2000);
Compte CompteAlvin = new Compte(9789, "Alvin", 4000);   

Console.WriteLine("=== Compte Fadel ===");
Console.WriteLine("Numéro : " + CompteFadel.numero);
Console.WriteLine("Titulaire : " + CompteFadel.titulaire);
Console.WriteLine("Solde : " + CompteFadel.solde);

Console.WriteLine();

Console.WriteLine("=== Compte Alvin ===");
Console.WriteLine("Numéro : " + CompteAlvin.numero);
Console.WriteLine("Titulaire : " + CompteAlvin.titulaire);
Console.WriteLine("Solde : " + CompteAlvin.solde);

public class Compte
{
    public decimal numero { get; }
    public string titulaire { get; }
    public decimal solde { get; private set; }

    public Compte(decimal Numero, string Titulaire, decimal Solde)
    {
        numero = Numero;
        titulaire = Titulaire;
        solde = Solde;
    }
}