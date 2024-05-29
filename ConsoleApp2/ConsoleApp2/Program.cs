// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Asset;
class Program
{


    static void Main(string[] args)
    {

        var Textos = new Texto();

        Textos.ExibirMenu();
        Textos.Exibir1Texto();
        jogador jogador = new jogador("Kael", 5);



        Inimigo Inimigo1 = new Inimigo(jogador);
        Batalha batalha = new Batalha();
        batalha.IniciarBatalha(jogador, Inimigo1);


        //========================================================================



    }
}

