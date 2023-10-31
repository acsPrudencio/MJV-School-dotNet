

using System.Text;

string nome = "   Antonio Carlos Soares Prudencio   ";
string resultado = string.Empty;


// resultado = nome.ToUpper();
// Console.WriteLine(resultado);
//
// resultado = nome.ToLower();
// Console.WriteLine(resultado);
//
//
// resultado = nome.Trim();
// Console.WriteLine(resultado);
//
//
// var resultado2 = nome.Split(" ");
// Console.WriteLine(resultado2);
//
//
// resultado = nome.ToUpper().Length.ToString();
// Console.WriteLine(resultado);
//
// resultado = nome.Replace(" ", "-");
// Console.WriteLine(resultado);
//
// resultado = nome.PadLeft(50, '0');
// Console.WriteLine(resultado);
//
// resultado = nome.PadRight(50, '0');
// Console.WriteLine(resultado);

var resultado3 = nome.Equals("Joao");
Console.WriteLine("Equals: "+resultado3);

resultado = nome.Trim();
Console.WriteLine("Trim: "+resultado);

resultado = nome.TrimStart();
Console.WriteLine("TrimStart: "+resultado);

resultado = nome.TrimEnd();
Console.WriteLine("TrimEnd: "+resultado);

var resultado4 = nome.Remove(10);
Console.WriteLine("Remove: "+resultado4);

resultado = nome.Insert(0,"Carlos");
Console.WriteLine("Insert: "+resultado);

resultado = nome.Normalize();
Console.WriteLine("Normalize: "+resultado);
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");




// StringBuilder stringBuilder = new StringBuilder();
//
// stringBuilder.Append("Antonio");
// Console.WriteLine(stringBuilder);
//
// stringBuilder.Append("Carlos");
// Console.WriteLine(stringBuilder);
//
// stringBuilder.Append("Carlos");
// Console.WriteLine(stringBuilder);



Console.WriteLine("Digite um numero: ");


int num = 0;



try
{
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Numero digitado: " + num);

}
catch (Exception e)
{
    Console.WriteLine("Deu ruim\n" + e.StackTrace);

}
finally
{
    Console.WriteLine("Execultou o finally");
}


