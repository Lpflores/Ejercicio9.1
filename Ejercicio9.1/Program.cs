
Console.WriteLine("Ingrese la longitud deseada del vector: ");
var dato = Console.ReadLine();
Console.WriteLine();
int n  = int.Parse(dato);
int[] vector = new int[n];
Random aleatorio = new Random();


for (int i = 0; i < vector.Length; i++)
{
   
    vector[i] = aleatorio.Next();

}
Console.WriteLine("El vector generado es:");
foreach (int valor in vector)
{
    Console.WriteLine(valor + " ");

}

for (int i = 0; i < vector.Length / 2; i++)
{
    int j = vector.Length - i - 1;
    int invertido = vector[j];
    vector[j] = vector[i];
    vector[i] = invertido;

}

Console.WriteLine("El vector invertido es: ");
    foreach(int valor in vector)
{
    Console.WriteLine(valor + " ");

}



