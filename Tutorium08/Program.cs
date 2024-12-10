class test
{
    public static void Schreibe(string dateiname, int breite)
    {
        var sw = new StreamWriter(dateiname);
        try
        {
            for (int zl = 0; zl < breite; zl++)
            {
                for (int sp = 0; sp < breite; sp++)
                {
                    sw.Write("x");
                }

                sw.WriteLine();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (sw != null)
            {
                sw.Close();
            }
        }
    }
    public static void Lesen(string st)
    {
        StreamReader rd = null;
        try
        {
            rd = new StreamReader(st);
            string zeile;
            while ((zeile = rd.ReadLine()) != null)
            {
                Console.WriteLine(zeile);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);

        }
        finally
        {
            if (rd != null) rd.Close();
        }
    }
}

class Haupt
{
    public static void Main(string[] args)
    {
        string a = "C:\\Users\\lukas\\Downloads\\Neuer Ordner (4)\\hallo.txt";
        
        test.Schreibe(a, 4);
        test.Lesen(a);
    }
}