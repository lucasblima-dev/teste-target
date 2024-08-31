/*
1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre 
será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
escreva um programa na linguagem que desejar onde, informado um número, ele calcule 
a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence 
ou não a sequência.


int fib0 = 0;
int fib1 = 1;
int aux;

Console.Write("Informe um número: ");
int valueUser = int.Parse(Console.ReadLine());

while (fib1 < valueUser)
{
  aux = fib1;
  fib1 = fib0 + fib1;
  fib0 = aux;
}

string result = (fib1 == valueUser || valueUser == 0)
  ? $"{valueUser} pertence a sequência de Fibonacci"
  : $"{valueUser} não pertence a sequência de Fibonacci";

Console.WriteLine(result);
*/

//===========================================================================

/* 
02) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, 
seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.


int cont = 0;
string palavra;

Console.Write("Informe uma palavra ou frase: ");
palavra = Console.ReadLine();

foreach (char c in palavra)
{
  if (c == 'a' || c == 'A')
  {
    cont++;
  }
}

string result = (cont > 0)
  ? $"A letra 'A' e/ou 'a' aparece(m) {cont} vez(es) na string"
  : $"A letra 'A' e/ou 'a' não aparece(m) na string";

Console.WriteLine(result);
*/

//===========================================================================

/*
03)  Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; 
enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA

Resposta:
O loop executa enquanto enquanto K for menor que 12).
Em cada iteração, K é incrementado em 1, e o novo valor de K é adicionado a SOMA.

1ª iteração: K = 2, SOMA = 2
2ª iteração: K = 3, SOMA = 5
3ª iteração: K = 4, SOMA = 9
4ª iteração: K = 5, SOMA = 14
5ª iteração: K = 6, SOMA = 20
6ª iteração: K = 7, SOMA = 27
7ª iteração: K = 8, SOMA = 35
8ª iteração: K = 9, SOMA = 44
9ª iteração: K = 10, SOMA = 54
10ª iteração: K = 11, SOMA = 65
11ª iteração: K = 12, SOMA = 77

Quando K atinge 12, o loop para, pois a condição K < INDICE é falsa. Assim sendo,
o valor final da variável SOMA é 77.
*/

//===========================================================================

/*
04) Descubra a lógica e complete o próximo elemento:
a) 1, 3, 5, 7, ___
b) 2, 4, 8, 16, 32, 64, ____
c) 0, 1, 4, 9, 16, 25, 36, ____
d) 4, 16, 36, 64, ____
e) 1, 1, 2, 3, 5, 8, ____
f) 2,10, 12, 16, 17, 18, 19, ____

REsposta:

a) 1, 3, 5, 7, 9, 11...
(A lógica aqui é um salto de 2 em 2)

b) 2, 4, 8, 16, 32, 64, 128, 256...
(A lógica aqui é o dobro do número anterior)

c) 0, 1, 4, 9, 16, 25, 36, 49, 64...
(A lógica é o quadrado dos números inteiros sequenciais)

d) 4, 16, 36, 64, 100...
(A lógica é o quadrado dos números pares sequenciais)

e) 1, 1, 2, 3, 5, 8, 13, 21...
(A lógica é a sequência de Fibonacci [o próximo valor é a soma dos dois anteriores])

f) 2, 10, 12, 16, 17, 18, 19, 20, 21...
(A lógica é uma sequência que alterna entre números que seguem o padrão dos números que contêm o dígito 1 ou são números pares.)
*/

//===========================================================================

/*
05) 5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas 
diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os 
interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual 
lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, 
qual interruptor controla cada lâmpada?

REsposta:

Primeira ida: Ligaria o primeiro interruptor e esperaria por alguns minutos. Depois, ligaria o 
segundo interruptor e iria logo em seguida para uma das salas com lâmpada.
Se tiver acesa, quem controla é o segundo interruptor. Apagada e quente, é controlada pelo primeiro
interruptor. Apagada e fria, controlada pelo terceiro (já que ele não foi ligado).

Segunda ida: Como já teria descoberto qual interruptor controla uma das lâmpadas, restaria apenas
ligar um dos dois que sobraram e checar na sala que ainda não fui. Se tiver acesa, obviamente
é controlada pelo interruptor que acabei de usar. Caso contrário, ela é controlada pelo último. 
*/
