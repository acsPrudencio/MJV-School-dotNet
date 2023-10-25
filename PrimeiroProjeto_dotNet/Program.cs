
/*
Console.WriteLine("Hello, World!");

Console.WriteLine(Int16.MaxValue);
Console.WriteLine(Int64.MaxValue);
Console.WriteLine(int.MaxValue);


Console.WriteLine(decimal.MaxValue);
Console.WriteLine(double.MaxValue);
Console.WriteLine(float.MaxValue);


*/

/*

Int16 idade = 0;

//Console.Beep();

Console.WriteLine("Digite seu nome: ");

String nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");

String inputIdade = Console.ReadLine();




try{
    idade = Int16.Parse(inputIdade);
}
catch (Exception e){
    throw new ArgumentException("Idade deve ser um valor numerico EX: 25 ");
 //   Console.WriteLine("Idade deve ser um valor numerico EX: 25 ");
 //   return;
}



Console.WriteLine($"Nome : {nome}\nIdade: {idade}");



*/

dynamic idade3 = 100;

Console.WriteLine("idade3 = 100 : " + idade3.GetType());

idade3 = "100";

Console.WriteLine("idade3 = \"100\": " + idade3.GetType());


Object idade4 = 100;
Console.WriteLine("idade4 = 100: " + idade4.GetType());

idade4 = "100";
Console.WriteLine("idade4 = \"100\": " + idade4.GetType());


bool ativo = false;

Console.WriteLine("Valor da variavel ativo: " + ativo);


// Faz com que as variaveis aceitem valores nulos
int ? num = 0;
string ? nome = "";

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString());


var xx = Console.Read();
var yy = Console.ReadKey();

Console.WriteLine(xx+"\n");
Console.WriteLine(yy);