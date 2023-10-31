// See https://aka.ms/new-console-template for more information

const int TAM = 6;
int[] numerosLoteria = new int[TAM];
int[] numerosParaSortear = new int[59];

//valor do jogo 5 reais

//informe seu nome
//informe o valor disponivel para aposta


//gera os numeros e imprime

for (int i = 1; i < numerosParaSortear.Length; i++)
{
    numerosParaSortear[i] = i;
}

Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();


Console.WriteLine("Informe o valor disponivel para aposta: ");

double valorDisponivel = getValorParaAposta();

int quantidadeDeJogos = (int)(valorDisponivel/5);


for (int i = 0; i < quantidadeDeJogos; i++)
{
    Random random = new Random();

    for (var j = 0; j < TAM; j++)
    {
        var num = random.Next(1,61);
        numerosLoteria[j] = num;
        Console.Write(" " + numerosLoteria[j]);
    }
    Console.WriteLine("\n");

}



double getValorParaAposta()
{
    while (true)
    {
        string valorInput = Console.ReadLine();
        try
        {
            return double.Parse(valorInput);
        }
        catch
        {
            Console.WriteLine("Valor invalido!");
        }
    }
   
}