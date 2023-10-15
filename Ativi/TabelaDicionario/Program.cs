using System.Collections;


HashTable openWith = new HashTable();

try

{
    openWith.Add("txt","notepad.exe");
    openWith.Add("bmp","paint.exe");
    openWith.Add("dib","paint.exe");
    openWith.Add("rft","wordpad.exe");
}

/*catch(ArgumentExeception aex)
{
    Console.WriteLine("ops. Voce tentou adcionar uma chave que ja existe")
    Console.WriteLine($"Detalhes:{aex.Message}");
}*/
catch(Exeption ex)
{
    Console.WriteLine("Erro generico");
    //throw ex;

}

// Acessando o conteudo a tabela hash
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"] );

// Alterando o conteudo da tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine("Na \\ chave = \"rtf\" é {0}", openWith["rtf"] );

//Testar se chave existe na hash
if(!openWith.Containskey("ht"))
{
    openWith.Add ("ht", "hypertm.exe");
    Console.WriteLine("Chave ht adicionada.");

}

// Percorrendo hash com foreach
Console.WriteLine();
foreach( DictionaryEntry de in openWith )
{
    Console.WriteLine(
        "Key = {0} - Value = {1}"
        , de.Key
        , de.Value"
        );
}

// Obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}

// Remover registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.Containskey("doc"))
{
    Console.WriteLine(
        "Chave \"doc\" foi remivida."
    );
}
Console.WriteLine("Program ainda em execução");
