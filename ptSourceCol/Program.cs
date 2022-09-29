// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una cadena de texto");
string str = Console.ReadLine();


string puntoUno(string cadena)
{
    string aux = "";
    if (cadena.Length < 20)
    {
        return "La cadena: " + cadena + " no tiene mas de 20 caracteres";
    }
    else
    {
        for (int i = 0; i < 20; i++)
        {
            aux += cadena[i];
        }
        return aux + "...";
    }
}

Console.WriteLine(puntoUno(str));
