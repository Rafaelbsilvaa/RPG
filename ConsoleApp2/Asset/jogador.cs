namespace Asset
{
    public class jogador
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Dano { get; set; }
        public int Vida { get; set; }
        public int Cura { get; set; }

        public jogador(string nome,int dano)
        {
            Nome = nome;
            Nivel = 1;
            Dano = dano;
            Vida = 10;
        }

        public jogador Subirnivel(jogador jogador)
        {
            jogador.Nivel ++;
            jogador.Dano = jogador.Dano * jogador.Nivel;
            Random random = new Random();
            jogador.Vida = jogador.Vida + random.Next(5,10);
            Console.WriteLine("                                             Jogador Subiu de Nivel");
            return jogador;
        }


    }


}