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


Console.WriteLine("Informe deu nome: ");

string nome = Console.ReadLine();


Console.WriteLine("Informe sua data de nascimento: ");


string dataNascimentoInput = Console.ReadLine();

DateTime dataNascimento = converteData(dataNascimentoInput);


DateTime hoje = DateTime.Now;
int idade = CalcularIdade(dataNascimento, hoje);
int anosRestante = (105 - idade);
Console.WriteLine($"Idade atual: {idade}");
Console.WriteLine($"Anos de vida restante: {anosRestante}");
Console.WriteLine(hoje.AddYears(anosRestante).ToShortDateString());



int CalcularIdade(DateTime dataNascimento, DateTime hoje)
{
    int idade = 0;
    idade = (hoje.Year - dataNascimento.Year);

    if (hoje.Month < dataNascimento.Month || (hoje.Month == dataNascimento.Month && hoje.Day < dataNascimento.Day))
    {
        idade--;
    }
    return idade;
}


DateTime converteData(string dataNascimento)
{
    try
    {
       return DateTime.Parse(dataNascimento);
    }
    catch
    {
        throw new ArgumentException("Idade deve ser um valor numerico EX: 25 ");

    }
}






