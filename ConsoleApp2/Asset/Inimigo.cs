namespace Asset
{
    public class Inimigo
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Vida { get; set; }
        public int Cura { get; set; }

        public Inimigo(jogador jogador)
        {
            Random random = new Random();
            Dano = random.Next(1, 5) *jogador.Nivel;
            Vida = random.Next(5, 20) *jogador.Nivel;
            Nome = "Goblin";
        }
    }
}