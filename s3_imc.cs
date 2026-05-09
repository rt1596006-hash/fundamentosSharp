//programa que permite calcular el IMC
//declarar las variables
double peso;
double altura;
double imc;
Console.WriteLine(" ingrese su peso (Kg): ");
peso = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese su altura (m):");
altura = double.Parse(Console.ReadLine());
//calcualr el imc
imc= peso / (altura^2);
Console.WriteLine("su imc es : "+ imc);