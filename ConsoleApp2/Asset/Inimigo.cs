namespace Asset
{
    public class Inimigo
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Vida { get; set; }
        public int Cura { get; set; }

        public Inimigo(jogador jogador,string NomeInimigo)
        {
            Random random = new Random();
            Dano = random.Next(1, 5) *jogador.Nivel;
            Vida = random.Next(5, 20) *jogador.Nivel;
<<<<<<< HEAD
            Nome = NomeInimigo;
=======
            Nome = "Goblin";
>>>>>>> 3987e8e2017c8fcd615f17c92722945c671137de
        }
    }
    
}