class Haupt
{
    public static void Main(string[] args)
    {
        
        int leer = 9;

        for (int i = 0; i < 10; i++)
        {
            Console.Write(i);
            
            for (int j = 0; j < leer; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            leer--;
        }

        int counter2 = 3; 
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < counter2; j++){
            for (int k = 0; k < 4; k++)
            {
                Console.Write("+");
            }
            Console.Write("-");
            }

            Console.WriteLine("");
            counter2--;
        }
        
        
        
        
    }

    
    
    
    
    /*class Übung()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++) //10 Zahlen einspeichern
        {
            int speicher = Convert.ToInt32(Console.ReadLine());
            int temp = speicher;
            for (int j = 0; j < temp; j++) //Speicher mal 5 nehmen Speicher mal wiederholen
            {
                speicher = speicher * 5;
            }
            arr[i]= speicher;
        }
    }*/
}