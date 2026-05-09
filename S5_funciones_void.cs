//declaracion de variables
string nombrecompleto = "";
// solicitar ak usuario su nombre completo
Console.WriteLine("Por favor, ingrese su nombre completo:");
nombrecompleto = Console.ReadLine();
// mostrar informaciomn del usuario
saludar(nombrecompleto);

void saludar(string nombrecompleto)
{
    Console.WriteLine("Hola " + nombrecompleto + ", bienvenido a mi sistema");
}