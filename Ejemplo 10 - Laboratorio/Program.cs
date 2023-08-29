Console.WriteLine("Ingrese el primer numero:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero:");
int numero2 = int.Parse(Console.ReadLine());

while (numero1 == numero2)
{
    Console.WriteLine("El segundo numero es igual al primero. Por favor ingrese un numero diferente:");
    numero2 = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ingrese el tercer numero:");
int numero3 = int.Parse(Console.ReadLine());

while (numero3 == numero1 || numero3 == numero2)
{
    Console.WriteLine("El tercer numero es igual a uno de los anteriores. Por favor ingrese un numero diferente:");
    numero3 = int.Parse(Console.ReadLine());
}

int mayor = numero1;

if (numero2 > mayor)
{
    mayor = numero2;
}

if (numero3 > mayor)
{
    mayor = numero3;
}

Console.WriteLine($"El mayor de los tres numeros es: {mayor}");