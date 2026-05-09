public class S6_alcance_var_global
{   
    public static int cont = 0; //global
    public static void Main(string[] args)
    {
        Console.WriteLine("valor de cont:  " + cont);
        contar();
        contar();
        contar();
        Console.WriteLine("valor de cont:  " + cont);
    }
    public static void contar()
    {
        cont ++ ;
        Console.WriteLine("valor de cont desde la funcion:  " + cont);
    }
}