double precio = 100.5;
Console.WriteLine("precio original: " + precio);
calculardescuento(ref precio);
Console.WriteLine("precio con descuento: " + precio);

void calculardescuento(ref double _precio)
{
    if(_precio > 80)
    {
        _precio = _precio - (_precio * 0.10);
    }
    Console.WriteLine("valor de precio (copia): " + _precio);
    
}