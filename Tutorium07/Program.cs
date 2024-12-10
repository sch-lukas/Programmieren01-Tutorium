/* Ein Wein hat einen Namen, einen Jahrgang (z.B. 1996) und einen Preis (z.B. 15.20).
 a.) Schreiben Sie eine Struktur, die einen Wein beschreibt mit passendem Konstruktor.
 b.) Erzeuge verschiedene Weine aus den Jahren 1996, 2000, 2018, 2020, 2021 mit Preisen und Namen eurer Wahl
 c.) Schreibe Eigenschaften mit ,,getter'' für alle Felder.
     Füge für die Eigenschaft vom Preis zusätzlich einen ,,setter hinzu''.

 d.) Lege eine ToString Methode für den Wein an und teste diese in der Main Methode.

 e.) Schreiben Sie eine Methode, die den durchschnittlichen Preis aller Weine ermittelt, die eine
 bestimmten Namen haben.
 public static double DurchschnittsPreis(List<Wein> dieWeine, string name)

 f.) Schreiben Sie eine Methode, die das durchschnittliche Alter einer Liste an Weinflaschen im Jahr 2016 be
rechnet. Wenn das Feld leer ist, soll 0 zurückgegeben werden.
 public static double DurchschnittsAlter(List<Wein> dieWeine) */

public struct Wein
{
    private int Jahr { get;  }
    private string Namen { get; }
    private double Preis { get; set; }

    public Wein(int jahr, string namen, double preis)
    {
        Jahr = jahr;
        Namen = namen;
        Preis = preis;
    }

    public override string ToString()
    {
        return "Namen"+Namen+" Jahr"+Jahr+" Preis"+Preis;
    }

    public static double DurchschnittsPreis(List<Wein> dieWeine, string name)
    {
        List<Wein>temp = new List<Wein>();
        foreach (var x in dieWeine)
        {
            if(x.Namen == name)temp.Add(x);
        }
        double durchschnitts = 0;
        foreach (var y in temp)
        {
            durchschnitts = durchschnitts + y.Preis;
        }
        return durchschnitts/temp.Count;
    }
}
 
 
 
 
 
class Haupt
{
    public static void Main(string[] args)
    {
        Wein Federweißer = new Wein(2021, "Federweißer,", 12);
        Wein Dornfelder = new Wein(2018, "Dornfelder", 18);
        Wein Federweißer4 = new Wein(1996, "Federweißer,", 12);
        Wein Dornfelder2 = new Wein(2000, "Dornfelder", 18);
        Wein Federweißer2 = new Wein(2020, "Federweißer,", 12);
        Wein Dornfelder3 = new Wein(2018, "Dornfelder", 18);
        
        List<Wein>Weinliste=new List<Wein>{Federweißer,Dornfelder,Federweißer4,Dornfelder2,Dornfelder3,Dornfelder};
        Console.WriteLine(Wein.DurchschnittsPreis(Weinliste, "Federweißer"));
    }
}
 
 
 
 /* 
 g.) Schreiben Sie eine Methode, die ein Feld mit allen Weinen zurückgibt, die nicht teurer sind
 als ein gegebener Preis.
 public static List<Wein> AlleNichtTeurerAls(List<Wein> dieWeine, double PreisGrenze)
 
 h.) Schreiben Sie eine Methode, die die Indizes der teuersten Weine eines Jahrgangs liefert.
 public static List<int> MaxPreis(List<Wein> dieWeine, int Jahrgang)
 */
 
