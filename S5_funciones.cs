// declarar variables1
using System.ComponentModel;

double radio = 0;
double resultado = 0;
//obtener los valora de entrada del usuario
Console.WriteLine("ingrese el radio del circulo: ");
radio = double.Parse(Console.ReadLine());
//realizar el proceso (llamar a la funcion)
resultado = areacirculo(radio);
//mostrar el valor de lo procesado
Console.WriteLine("el valor del area del circulo es : " + resultado);

// calcular area del triangulo
double bbase = 0;
Console.WriteLine("ingrese la base ");
bbase = double.Parse(Console.ReadLine());
double altura = 0; 
Console.WriteLine("ingrese la altura");
altura = double.Parse(Console.ReadLine());
//invocacion
resultado = areatriangulo(bbase, altura);
//mostrar el valor de lo procesado
Console.WriteLine("el valor del area del triangulo es : " + resultado);

//declarar funcion areacirculo
//tipo_ nombrefuncion(tipo daro param- variable parm)
double areacirculo(double radio)
{
    // declarar variables
    double resultado = 0;
    // proceso
    resultado = Math.PI * Math.Pow(radio, 2);
    // retorna el resultado
    return resultado;
}
// declaracion funcion areatriangulo
double areatriangulo(double bbase, double altura)
{
    //declaracion de variables
    double resultado = 0;
    // proceso
    resultado = (bbase * altura)/2;
    //retorno
    return resultado;
}