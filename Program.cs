Compte CompteFadel = new Compte("7897", "Fadel", 2000);
Compte CompteAlvin = CompteFadel;  

CompteAlvin.Crediter(500m);

Console.WriteLine(CompteFadel.solde);
