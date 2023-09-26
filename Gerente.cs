using System;

class Gerente : Imposto
{
  //metodo
  public override void ValeAlimentacao(double salario)//OVERRIDE, POLIMORFISMO
  {
    Console.WriteLine("Desconto GERENTE do vale alimentação R$"+(salario * 0.15));
  }
}