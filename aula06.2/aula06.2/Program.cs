
using System.Collections;

ArrayList numeros = new ArrayList();


for (var i = 0; i < 100; i++)
{
    numeros.Add(i);
    
}

foreach (var numero in numeros)
{
    Console.Write(" "+numero);
}
Console.WriteLine();
Hashtable hashtable = new Hashtable();

hashtable.Add(1,"Bolo de Chocolate");
hashtable.Add(2,"Bolo de Cenoura");
hashtable.Add(3,"Bolo de Laranja");
hashtable.Add(4,"Bolo de Café");


Console.WriteLine("Hashtable");
foreach (DictionaryEntry item in hashtable)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

HashSet<int> numerosHashSet = new HashSet<int>();

numerosHashSet.Add(5);
numerosHashSet.Add(5);
numerosHashSet.Add(5);
numerosHashSet.Add(6);
numerosHashSet.Add(1);

Console.WriteLine("HashSet");
foreach (var num in numerosHashSet)
{
    Console.WriteLine(num);
}

SortedSet<int> numerosSortedSet = new SortedSet<int>();

numerosSortedSet.Add(99);
numerosSortedSet.Add(1);
numerosSortedSet.Add(9);
numerosSortedSet.Add(99);


Console.WriteLine("SortedSet");
foreach (var num in numerosSortedSet)
{
    Console.WriteLine(num);
}
