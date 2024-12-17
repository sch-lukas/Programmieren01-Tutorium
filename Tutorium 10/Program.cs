class haupt
{
    
    public static void Schreibe(string dateiname, int breite)
    {
        string temp = "abcdefg";
        int counter = 0;
        int counter2 = 0;
        
        
        
        var sw = new StreamWriter(dateiname);
        try
        {
            for (int zl = 0; zl < breite; zl++)
            {
                for (int sp = 0; sp < breite; sp++)
                {
                   
                    if (counter == 7) counter = 0;
                    if (zl + sp == breite - 1) sw.Write("_");
                    else
                    {
                        sw.Write(temp[counter]);
                        
                    }
                    counter++;
                    

                }
                sw.WriteLine();
                if (zl%2==0&&zl)counter2++;
                
                counter=counter2;
                if (counter2 == 7) counter2 = 0;
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

    public static void Main(string[] args)
    {
        string a = "C:\\Users\\lukas\\Downloads\\testschreiben\\hallo.txt";
        
        Schreibe(a,10);
    }
}