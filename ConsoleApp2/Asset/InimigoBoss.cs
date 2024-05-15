namespace Asset
{
    public class InimigoBoss
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Cura { get; set; }

        public InimigoBoss(jogador jogador)
        {
            Random random = new Random();
            Dano = random.Next(1, 10) *jogador.Nivel*2;
           // Nome = EnumNomeInimigo
        }
    }
}