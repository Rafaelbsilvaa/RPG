using System.Reflection.Metadata;

namespace Asset
{
    
    public class Texto

    {

        public void ExibirMenu()
        {
            Console.WriteLine(@"                                                       ARKANIA                                           
                                                         ##                      
                                                         ##                      
                                                         ##                      
                                                         ##                      
                                                         ##                      
                                                  
                                                  ################                
                                                  
                                    ################  ####  ##  ################  
                                          ##########  ####  ##  ##########        
                                    ########      ##  ####  ##  ##      ######    
                                      ##########  ##  ####  ##  ##  ##########    
                                                  ##  ####  ##  ##                
                                        ########  ##  ####  ##  ##  ########      
                                                ##    ####  ##    ##              
                                          ######      ####  ##      ######        
                                                      ####  ##                    
                                                      ####  ##                    
                                                      ####  ##                    
                                                      ####  ##                    
                                                      ########                    
                                                        ######                    
                                                          ##                      
                                                                                  ");
            Console.WriteLine("                                             Pressione Qualquer Tecla!");

            Console.ReadKey();
            Console.Clear();
        }

        public void Exibir1Texto()
        {
            Console.WriteLine(@"
No mundo de Arkania, uma aura mortal assola as terras outrora pacíficas. 
O equilíbrio entre humanos e criaturas místicas foi rompido, e monstros 
que antes eram dispersos agora se reúnem em hordas vorazes,assolando os 
reinos humanos como uma maré negra. No meio desse caos, 
um jovem aventureiro inexperiente, 
chamado Kael, acabou de ingressar na prestigiosa Guilda dos Aventureiros. 




");
            Console.WriteLine("                                             Pressione Qualquer Tecla!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}