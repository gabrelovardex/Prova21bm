using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova21bm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine(" ==========MENU============ ");
            Console.WriteLine(" 1- EXERCÍCIO 1 ");
            Console.WriteLine(" 2- EXERCÍCIO 2 ");
            Console.WriteLine(" 3- EXERCÍCIO 3 ");
            Console.WriteLine(" 4- EXERCÍCIO 4 ");
            Console.WriteLine(" 5- EXERCÍCIO 5 ");
            Console.WriteLine(" 6- EXERCÍCIO 6 ");
            Console.WriteLine(" 7- EXERCÍCIO 7 ");
            Console.WriteLine(" ========================= ");

            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {

                case 1: // exercicio 1

                    int number;

                    Console.WriteLine("DIGITE UM NUMERO INTEIRO: ");
                    number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        number = -number;
                    }

                    Console.WriteLine("VALOR ABSOLUTO: " + number);

                    break;




                case 2: // exercicio 2


                    int NUMEINT;

                    Console.WriteLine("DIGITE UM NÚMERO INTEIRO:");
                    NUMEINT = int.Parse(Console.ReadLine());

                    if (((NUMEINT % 3) == 0) && ((NUMEINT & 5) == 0))
                        Console.WriteLine("O NUMERO É MULTIPLO POR 3 e 5");

                    else if (((NUMEINT % 4) == 0) && ((NUMEINT % 7) == 0))
                        Console.WriteLine("O NÚMERO É MULTIPLO POR 3 E 5");

                    else if ((NUMEINT % 3) == 0)
                        Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 3");

                    else if ((NUMEINT % 5) == 0)
                        Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 5");

                    else if ((NUMEINT % 4) == 0)
                        Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 4");

                    else if ((NUMEINT % 7) == 0)
                        Console.WriteLine("O NÚMERO É DIVÍSIVEL POR 7");

                    else
                        Console.WriteLine("O NÚMERO NÃO É DIVÍSIVEL POR NENHUM DOS NÚMEROS ACIMA");

                    break;




                case 3: // exercicio 3

                    int A, B, C;

                    Console.WriteLine("qual o valor do numero ");
                    A = int.Parse(Console.ReadLine());

                    Console.WriteLine("qual o valor do numero ");
                    B = int.Parse(Console.ReadLine());

                    Console.WriteLine("qual o valor do numero ");
                    C = int.Parse(Console.ReadLine());

                    if (A < B && B < C)
                        Console.WriteLine(A + " " + B + " " + C);

                    else if (A < B && B > C)
                        Console.WriteLine(A + " " + C + " " + B);

                    else if (B < A && A < C)
                        Console.WriteLine(B + " " + A + " " + C);

                    else if (B < A && A > C)
                        Console.WriteLine(B + " " + C + " " + A);

                    else if (C < A && A < B)
                        Console.WriteLine(C + " " + A + " " + B);

                    else if (C < A && A > C)
                        Console.WriteLine(C + " " + B + " " + A);


                    break;

                    


                case 4: // exercicio 4

                    int num;

                    Console.WriteLine(" ==========MENU============ ");
                    Console.WriteLine(" DOMINGO ");
                    Console.WriteLine(" SEGUNDA ");
                    Console.WriteLine(" TERÇA ");
                    Console.WriteLine(" QUARTA ");
                    Console.WriteLine(" QUINTA ");
                    Console.WriteLine(" SEXTA ");
                    Console.WriteLine(" SÁBADO ");
                    Console.WriteLine(" ========================= ");

                    Console.WriteLine(" Escolha um dia de 1 a 7: ");
                    num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine(" DOMINGO - DURMO O DIA INTEIRO ");
                            break;

                        case 2:
                            Console.WriteLine(" SEGUNDA - DUAS AULAS DE FILOSOFIA, DUAS DE LPL E DUAS DE MATEMATICA ");
                            break;

                        case 3:
                            Console.WriteLine(" TERÇA - DUAS AULAS DE QUIMICA, DUAS DE HISTORIA E DUAS DE INGLES ");
                            break;

                        case 4:
                            Console.WriteLine(" QUARTA - DUAS DE BIOLOGIA, UMA DE LPL E TRES D PR2 ");
                            break;

                        case 5:
                            Console.WriteLine(" QUINTA - DUAS DE FISICA, DUAS DE RDC E DUAS DE SOCIOLOGIA ");
                            break;

                        case 6:
                            Console.WriteLine(" SEXTA - DUAS GEOGRAFIA, UMA DE MATEMATICA E TRES DE BANCO DE DADOS ");
                            break;

                        case 7:
                            Console.WriteLine(" SÁBADO - COMO O DIA INTEIRO ");
                            break;

                        default:
                            Console.WriteLine(" OPÇÃO INVALIDA ");
                            break;

                    }

                    break;




                case 5: // exercicio 5

                    int NUMBER, MENORNUMBER, MAIORNUMBER , PARADA = 1;

                    Console.WriteLine("DIGITE UM NUMERO: ");
                    MAIORNUMBER = int.Parse(Console.ReadLine());

                    MENORNUMBER = MAIORNUMBER;
                    for ( ; PARADA != 0; )
                    {
                        Console.WriteLine("DIGITE UM NUMERO: ");
                        NUMBER = int.Parse(Console.ReadLine());

                        if (NUMBER > MAIORNUMBER)
                        {
                            MAIORNUMBER = NUMBER;
                        }
                            
                        if (NUMBER < MENORNUMBER)
                        {
                            MENORNUMBER = NUMBER;
                        }
                            
                        Console.WriteLine("DIGITE 0 PARA SAIR OU 1 PARA CONTINUAR:");
                        PARADA = int.Parse(Console.ReadLine());

                    }

                    Console.WriteLine("MENOR NUMERO = {0}, MAIOR NUMERO = {1}", MENORNUMBER, MAIORNUMBER);

                    break;




                case 6:// exercicio 6

                    int SOMA = 0, NUMINT, I;

                    Console.WriteLine("DIGITE UM NUMERO INTEIRO: ");
                    NUMINT = int.Parse(Console.ReadLine());

                    for (I = 1; I < NUMINT; I++)
                    {
                        if (NUMINT % I == 0)
                        {
                            SOMA += I;
                        }
                    }
                    if (SOMA == NUMINT)
                    {
                        Console.WriteLine(NUMINT + " É PERFEITO");
                    }
                    else
                    {
                        Console.WriteLine(NUMINT + " NÃO É PERFEITO");
                    }


                    break;




                case 7: // exercicio 7

                    Console.WriteLine("NÃO SEI FAZERRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR");

                    break;





                default:
               
                    Console.WriteLine("OPÇÃO INVALIDA");
                    break;

            }

            Console.ReadKey();

        }
    }
}
