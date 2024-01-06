// See https://aka.ms/new-console-template for more information

// Conversão implicita
float x = 4.5f; //4 bytes
double y = x;   // 8 bytes

Console.WriteLine(y);

// Conversão explicita
double a; // 8 bytes
int b; // 4 bytes

a = 5.1;
b = (int)a;

Console.WriteLine(b);

int aa = 5;
int bb = 2;

double resultado = aa / bb; // Gera uma divião inteira
Console.WriteLine(resultado);

double resultado2 = (double)aa / bb; // Gera uma divião double
Console.WriteLine(resultado2);