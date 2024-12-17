
class AutoClass
{
    public int kilometerstand;

    public int KiloSTAND
    {
        get { return kilometerstand; }
        set
        {
            if (value < 0) throw new Exception("DUMM");
            kilometerstand = value;
        }
    }
    public override string ToString()
    {
        return string.Format("HALLO= {0} SERVUS {1} !",this.kilometerstand,this.kilometerstand);
    }
}

struct AutoStruct
{
    public int kilometerstand ;
}
class haupt
{
    public static void Main(string[] args)
    {
        AutoStruct Auto1 = new AutoStruct();
        AutoStruct Auto2 = new AutoStruct();

        Auto1.kilometerstand = 1000;
        Auto2.kilometerstand = Auto1.kilometerstand;
        Auto1.kilometerstand = 2000;
        Console.WriteLine("Auto1:"+Auto1.kilometerstand);
        Console.WriteLine("Auto2:"+Auto2.kilometerstand);
        
        
        AutoClass Auto3 = new AutoClass();
        AutoClass Auto4 = new AutoClass();

        Auto3.kilometerstand = 1000;
        Auto4 = Auto3;
        Auto3.kilometerstand = 2000;
        Console.WriteLine(Auto3.KiloSTAND);
        Auto3.KiloSTAND = 200;
        Console.WriteLine(Auto3);

    }    
}

