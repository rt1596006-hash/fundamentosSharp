Console.WriteLine("##### menu claculadoira #####");
Console.WriteLine("menu operaciones");
Console.WriteLine("1 Suma");
Console.WriteLine("2 Resta");
Console.WriteLine("3 Multiplicación");
Console.WriteLine("4 división");
Console.WriteLine("");
double resultado = 0.0;
Console.WriteLine("##### menu claculadoira #####");
Console.Write("ingresa primer numero ; ");
double a = double.Parse(Console.ReadLine());
Console.Write("ingresa segundo numero ; ");
double b = double.Parse(Console.ReadLine());
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
        resultado = a + b ;
        break;
    case 2:
        resultado = a - b ;
        break;
    case 3:
        resultado = a * b ;
        break;
    case 4:
        resultado = a / b ;
        break;
    default:
    Console.Write("OPCION NO EXISTE");
        break;
}
Console.WriteLine("RESULTADO ; " + resultado);