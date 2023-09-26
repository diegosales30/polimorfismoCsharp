using System;

namespace Polimorfismo
{
  class Program 
  {
    static void Main(string[] args)
    {
      //ESTAGIARIO
      Imposto estagiario = new Estagiario();
      estagiario.ValeAlimentacao(1000);
      estagiario.ValeTransporte(1000);
      Console.WriteLine("====================");

      //GERRENTE
      Imposto gerente = new Gerente();
      gerente.ValeAlimentacao(5000);
      gerente.ValeTransporte(5000);
      Console.WriteLine("====================");

      //ATENDENTE
      Imposto atendente = new Atendente();
      atendente.ValeAlimentacao(2000);
      atendente.ValeTransporte(2000);
      Console.WriteLine("====================");


    }
  }
}