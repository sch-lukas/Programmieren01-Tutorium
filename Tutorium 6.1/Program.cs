
struct Auto
{
     public string kennzeichen;
     public int kilometerStand;
     public Auto(int kilometerStandNeu, string kennzeichenNeu)
     {
         kennzeichen = kennzeichenNeu;
         kilometerStand = kilometerStandNeu;
     }
     public void KilometerFahren(int kilometer)
     {
         kilometerStand = kilometerStand + kilometer;
     }
}
class haupt
{
    public static void Main()
    {
        Auto a = new Auto();
        a.kennzeichen = "Ka";
        a.kilometerStand = 100;
        Auto AMG_Mercedes = new Auto( 56000,"KA-BC");
        AMG_Mercedes.KilometerFahren(10);
        Console.WriteLine(AMG_Mercedes.kilometerStand);
        Console.WriteLine(AMG_Mercedes.kennzeichen);
    }
}