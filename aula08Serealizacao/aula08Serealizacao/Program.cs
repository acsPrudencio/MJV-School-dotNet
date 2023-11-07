
var pessoa = new Pessoa("Carlos",25);
// var carro = new Carro("Corsa",2015);



string jsonPessoa = System.Text.Json.JsonSerializer.Serialize(pessoa);
Console.WriteLine(jsonPessoa);

// string jsonPessoaInput = @"{""nome"":""Maria"",""Idade"":30}";
// Pessoa pessoaDesserializada = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonPessoa);
// Console.WriteLine($"{pessoaDesserializada.nome}, {pessoaDesserializada.idade}");

var aquivo = new FileInfo("arquivo.txt");
using (var writer = aquivo.CreateText())
{
    writer.Write(jsonPessoa);
}



public class Pessoa
{
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
    public string nome { get; set; }
    public int idade { get; set; }
}

// public record Carro(string nome, int ano);