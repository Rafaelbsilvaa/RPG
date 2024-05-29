using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset
{
    public class Batalha
    {
        public bool BatalhaTurno(bool Opcao,jogador jogador,Inimigo inimigo)
        {
            if (Opcao)
            {
               
            }
            return true;
        }

        public void IniciarBatalha(jogador jogador, Inimigo inimigo)
        {
            Console.WriteLine($"Uma batalha começou entre {jogador.Nome} e {inimigo.Nome}!");

            while (jogador.Vida>0 && inimigo.Vida>0)
            {
                Console.WriteLine("Escolha sua ação:");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Usar Item");
                Console.WriteLine("3. Fugir");

                int escolha = Convert.ToInt32(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        var resultado = jogador.Batalha(jogador,inimigo);
                        jogador = resultado.Item1;
                        inimigo = resultado.Item2;
                        break;
                    case 2:

                        Console.WriteLine("Você usou um item!");
                        break;
                    case 3:
                        Console.WriteLine("Você fugiu da batalha!");

                        break;
                    default:
                        Console.WriteLine("Escolha inválida!");
                        break;
                }
            }

            
           
        }
    }
}
