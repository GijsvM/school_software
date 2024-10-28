using System.Runtime.CompilerServices;

Console.WriteLine("Vul de lening hoofdsom in in hele euros: ");
String hoofdsomS = Console.ReadLine();
int hoofdsom = Int32.Parse(hoofdsomS);
Console.WriteLine("\nVul de jaarlijkse rentevoet in in %: ");
String rentevoetS = Console.ReadLine();
int rentevoet = Int32.Parse(rentevoetS);
Console.WriteLine("\nVul de looptijd in jaren in: ");
String looptijdS = Console.ReadLine();
int looptijd = Int32.Parse(looptijdS);
Console.WriteLine("\n De totale kosten van de lening zijn: ");
Console.WriteLine(berekenen(hoofdsom, rentevoet, looptijd));


double berekenen(double hoofdI, int renteI, double jaarI)
{
    
    double rente = renteI / 100.0;
    double totaleRenteP = rente + 1;
    double antwoord = Math.Pow((totaleRenteP / 12),(jaarI*12));
    
   
   


    return antwoord;
}