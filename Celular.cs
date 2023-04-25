using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CLASSE_CELULAR_EXERCICIO
{
    public class Celular
    {
//         Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.
public string cor;
public string modelo;

public string tamanho;

public bool onoff;


public void ligar()
{Console.WriteLine($"YOUR DEVICE IS TURNING ON...");}


public void desligar()
{Console.WriteLine($"YOUR DEVICE IS TURNING OFF...");}
public void fazerLigacao()
{Console.WriteLine($"DIGITE O NUMERO DE TELEFONE");
string numeroDigitado = Console.ReadLine();
Console.WriteLine($"");
Console.WriteLine($"Ligando para {numeroDigitado}");




}
public void enviarMensagem()
{Console.WriteLine($"Escreva sua mensagem:");
string mensagem = Console.ReadLine();

}



    }
}