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

Console.WriteLine("Informe sua data de nascimento EX: dd/MM/yyyy: ");



DateTime dataNascimento = getDataNascimento();


DateTime hoje = DateTime.Now;
int idade = getIdade(dataNascimento, hoje);
int anosRestante = (105 - idade);
Console.WriteLine($"{nome} você tem {idade} anos");
Console.WriteLine($"Tempo de vida restante até completar 105 anos: {anosRestante}");
Console.WriteLine($"Ultimo dia de vida: {hoje.AddYears(anosRestante).ToShortDateString()}");

Console.ReadLine();


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
    while (true)
    {
        string dataNascimentoInput = Console.ReadLine();
        try
        {
            return DateTime.Parse(dataNascimentoInput);
        }
        catch
        {
            Console.WriteLine("Data invalida!\nInforme uma data no formado. EX: dd/MM/yyyy");
            //throw new ArgumentException("Informe uma data valida");
        }
    }
   
}





