
using POO_CLASSE_CELULAR_EXERCICIO;

Celular sansung = new Celular();



     Console.WriteLine($"YOUR DEVICE IS STARTING SYSTEM...");
     Console.WriteLine($"");
     Console.WriteLine(@$" 
     CELLPHONE MENU :
     
     Selecione a funcao que deseja utilizar:

     1 - ligar 
     2 - desligar 
    ");
     char opcaoDeMenu = char.Parse(Console.ReadLine());
     
switch (opcaoDeMenu)
{
    case '1':
    sansung.ligar();
        break;
    case '2':
    sansung.desligar();
        break;
    default:
    Console.WriteLine($"ERROR, SELECT A VALID OPTION");
     break; //BREAK DO DEFAULT DO SWITCH DO MENU
}

if (opcaoDeMenu == '1')
{Console.WriteLine(@$"Menu do dispositivo:

1- fazer ligacao 
2 - enviar mensagem
");
char opcaoDeMenuOn = char.Parse(Console.ReadLine());

switch (opcaoDeMenuOn)
{
     case '1':
sansung.fazerLigacao();
        break;
    case '2':
    sansung.enviarMensagem();
        break;
    default:
    Console.WriteLine($"Selecione uma das opçoes corretamente!");
    break;
    
}

    
}





      

