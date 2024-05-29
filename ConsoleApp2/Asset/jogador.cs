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
        
        public Tuple<jogador,Inimigo> Batalha(jogador jogador,Inimigo inimigo)
        {
            Console.WriteLine("Jogador ataca causando "+ jogador.Dano);
            inimigo.Vida = inimigo.Vida - jogador.Dano;
            if(inimigo.Vida <= 0)
            {
                Console.WriteLine("Inimigo Derrotado");
                jogador =  Subirnivel(jogador);
            }
            if (inimigo.Vida > 0)
            {
                Console.WriteLine("Inimigo com "+ inimigo.Vida +" de vida restante");
                Console.WriteLine("Inimigo ataca causando " + inimigo.Dano);
                jogador.Vida = jogador.Vida - inimigo.Dano;
                Console.WriteLine("Jogador com " + jogador.Vida + " de vida restante");
                
            }
            return Tuple.Create(jogador, inimigo);
        }


    }


}