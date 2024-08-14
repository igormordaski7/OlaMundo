// Console.WriteLine("Hello, World! ");

/*
1. Tipos de variáveis var, int, short, long, decimal, double, bool e string; */
using System.Globalization;

int a = 10;
int b = 5;
/* long c = 100;
float f = 10.50f;
double d = 10.5;*/

/*
2. Operadores de atribuição, aritméticos, relacionais, lógicos e unários; */

int r = a + b;
System.Console.WriteLine("{0} + {1} = {2}", a, b, r);

System.Console.Write("Informe a primeira nota: ");
var nota1 = Console.ReadLine();

System.Console.Write("Informe a segunda nota: ");
var nota2 = Console.ReadLine();

var media = Convert.ToDouble(nota1, CultureInfo.InvariantCulture) + Convert.ToDouble(nota2, CultureInfo.InvariantCulture) / 2;

if (media < 6) {
    System.Console.WriteLine("Aluno reprovado");
} else {
    System.Console.WriteLine("Aluno aprovado");
}

System.Console.WriteLine($"Nota final: {media.ToString("F1", CultureInfo.InvariantCulture)}");

/*
3. Estruturas de decisão if/else, ternárias e switch; */




/*
4. Estruturas de repetição while, do/while, for, foreach;
5. Arrays.
*/

