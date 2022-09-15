namespace Tabuleiro
{
    public class TabuleiroXadrez
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;

        public TabuleiroXadrez(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas];
        }

        public Peca CriarPeca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }

    }
}