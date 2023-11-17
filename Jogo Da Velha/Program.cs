using System;
using System.Linq;

class Program
{
    static char[,] matriz = new char[3, 3];
    static bool jogoTerminou = false;

    static void Main()
    {
        Console.WriteLine("JOGO DA VELHA");

        InicializarMatriz();
        ImprimirMatriz();

        char jogadorDaVez = 'X';

        while (!jogoTerminou)
        {
            Console.WriteLine($"Turno do jogador {jogadorDaVez}");
            if (Jogar(jogadorDaVez))
            {
                jogoTerminou = VerificarFimDeJogo(jogadorDaVez);
                jogadorDaVez = (jogadorDaVez == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Posição inválida. Tente novamente.");
            }

            ImprimirMatriz();
        }

        if (jogoTerminou)
        {
            Console.WriteLine($"Jogador {jogadorDaVez} venceu!");
        }
        else
        {
            Console.WriteLine("O jogo terminou empatado!");
        }
    }

    static void InicializarMatriz()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                matriz[i, j] = ' ';
    }

    static void ImprimirMatriz()
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
                Console.Write(matriz[i, j] + (j < 2 ? "|" : "\n"));
            if (i < 2) Console.WriteLine("  -----");
        }
    }

    static bool Jogar(char jogador)
    {
        Console.Write("Informe a linha e a coluna (0-2) separadas por espaço: ");
        var entrada = Console.ReadLine().Split();
        int linha, coluna;

        if (entrada.Length == 2 && int.TryParse(entrada[0], out linha) && int.TryParse(entrada[1], out coluna))
            return MarcarPosicao(linha, coluna, jogador);

        return false;
    }

    static bool MarcarPosicao(int linha, int coluna, char jogador) =>
        (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && matriz[linha, coluna] == ' ') ? (matriz[linha, coluna] = jogador) == jogador : false;

    static bool VerificarFimDeJogo(char jogador)
    {
        for (int i = 0; i < 3; i++)
            if ((matriz[i, 0] == jogador && matriz[i, 1] == jogador && matriz[i, 2] == jogador) ||
                (matriz[0, i] == jogador && matriz[1, i] == jogador && matriz[2, i] == jogador))
                return true;

        if ((matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador) ||
            (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador))
            return true;

        return (jogoTerminou = !matriz.Cast<char>().Any(c => c == ' '));
    }
}