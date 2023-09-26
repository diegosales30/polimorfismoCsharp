using System;

class Atendente : Imposto
{
  //metodo
  public override void ValeAlimentacao(double salario)
  {
    Console.WriteLine("Desconto ATENDENTE do vale alimentação R$"+(salario * 0.12));
  }
}