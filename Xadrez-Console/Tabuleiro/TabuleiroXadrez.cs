namespace Tabuleiro
{
    public class TabuleiroXadrez
    {
        public int Linhas { get; set; } 
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public TabuleiroXadrez(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

    }
}