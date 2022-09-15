using Tabuleiro;
namespace Xadrez_Console
{
    public class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroXadrez Tab)
        {
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (Tab.CriarPeca(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write($"{Tab.CriarPeca(i, j)} ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}