// Exercício do site URI "Divisores I"
// Esse programa o usuario irá digitar um número inteiro, e em seguida o programa vai mostrar na tela os numeros divisores de 1 até o numero digitado "N".

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i ++)
{
    if (N % i == 0)
    {
        Console.WriteLine(i);
    }
}