


class Haupt
{
    public static void Main(string[] args)
    {
        int counter = 0;
        int leer = 9;

        for (int i = 0; i < 10; i++)
        {
            Console.Write(counter);
            counter++;
            for (int j = 0; j < leer; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            leer--;
        }
    }
}