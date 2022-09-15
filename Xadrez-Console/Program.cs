using Tabuleiro;
namespace Xadrez_Console
{
    class Program
    {
        static void Main(String[] args)
        {
            TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
