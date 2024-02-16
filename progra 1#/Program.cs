Console.WriteLine(" conversion de entero a decimal el cual es 500:");
int num1 = 500;
decimal num2 = (decimal)num1;
Console.WriteLine(num2);
Console.WriteLine("convresion de decimal a flotante el cual es 400.0090:");
decimal num3 = 400.0090m;
float num4 =(float)num3;
Console.WriteLine(num4);
Console.WriteLine("convresion de un caracter a entero es cual es b :");
char num5 = 'b';
int num6 = num5 - 48;
Console.WriteLine(num6);
Console.WriteLine("conversion de entero a caracter la cual es 50 es :");
int num7 = 50;
char num8 = (char)(num7 + 48);
Console.WriteLine(num8);
Console.WriteLine("conversion de flotante a entero el cual es un 34.56500F");
float num9 = 34.56500f;
int num10 = (int)num9;
Console.WriteLine(num10);
int num1r = 20;
int num2r = 30;
int num3r;
num3r = num1r + num2r;
Console.WriteLine("la suma de dos enteros que son 20 y 30 es :");
Console.WriteLine(num3r);
Console.WriteLine("la resta de dos numeros decimales los cuales son 450.0090-3450.00080: el resultado es :");
decimal num4r = 450.0090m;
decimal num5r = 3450.00080m;
decimal num6r = num4r - num5r;
Console.WriteLine(num6r);
Console.WriteLine("multipicacion de numeros flotantes los cuales son 30.0e0F y 50.9e0F es :");
float num7r = 30.0e0F;
float num8r = 50.9e0f;
float num9r = num7r * num8r;
Console.WriteLine(num9r);
Console.WriteLine("division de dos numeros enteros los cuales 20 y 30  ");
float num10r = num1r / num2r;
Console.WriteLine(num10r);
Console.WriteLine("el calculo del modulo de dos enteres los cuales son 20 y 30 son:");
int num11r = num1r % num2r;
Console.WriteLine(num11r);
Console.WriteLine("cadena de texto y la imprima en mayusculas la cual es 'hola como le va ing'");
string palabra = "hola como le va ing";
Console.WriteLine(palabra.ToUpper());
Console.WriteLine("cadena de texto y la imprima en minusculas la cual es 'TODO LO QUE HAGO ME SALE BIEN'");
string palabra2 = "TODO LO QUE HAGO ME SALE BIEN";
Console.WriteLine(palabra2.ToLower());
Console.WriteLine("cadena de texto que la imprima al reves la cual es hola mundo");
Console.WriteLine("escribe una cadena de texto al reves");
string cadena1 = "hola mundo";
string cadenaInvertida = "";
for (int i = cadena1.Length - 1; i >= 0; i--)
{
    cadenaInvertida += cadena1[i];
}
Console.WriteLine("La cadena al revés es:", cadenaInvertida);
Console.WriteLine("escribe una palabra y busca su posicion por ejemplo tenesmo la cadena hola mundo");
string cadena9 = "Hola mundo!";
string palabra3 = "mundo";
int indice = cadena9.IndexOf(palabra3);
string mensaje = indice == -1 ? "La palabra no se encuentra en la cadena." : $"La palabra se encuentra en la posición {indice}";
Console.WriteLine(mensaje);
Console.WriteLine("contar una cadena de texto cuantas vocales tiene  la cual usaremos hola mundo");
string cadena = "Hola mundo!";
int numeroVocales = cadena.Count(c => "aeiouAEIOU".Contains(c));
Console.WriteLine($"La cadena contiene {numeroVocales} vocales.");
Console.WriteLine("vamos a calculas el area de un triangulo ");
Console.WriteLine("el cual tiene de base 12m y al tura 15m y sus lados son de 16.16m");
double par1 = 12d;
double par2 = 15.85d;
double par3 = 16.16d;
double par4 = par1 * par2 / 2;
double par5 = par1 + par3 * 2;
Console.WriteLine("su area es de :" + par4);
Console.WriteLine("superimetro es de :" + par5);
Console.WriteLine("vamos a calcular el volumen de una esfera ");
Console.WriteLine("el cual tiene de  un radio de 5cm ");
double par6 = 4d;
const double par7 = 3.1416d;
double par8 = 5 * 5 * 5;
double par9 = par6 * par7 * par8 / 3;
Console.WriteLine("el volumen de una esfera es:" + par9);
Console.WriteLine("hahora calcularemos la distancia entre dos puntos los cuales son: ");
Console.WriteLine("x1(valor de 5),x2(valor de 7) y y1(valor de 8),y2(valor de 23)");
double par10 = 5d;
double par11 = 7d;
double par12 = 8d;
double par13 = 23d;
double par14 = (par10 - par11) * (par10 - par11);
double par15 = (par12 - par13) * (par12 - par13);
double par16 = par14 + par15;
double par17 = Math.Sqrt(par16);
Console.WriteLine("el resultado de la distancia es :" + par17);
Console.WriteLine("vamos a calcular grados F A GRADOS C el cual es 75 grados f");
double par18 = 75d;
double par21 = par18 - 32d;
double par19 = 0.5556d;
double par20 = par19 * par21;
int par22 = (int)par20;
Console.WriteLine("los grados celsius son:" + par22);
Console.WriteLine("hahora convertimos grados c a grados f el cual es 50 grados c");
double par23 = 50d;
double par24 = 1.8d;
double par25 = par23 * par24;
double par26 = par25 + 32d;
Console.WriteLine(" el re sultado en f es de :" + par26);

























