// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Asset;
using Enum;
class Program
{


    static void Main(string[] args)
    {

        var Textos = new Texto();

        Textos.ExibirMenu();
        Textos.Exibir1Texto();
        jogador jogador = new jogador("Kael", 5);



        Random random = new Random();
        
        Inimigo Inimigo1 = new Inimigo(jogador,( (NomesFase1)random.Next(0,3)).ToString()); 


        
        Batalha batalha = new Batalha();
        batalha.IniciarBatalha(jogador, Inimigo1);


        



    }
}

