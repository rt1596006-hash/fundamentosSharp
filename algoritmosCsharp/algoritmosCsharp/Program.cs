using System.Linq.Expressions;

Console.WriteLine("ingrese su nota");
double nota = double.Parse(Console.ReadLine());
if (nota >= 12)
{
    Console.WriteLine("arpobado");
}
else
{
    Console.WriteLine("desaprobado");
}
