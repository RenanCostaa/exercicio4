using System;
//4. Faça um Programa que peça as 4 notas bimestrais e mostre a média
class MainClass {
  public static void media(float a,float b,float c,float d){
    float soma;
    float media;
    soma=a+b+c+d;
    media=soma/4;

    Console.Write("Sua média calculada foi de {0} pontos!",media);
  }

  public static void Main () {
    float uno, dos, tres, cuatro;

    Console.Write("Insira a primeira nota bim.: ");
    uno = float.Parse(Console.ReadLine());

    Console.Write("Insira a segunda nota bim.: ");
    dos = float.Parse(Console.ReadLine());

    Console.Write("Insira a terceira nota bim.: ");
    tres = float.Parse(Console.ReadLine());

    Console.Write("Insira a quarta nota bim.: ");
    cuatro = float.Parse(Console.ReadLine());

    media(uno,dos,tres,cuatro);
  }
}