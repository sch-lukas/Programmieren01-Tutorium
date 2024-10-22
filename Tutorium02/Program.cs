using System;

class Hauptklasse
{
    public static void Main(string[] args)
    {
        // Lese 5 Zahlen per Eingabe in der Konsole ein
        // Gebe den Durchschnitt und die Größte Zahl aus

        int max = 0; //oder int max = Int.MinValue, kleinste mögliche Int Zahl
        int summe = 0; // Variabel, die für die Summe aller zahlen steht
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Bitte ganze Zahl eingeben: ");
            int temp = Convert.ToInt32(Console.ReadLine()); //Zahl temporär speichern
            summe = summe + temp; //Summe aufadierren und speichern
            if (temp > max) //Überprüfe ob die neue Zahl größer ist als die alte und diese dann speichern
            {max = temp; }
        }
        int j = 0;
        while (j < 5)
        {
            j++;
            Console.Write("Bitte ganze Zahl eingeben: ");
            int temp = Convert.ToInt32(Console.ReadLine()); //Zahl temporär speichern

            summe = summe + temp; //Summe aufadierren und speichern

            if (temp > max) //Überprüfe ob die neue Zahl größer ist als die alte und diese dann speichern
            {
                max = temp;
            }
        }
        Console.WriteLine("Größte Zahl:" + max);
        Console.WriteLine("Durchschnitt: " + summe / 5.0);
    }
}
