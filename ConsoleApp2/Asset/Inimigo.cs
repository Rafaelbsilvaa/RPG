namespace Asset
{
    public class Inimigo
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Cura { get; set; }

        public Inimigo(jogador jogador)
        {
            Random random = new Random();
            Dano = random.Next(1, 10) *jogador.Nivel;
           // Nome = EnumNomeInimigo
        }
    }
}