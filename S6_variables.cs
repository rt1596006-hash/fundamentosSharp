public class Variables
{
    static int x = 10;
    public static void Main(string[] args)
    {
        Console.WriteLine("Valor inicial de x: " + x);
        agregarvalorA();
        agregarvalorB();
        agregarvalorC();
        Console.WriteLine("Valor final de x: " + x);
    }
    
    static void agregarvalorA()
    {
        x = x + 1;
    }
    static void agregarvalorB()
    {
        x = x + 1;
    }
    static void agregarvalorC()
    {
        x = x + 1;
    }
     
}