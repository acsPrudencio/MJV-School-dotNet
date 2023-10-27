// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int numero1 = 10;
int numero2 = numero1;

Console.WriteLine("numero1: " + numero1);
Console.WriteLine("numero2: " + numero2);

numero2 = 20;

Console.WriteLine("Depois da nova atribuição de numero2");
Console.WriteLine("numero1: " + numero1);
Console.WriteLine("numero2: " + numero2);


numero1 = 15;

Console.WriteLine("Depois da nova atribuição de numero1");
Console.WriteLine("numero1: " + numero1);
Console.WriteLine("numero2: " + numero2);

string nome = "antonio";


Console.WriteLine("Nome inicial: " + nome);

mudarNome();

Console.WriteLine("Nome atualizado: " + nome);

void mudarNome(){
    nome = "carlos";
}



