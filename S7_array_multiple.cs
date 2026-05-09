//resgistro en la bida reañ
// juan perez 1re grado 16
//nombre [0] = "juan perez"
//grado [0] "primer grado"
// nota [0] = 16.00

// crear un mini sitema de registro de notas
//que nos permita registrar el nombre, grado
// y notas del alumno

int indice = 0;
int maximonumeroregistros = 5;
string nombrecompletos;
string grado;
double promediofinal;

string[] registronombres = new string[maximonumeroregistros];
string[] registrogrado = new string[maximonumeroregistros];
double[] registropromedios = new double[maximonumeroregistros];

Console.WriteLine("ingrese el numerod e registros a ingresar");
numeroregistros = int.Parse(Console.ReadLine());
while(numeroregistros > indice){
    Console.WriteLine("resgitrando notas: "+ (indice + 1));
    //capturar los datos del usuario
    Console.WriteLine("Ingrese sus nombres completos");
    nombrecompletos = Console.ReadLine();
    Console.WriteLine("Ingrese su grado");
    grado = Console.ReadLine();
    Console.WriteLine("Ingrese su promedio ");
    promediofinal = double.Parse(Console.ReadLine());

    // insertar informacion en el registro
    registronombres[indice] = nombrecompletos;
    registrogrado[indice] = grado;
    registropromedios[indice] = resgistropromedios;
    Console.WriteLine("informacion registrada con exito");
    indice++;
}

