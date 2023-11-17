using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> tabelaHash = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Insira um par chave-valor (CPF Nome) ou digite 'sair' para encerrar:");

            string entrada = Console.ReadLine().Trim();

            if (entrada.ToLower() == "sair")
                break;

            string[] dados = entrada.Split(' ');

            if (dados.Length != 2)
            {
                Console.WriteLine("Formato inválido. Insira CPF e Nome separados por espaço.");
                continue;
            }

            string cpf = dados[0];
            string nome = dados[1];

            try
            {
                InserirDados(tabelaHash, cpf, nome);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        Console.WriteLine("\nDados inseridos:");

        foreach (var par in tabelaHash)
        {
            Console.WriteLine($"CPF: {par.Key} - Nome: {par.Value}");
        }
    }

    static void InserirDados(Dictionary<string, string> tabela, string cpf, string nome)
    {
        if (tabela.ContainsKey(cpf))
        {
            throw new ArgumentException($"Chave '{cpf}' já foi inserida previamente.");
        }

        tabela.Add(cpf, nome);
        Console.WriteLine($"Dados inseridos: CPF: {cpf} - Nome: {nome}");
    }
}
