double precio = 100.5;
Console.WriteLine("precio original: " + precio);
precio = calculardescuento(precio);
Console.WriteLine("precio con descuento: " + precio);

double calculardescuento(double _precio)
{
    if(_precio > 80)
    {
        _precio = _precio - (_precio * 0.10);
    }
    Console.WriteLine("valor de precio (copia): " + _precio);
    return _precio;
}