Console.WriteLine("ingrese nota:");
double nota = double.Parse(Console.ReadLine());
if (nota <= 20 && nota >=0)
{
    if (nota >= 17)
    {
        Console.WriteLine("excelente");
    }else if (nota >=11)
    {
        Console.WriteLine("aprobado");
    }
    else
    {
        Console.WriteLine("desaprobado");
    }
}
else
{
    Console.WriteLine("nota no valida");
}