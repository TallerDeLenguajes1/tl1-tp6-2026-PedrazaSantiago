Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);

int invertido=0;
Console.WriteLine("Ingrese el numero a invertir:");
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

Console.WriteLine("Ingrese un texto:");
string cadena1 = Console.ReadLine();
Console.WriteLine("Longitud:"+cadena1.Length);

Console.WriteLine("Ingrese un texto:");
string cadena2 = Console.ReadLine();
string concatenados = string.Concat(cadena1," ",cadena2);
Console.WriteLine("Concatenados:"+ concatenados);

Console.WriteLine("Subcadena:"+ concatenados.Substring(0,3));

Console.WriteLine("Ingrese el primer numero:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
double num2 = double.Parse(Console.ReadLine());
double resultado = num1 + num2;
string mensaje = "la suma de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString();
Console.WriteLine(mensaje);

Console.WriteLine("Caracter por caracter:");
foreach (char letra in cadena1)
{
Console.WriteLine(letra);
}

Console.WriteLine("Palabra contenida en el texto:");
string palabra = Console.ReadLine();
Console.WriteLine(cadena1.Contains(palabra));

Console.WriteLine("Mayusculas:"+ cadena1.ToUpper());
Console.WriteLine("Minusculas:"+ cadena1.ToLower());

Console.WriteLine("Ingrese palabras separadas por coma:");
string texto = Console.ReadLine();
string[] palabras = texto.Split(',');
Console.WriteLine("Palabras separadas:");
foreach (string p in palabras)
{
    Console.WriteLine(p);
}

Console.WriteLine("Ingrese una suma simple:");
string ecuacion = Console.ReadLine();
string[] partes = ecuacion.Split('+');
double numero1 = double.Parse(partes[0]);
double numero2 = double.Parse(partes[1]);
Console.WriteLine("Resultado:"+ (numero1 + numero2));