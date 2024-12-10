struct Adresse
{
    public string straße;
    public int hausnummer;
    public Adresse(string straßeNeu, int hausnummerNeu)
    {
        straße = straßeNeu;
        hausnummer = hausnummerNeu;
    }
    public void NeueStraße(string straßeNeu)
    {
        straße = straßeNeu;
    }
    public string WelcheStraße()
    {
        return straße;
    }
    public string AdresseÄndern
    {
        get
        {
            return straße;
        }
        set
        {
            straße = value;
        }
    }
    public override string ToString()
    {
        return "Straße: "+ this.straße + ", Hausnummer:"+ hausnummer;
    }
}
class Haupt
{ public static void Main(string[] args)
    {
        Adresse hochschule = new Adresse("Moltkestraße",30);
        Adresse arbeit = new Adresse("Sophienstraße",20);

        Console.WriteLine(hochschule);
        Console.WriteLine(arbeit);
    }
}