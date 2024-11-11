class Haupt
{
    public static void Main(string[] args)
    {
        /*
         Aufgaben:
         1)
         Erstelle ein Array der Länge 10 für ganze Zahlen.
         Belege das Array mithilfe einer Schleife mit Zahlen von 10 bis 1.
         überschreibe die 5. Stelle des Arrays mit einer 70.
         Gebe alle Werte des Arrays in der Konsole aus.
         Gebe Länge des Arrays in der Konsole aus.*/

        int[] eins = new int[10];

        for (int i = 0; i < eins.Length; i++)
        {
            eins[i] = 10 - i;
        }

        eins[4] = 70;

        foreach (var x in eins)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine(eins.Length);

        /*
         2)
         Erstelle eine leere Liste für ganze Zahlen.
         Füge mit einer Schleife Werte von 1 bis 10 hinzu.
         Entferne den 7. Eintrag der Liste.
         Füge eine 99 an die 3. Stelle hinzu.
         Gebe die Liste in der Konsole aus.
         Gebe die Größe der Liste aus.*/

        List<int> zwei = new List<int>();
        for (int i = 1; i < 11; i++)
        {
            zwei.Add(i);
        }

        zwei.RemoveAt(6);
        zwei.Insert(2, 99);
        foreach (var z in zwei)
        {
            Console.WriteLine(z);
        }

        Console.WriteLine(zwei.Count);

        /*
         3)
         Berrechne den Durchschnitt (Double) der Liste und des Arrays und gebe ihn aus.
         Gebe den maximalen Wert der Liste und des Arrays aus.
         */


        int _summeArray = 0;
        int _maxArray = 0;

        int _summeList = 0;
        int _maxList = 0;

        foreach (var t in eins)
        {
            _summeArray = _summeArray + t;

            if (t > _maxArray)
            {
                _maxArray = t;
            }
        }

        Console.WriteLine("Durhschnitt: " + _summeArray / (double) eins.Length+ ", Maximum: " + _maxArray/(double)zwei.Count);

        foreach (var p in zwei)
        {
            _summeList = _summeList + p;

            if (p > _maxArray)
            {
                _maxList = p;
            }
        }

        Console.WriteLine("Durhschnitt: " + _summeList/(double)zwei.Count + ", Maximum: " + _maxList);
    }
}