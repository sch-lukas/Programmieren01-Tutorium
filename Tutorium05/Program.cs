class Haupt
{
    public static void Main(string[] args)
    {
        // Aufgabe01 Erstelle folgendes Array mit 10 zufälligen Werten:
        int[] test = new int[10];
        Random zufall = new Random();
        for (int i = 0; i < 10; i++)
        {
            test[i] = zufall.Next(10);
        }

        // Erledige die folgenden Aufgabe in einer ausgelagerten void Methode/Funktion:
        // Erstelle folgende Suchen und gebe das Ergebnis aus:
        Console.Write("Das Array:");
        foreach (var v in test)
        {
            Console.Write(v + ", ");
        }

        // Wie oft kommt die Zahl 8 vor?
        int counter = 0;
        foreach (int a in test)
        {
            if (a == 8)
            {
                counter++;
            }
        }

        Console.WriteLine("Wie oft kommt die 8 vor:" + counter);


        // 5 _ _ 5 _ _ 5 _
        // 0 1 2 3 4 6 7 8

        // List{0,3,7}

        // Erstelle eine Liste die alle Indexe (Index=Stelle im Array) der Zahl 5 enthält.

        List<int> liste = new List<int>();
        for (int i = 0; i < test.Length; i++)
        {
            if (test[i] == 5)
            {
                liste.Add(i);
            }
        }

        Console.Write("Indexe von der Zahl fünf:");
        foreach (var x in liste)
        {
            Console.WriteLine(x);
        }


        // Erstelle eine Liste die alle Indexe (Index=Stelle im Array) der Zahl 5 enthält.

        // Was ist die größte und kleinste Zahl im Array?

        // Welche Zahl kommt am meisten vor?
    }
}