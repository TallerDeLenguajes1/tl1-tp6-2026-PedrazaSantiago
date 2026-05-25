Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);

int invertido=0;
string num = Console.ReadLine();
if (int.TryParse(num, out int numero))
{
    while(numero > 0)
    {
        int ultDig = numero % 10;
        invertido = (invertido*10) + ultDig;
        numero = numero / 10;  
    }
    Console.WriteLine(invertido);
}
else
{
    Console.WriteLine("No es un numero valido");
}

char continuar;
double num1;
double num2;

do
{
Console.WriteLine("Seleccione una opcion: ");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
string opcion = Console.ReadLine();
if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
{
    Console.WriteLine("\nError: Opción no válida del menú.");
}
else
{
    Console.WriteLine("\nIngrese el primer numero: ");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
    Console.WriteLine("Error, ingrese un numero: ");
    }
    Console.WriteLine("\nIngrese el segundo numero: ");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
    Console.WriteLine("Error, ingrese un numero: ");
    }
    double resultado = 0;

    switch (opcion)
    {
    case "1":
    resultado = num1 + num2;
    Console.WriteLine(resultado);
    break;
    case "2":
    resultado = num1 - num2;
    Console.WriteLine(resultado);
    break;
    case "3":
    resultado = num1 * num2;
    Console.WriteLine(resultado);
    break;
    case "4":
    if (num2 != 0)
    {
        resultado = num1 / num2;
        Console.WriteLine(resultado);
    }
    else
    {
        Console.WriteLine("No se puede dividir por cero");
    }
    break;
    }
    }

    Console.WriteLine("\n¿Desea realizar otro calculo? (s/n): ");
    continuar = char.ToLower(Console.ReadKey().KeyChar);
    } while (continuar == 's');