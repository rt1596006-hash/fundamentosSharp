public class S7_arreglos
{
    public static void Main()
    {
        int[] notas = new int[5];
        notas[0] = 15;
        notas[1] = 18;
        notas[2] = 12;
        notas[3] = 20;
        notas[4] = 11;
        Console.WriteLine("=======reporte de notas=======");
        Console.WriteLine("las notas son:");
        imprimirarray(notas);
        int[] edades = new int[3];
        edades[0] = 10;
        edades[1] = 26;
        edades[2] = 30;
        Console.WriteLine("=======reporte de edades =======");
        Console.WriteLine("las edades son:");
        imprimirarray(edades);

    }
    static void imprimirarray(int[] arreglo)
    {
        if(arreglo.Length == 0)
        Console.WriteLine("no hay valores en el arreglo");  
        else
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("valor " + (i+1)+": " + arreglo[i]);
            }
        }         
    }
}