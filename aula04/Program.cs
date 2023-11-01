// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using aula04;
/*
Forma bolo = new Forma();
bolo.RetornaNomeTuplaForma();

string retornoXpto = bolo.xpto(
    validade:5,
    nome:"Cenoura"
    );

Console.WriteLine( retornoXpto );
*/


//DateTime data = new DateTime();

//Console.WriteLine
//Console.WriteLine($"Data atual: {DateTime.Now}");

//Carro kombi = new Carro();
//Carro celta = new Carro("Celtinha");

//Console.WriteLine(celta.Nome);


//Console.WriteLine($"O carro está ligado: {celta.LigarCarro()}");
//Console.WriteLine($"O carro está ligado: {celta.DesligarCarro()}");

// ele vive 105
// esposa 100


//entrada 
//    nome'
//    dataNascimento
//calcular ate q dia estarei vivo

int contador = 0;
List<Pessoa> pessoas = new List<Pessoa>();
int idade = 0;
var anosRestante = 0;


while(contador < 3 ){
    Console.WriteLine("\n\n\n\n\n\n\n");

    var nome = getName();
    DateTime dataNascimento = getDataNascimento();
    DateTime hoje = DateTime.Now;
    idade = getIdade(dataNascimento, hoje);
    anosRestante = getYeasRemaining(idade);
    showInfo(nome, idade, anosRestante, hoje);
    addPessoaToList(nome, idade, anosRestante, hoje, pessoas);
    contador++;
}

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

foreach (var pessoa in pessoas)
{
    showInfo(pessoa.nome, pessoa.idade, pessoa.anosRestante, pessoa.dataDoCalculo);
    Console.WriteLine("\n");
}





int getIdade(DateTime dataNascimento, DateTime hoje)
{
    int idade = 0;
    idade = (hoje.Year - dataNascimento.Year);

    if (hoje.Month < dataNascimento.Month || (hoje.Month == dataNascimento.Month && hoje.Day < dataNascimento.Day))
    {
        idade--;
    }
    return idade;
}


DateTime getDataNascimento()
{
    Console.WriteLine("Informe sua data de nascimento EX: dd/MM/yyyy: ");
    while (true)
    {
        try
        {
            return DateTime.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Data invalida!\nInforme uma data no formado. EX: dd/MM/yyyy");
        }
    }
   
}


string getName()
{
    while (true)
    {

        Console.WriteLine("Digite seu nome ");

        string nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome invalido!\n");
        }else {
            return nome;
        }
    }
}

int getYeasRemaining(int i)
{
    int anosRestante1 = (100 - i);
    return anosRestante1;
}

void showInfo(string nome, int idade, int i1, DateTime hoje)
{
    Console.WriteLine($"{nome} você tem {idade} anos");
    Console.WriteLine($"Tempo de vida restante até completar 100 anos: {anosRestante}");
    Console.WriteLine($"Ultimo dia de vida: {hoje.AddYears(i1).ToShortDateString()}");
}

void addPessoaToList(string nome, int idade, int anosRestante, DateTime hoje, List<Pessoa> pessoas)
{
    Pessoa p = new Pessoa();
    p.nome = nome;
    p.idade = idade;
    p.anosRestante = anosRestante;
    p.dataDoCalculo = hoje;
    pessoas.Add(p);
}


