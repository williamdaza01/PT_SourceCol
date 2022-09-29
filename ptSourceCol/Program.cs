// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using ptSourceCol;
using System.Linq;
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

Console.WriteLine(perteneceFibonacci(num));

//Punto 4

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

//Punto 4

Carro aveo = new Carro("chevrolet", "negro", 2014);
Carro mazda3 = new Carro("mazda", "blanco", 2019);
Carro sandero = new Carro("renault", "gris", 2010);
Carro fiesta = new Carro("ford", "gris", 2016);
Carro captiva = new Carro("chevrolet", "dorada", 2020);
Carro fortuner = new Carro("toyota", "blamco", 2021);

List<Carro> carros = new List<Carro>();

carros.Add(aveo);
carros.Add(mazda3);
carros.Add(sandero);
carros.Add(fiesta);
carros.Add(captiva);
carros.Add(fortuner);

List<Carro> obtenerCincoAno(List<Carro> carros)
{
List<Carro> carros1 = new List<Carro>();
var query = from car in carros
            where DateTime.Now.Year - car.model <= 5
            select car;

foreach(var item in query)
{
    carros1.Add(item);
}
return carros1;
}

var car = obtenerCincoAno(carros);

foreach(var item in car)
{
Console.WriteLine(item.model);
}*/

//Punto 5

using(var client = new HttpClient())
{
    string url = "https://rickandmortyapi.com/api/character";

    client.DefaultRequestHeaders.Clear();
    var response = client.GetAsync(url).Result; 
    var res = response.Content.ReadAsStringAsync().Result;
    JObject r = JObject.Parse(res);

    foreach(var item in r["results"])
    {
        Console.WriteLine(item["name"]);
    }

}






