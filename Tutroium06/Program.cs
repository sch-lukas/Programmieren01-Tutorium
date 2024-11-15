


/* Aufgabe 1: Durchschnitt, Minimum, Suchen
Von einem Iphone sind Farbe, Preis und Generation bekannt. Die Farbe wird als Text, der Preis mit
Nachkommastellen und die Generation als ganze Zahl gespeichert.

a.) Geben Sie eine Struktur Iphone an, die diese Daten speichern kann.

b.) Erzeuge in der Main Methode eine Liste ,,iphones'' mit den folgenden Iphones:
    - 1. Iphone, lila, 150.5 Euro
    - 8. Iphone, rot, 348.55 Euro
    - 10. Iphone, blau, 654.95 Euro
    - 11. Iphone, gelb, 674.25 Euro
    - 15. Iphone, rosa, 974.95 Euro

c.) Schreiben Sie in die Struktur Iphone eine Methode DPreis, die den durchschnittlichen Preis aller Iphones, deren Preis
unter dem Limit von 660 Euro liegt.
Gibt es kein solches Handy, soll 0.0 zurückgegeben werden.
public static double DPreis (List<Iphone> iphones)


d.) Schreiben Sie in die Struktur Iphone eine Methode NeuerAls, die eine Liste mit allen IPhones zurückgibt, die neuer als
der Durchschnitt aller Generationen sind.
public static List<Iphone> NeuerAls (List<Iphone> iphones)

}*/

struct Iphone
{
    public string farbe;
    public int generation;
    public double preis;

    public Iphone(string farbeNeu, int generationNeu, double preisNeu)
    {
        farbe = farbeNeu;
        generation = generationNeu;
        preis = preisNeu;
    }

    public static double DPreis(List<Iphone> iphones)
    {
        List<Iphone> iphonesTempär = new List<Iphone>();
        foreach (var x in iphones)
        {
            if (x.preis < 660)
            {
                iphonesTempär.Add(x);
            }
        }
        double durchschnitt = 0;
        foreach (var y in iphonesTempär)
        {
            durchschnitt=durchschnitt + y.preis;
        }
        return durchschnitt/iphonesTempär.Count;
    }

    public static List<Iphone> NeuerAls(List<Iphone> iphones)
    {
        List<Iphone> neuerAls = new List<Iphone>();
        int durchschnitt = 0;
        foreach (var z in iphones)
        {
            durchschnitt = durchschnitt + z.generation;
        }
        durchschnitt = durchschnitt / iphones.Count;
        foreach (var c in iphones)
        {
            if (c.generation > durchschnitt)
            {
                neuerAls.Add(c);
            }
        }
        return neuerAls;
    }
    
}
class Hauptklasse
{
    public static void Main(string[] args)
    {
        Iphone lila = new Iphone("lila", 1, 150.5);
        Iphone rot = new Iphone("rot", 8, 348.5);
        Iphone blau = new Iphone("blau", 10, 654.95);
        
        List<Iphone> IphoneLIste = new List<Iphone>();
        IphoneLIste.Add(lila);
        IphoneLIste.Add(rot);
        IphoneLIste.Add(blau);
        Iphone.DPreis(IphoneLIste);    
    }    

}