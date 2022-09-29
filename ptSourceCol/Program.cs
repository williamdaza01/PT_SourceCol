// See https://aka.ms/new-console-template for more information
//Punto 1
/*Console.WriteLine("Ingrese una cadena de texto");
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

//Punto 2
Console.WriteLine("Ingrese un numero");
string str = Console.ReadLine();

string perteneceFibonacci(int n)
{
    int n1 = 1;
    int n2 = 1;
    int limite = 10000;
    string cad = "";

    for(int i = 2; i <= limite; i++)
    {
        if (n == n2)
        {
            cad="El numero: " + n + " si se encuentra en la secuencia";
            break;
        } 
        else if (i < limite)
        {
            n2 += n1;
            n1 = n2-n1;
        }
        else
        {
            cad="El numero no se encuentra en la secuencia";
        }
    }
    return cad;
}

int num = Int32.Parse(str);

Console.WriteLine(perteneceFibonacci(num));*/

int[] arrNum = new int[] { 5, 1, 4, 6, 8, 12, 35, 81, 2 };

int[] contarPares(int[] arr)
{
    int cont = 0;
    Array.Sort(arr);
    Array.Reverse(arr);

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            cont++;
        }
    }
    Console.WriteLine("La cantidad de numeros pares es: "+cont);
    return arr;
}

contarPares(arrNum);
for(int i = 0; i<arrNum.Length; i++)
{
    Console.WriteLine(arrNum[i]); 

}




