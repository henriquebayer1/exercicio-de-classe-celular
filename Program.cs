
using POO_CLASSE_CELULAR_EXERCICIO;

Celular sansung = new Celular();



     Console.WriteLine($"YOUR DEVICE IS STARTING SYSTEM...");
     Console.WriteLine($"");
     Console.WriteLine(@$" 
     CELLPHONE MENU :
     
     Selecione a funcao que deseja utilizar:

     1 - ligar 
     2 - desligar 
     3 - fazer ligação 
     4 - enviar mensagem ");
     char opcaoDeMenu = char.Parse(Console.ReadLine());
     
switch (opcaoDeMenu)
{
    case '1':
    sansung.ligar();
        break;
    case '2':
    sansung.desligar();
        break;
    case '3':
sansung.fazerLigacao();
        break;
    case '4':
    sansung.enviarMensagem();
        break;
    default:
    Console.WriteLine($"ERROR, SELECT A VALID OPTION");
    
        break;
}

if (opcaoDeMenu == '1')
{
    
}





      

