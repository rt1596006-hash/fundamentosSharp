int [] valores = [84, 12 ,57, 93, 2, 45,68,19,71,33,5,88,14,62,27,99,41,7,
                    50,76,18,91,24,66,3,54,82,39,11,73,48,8,95,21,60,36,1,79,
                    44,15,87,52,6,92,30,64,23,77,49,10];

// mostrar el array al usuario
Console.WriteLine("valores almacenados");
for(int i =0; i< valores.Length; i++){
    Console.WriteLine(valores[i]);
}
//captura de datos
Console.WriteLine("\n ingrese el numero a buscar");
int valorbuscar = int.Parse(Console.ReadLine());

//busqueda lineal
int pos = -1;
for(int i=0; i< valores.Length; i++)
{
    if(valores[i] == valorbuscar)
    {
        pos = i;
        break;
    }
}

if (pos == -1)
{
    Console.WriteLine("no hallado");
}
else
{
    Console.WriteLine("valor encontrado en pos: " + pos );
}