using System.Security.Cryptography.X509Certificates;

Console.WriteLine("#### MENU calculadora ####");
Console.WriteLine("MENU calculadora");
Console.WriteLine("1.suma");
Console.WriteLine("2.resta");
Console.WriteLine("3.multiplicaion");
Console.WriteLine("4.division");
Console.WriteLine(" ");
double resultado = 0.0;
Console.WriteLine("ingresa primer numero");
double a =double.Parse(Console.ReadLine());
Console.WriteLine("ingresa segundo numero");
double b =double.Parse(Console.ReadLine());
Console.WriteLine("ingresa opcion");
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
        resultado = a + b;
        break;
    case 2:
        resultado = a-b;
        break;
    case 3:
        resultado = a*b;
        break;
    case 4:
        resultado = a/b;
        break;
    default:
    Console.WriteLine("opcion no existe");
    break;
}
Console.WriteLine("resutlado" + resultado);