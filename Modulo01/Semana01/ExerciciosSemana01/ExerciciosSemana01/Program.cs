//EXERCÍCIO 1

//Faça um programa que receba do usuário dez números inteiros, e ao final, exiba os números primos e suas respectivas posições.

int[] vet = new int[10];
int count = 0;

Console.WriteLine("Digite " + vet.Length + " números");

for (int i = 0; i < vet.Length; i++)
{
    Console.Write("vetor[" + i + "]: ");
    vet[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0; i < vet.Length; i++)
{
    int divider = 0;

    for (int j = 0; j <= vet[i]; j++)
    {
        if (vet[i] % (j + 1) == 0)
        {
            divider++;
        }
    }
    if (divider == 2)
    {
        count++;
        Console.WriteLine("o numero " + vet[i] + " é um numero primo e está no índice  " + i + " do array");
    }
}
Console.WriteLine();
Console.WriteLine("Total de números primos encontrados " + count);


//EXERCÍCIO 2

//Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens. Organize as frutas em ordem alfabética e exiba a lista.

List<string> listaDeFrutas = new List<string>();

bool continuar = true;
while (continuar)
{
    if (listaDeFrutas.Count() == 15)
    {
        continuar = false;
    }
    Console.Write("Digite o nome de uma fruta: ");
    listaDeFrutas.Add(Console.ReadLine());
    Console.Write("Deseja continuar? Responda [s] para sim ou [n] para não: ");

    string resposta = Console.ReadLine();
    if (resposta == "n" || resposta == "nao")
    {
        continuar = false;
    }
}

listaDeFrutas.Sort();

foreach (string fruta in listaDeFrutas)
{
    Console.WriteLine(fruta);
}

//EXERCÍCIO 3

//Faça um programa que receba do usuário dez números inteiros e execute os seguintes passos:
//Separe em duas listas sendo um somente números ímpares e o outro números pares.
//Coloque os números de cada lista em ordem crescente.
//Exiba como resultado o número de elementos em cada lista e a soma dos valores de cada um. Ex: “A lista de números ímpares possui 5 números e a soma deles é igual a 47”


List<int> numerosPares = new List<int>();
List<int> numerosImpares = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    int num = int.Parse(Console.ReadLine());

    // verifica se o número é ímpar ou par
    if (num % 2 == 0)
    {
        numerosPares.Add(num);
    }
    else
    {
        numerosImpares.Add(num);
    }
}

// coloca os números em ordem crescente
numerosImpares.Sort();
numerosPares.Sort();

// o método Sum() faz a soma dos números de uma lista
Console.WriteLine($"A lista de números ímpares possui {numerosImpares.Count()} números e a soma deles é igual a {numerosImpares.Sum()}");
Console.WriteLine($"A lista de números pares possui {numerosPares.Count()} números e a soma deles é igual a {numerosPares.Sum()}");


//EXERCÍCIO 4

//Faça um programa que receba o nome e média final de cinco alunos. Armazene em um array ou list os nomes e em outra as médias. Ao final, exiba o nome de cada aluno e a mensagem “APROVADO” para quem tiver média acima de 6 e “REPROVADO” para quem não.


string[] nomeAlunos = new string[5];
decimal[] mediaAlunos = new decimal[5];

// recebe o nome e as médias dos alunos
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomeAlunos[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1}º aluno: ");
    mediaAlunos[i] = decimal.Parse(Console.ReadLine());
}

// verifica as médias e exibe se o aluno está aprovado ou não
for (int i = 0; i < 5; i++)
{
    if (mediaAlunos[i] >= 6)
    {
        Console.WriteLine($"O aluno {nomeAlunos[i]} está APROVADO");
    }
    else
    {
        Console.WriteLine($"O aluno {nomeAlunos[i]} está REPROVADO");
    }
}


//EXERCÍCIO 5

//Faça um algoritmo que receba um número inteiro que será a quantidade de números calculados pela sequência de Fibonacci. Em seguida, exiba a sequência no terminal. 
//Ex: Se receber o número 7, você irá exibir a sequência “1 2 3 5 8 13 21” que contém ao todo 7 números.

int n;
int x = 1, y = 0, z = 0;

// lê a quantidade de número da sequência a ser exibidos
string number = Console.ReadLine();

n = int.Parse(number);

// cria a sequência de Fibonacci
for (int i = 0; i < n; i++)
{

    // a sequência consiste em somar o anterior (y) com o número atual (x) e o resultado
    // será o próximo número (z)
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
Console.ReadLine();

