using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootLuck
{
    public class Partida
    {

        public void comecarRodada(int id)
        {
            String[] valores = new String[3];
            int vezes = 0;

            int randomIndex = 0;
            int[] cont1 = new int[3];

            int[] referencia = new int[3];
            int contadorVezes = 0;
            int[] numeros1 = new int[3];

            int cont = 0;



            int[] quantidade = new int[3];
            int[] posicoes = new int[3];
            int[] resultado = new int[3];
            int valor, aux, k;
            int contVezes = 0;
            String[] cartas1 = new string[6];

            cartas1[1] = "Gol";
            cartas1[2] = "Penalti";
            cartas1[3] = "Falta";
            cartas1[4] = " Cartão_Amarelo";
            cartas1[5] = "Cartão_Vermelho";
            cartas1[6] = "Energia";


            //int[] cartas2 = { 0,1, 2, 3, 4, 5};

            //int[] cartasSorteadas = new int[3] { 0, 0, 0 };
            int carta1 = 0;
            int carta2 = 0;
            int carta3 = 0;
            //Sortear cartas
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                randomIndex = random.Next(1, 6);

                if (i == 0)
                {
                    carta1 = randomIndex;
                }
                else if (i == 1)
                {
                    carta2 = randomIndex;
                }
                else if (i == 2)
                {
                    carta3 = randomIndex;
                }
            }


            //for (int i = 0; i < 3; i++)//preencher vetor
            //{



            //    Random random = new Random();
            //    randomIndex = random.Next(1, 6);//sorteador
            //    Console.WriteLine(randomIndex);//Mostre os numeros  sorteados

            //    switch (cartas2[randomIndex])
            //    {
            //        case 0:
            //            valores[i] = "Gol";
            //            numeros1[i] = 1;
            //            //[i] = 0;
            //            break;
            //        case 1:
            //            valores[i] = "Penalti";
            //            numeros1[i] = 2;
            //            //cont1[i] = 1;
            //            break;
            //        case 3:
            //            valores[i] = "Falta";
            //            numeros1[i] = 3;

            //            // cont1[i] = 2;
            //            break;
            //        case 4:
            //            valores[i] = "Cartao_Amarelo";
            //            numeros1[i] = 4;
            //            // cont1[i] = 3;
            //            break;

            //        case 5:
            //            valores[i] = "Cartao_vermelho";
            //            numeros1[i] = 5;
            //            //cont1[i] = 4;
            //            break;

            //        case 6:
            //            valores[i] = "Energia";
            //            numeros1[i] = 6;
            //            // cont1[i] = 5;
            //            break;
            //    }
            //}




            Console.WriteLine();
            for (int t = 0; t < 3; t++)//mostrando os numeros do vetor
            {

                Console.WriteLine("Valores: " + valores[t]);



            }

            Console.WriteLine();
            for (int w = 0; w < 3; w++)//mostrando os numeros do vetor
            {

                Console.WriteLine("numeros1: " + numeros1[w]);



            }



            Console.WriteLine();
            for (int j = 0; j < 3; j++)//fazer as comparações
            {
                k = 0;
                Console.WriteLine("Indice J: " + j);



                Console.WriteLine("Indice K: " + k);


                if (numeros1[k] == numeros1[j])
                {

                    resultado[k] = numeros1[j];


                    // posicoes[j] = j;
                    cont = cont + 1;//o numero foi encontrado pelo menos uma vez
                    quantidade[k] = cont;


                }
                else if (numeros1[j] != numeros1[j - 1])//se o numero atual em (j) for diferente do numero anterior em (j) então
                {                                //resultado recebe esse vcalor como um valor diferente e contabiliza 1 para ele.

                    resultado[j] = numeros1[j];
                    cont = 1;//o numero foi encontrado pelo menos uma vez
                    quantidade[j] = cont;




                }
                else//senão se o numero atual em (j) for igual ao numero anterior em (j) então quantidade soma mais +1 para o mesmo valor
                {


                    quantidade[j - 1] = cont + 1;
                }




                contVezes++;//quantas vezes  o indice (j) foi executado





            }






            Console.WriteLine("contVezes: " + contVezes);

            vezes += 1;




            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("resultado:" + resultado[i]);



            }




            for (int j = 0; j < 3; j++)
            {


                Console.WriteLine("Qunatidade de vezes que o numero aparece : " + quantidade[j]);

            }

            for (int y = 0; y < 3; y++)
            {

                switch (resultado[y])
                {
                    case 1:
                        if (quantidade[y] == 1)
                        {
                            //Console.WriteLine("Gol");
                            Console.WriteLine("3 pontos" + cartas1[y]);


                        }
                        else if (quantidade[y] == 2)
                        {
                            //Console.WriteLine("Gol");
                            Console.WriteLine("6 pontos" + cartas1[y]);

                        }
                        else if (quantidade[y] == 3)
                        {
                            // Console.WriteLine("Gol");
                            Console.WriteLine("1 pontos" + cartas1[y]);



                        }


                        break;
                    case 2:
                        if (quantidade[y] == 1)
                        {
                            //Console.WriteLine("Penalti");
                            Console.WriteLine("2 pontos" + cartas1[y]);


                        }
                        else if (quantidade[y] == 2)
                        {
                            //Console.WriteLine("Penalti");
                            Console.WriteLine("4 pontos" + cartas1[y]);

                        }
                        else if (quantidade[y] == 3)
                        {

                            Console.WriteLine(cartas1[y]);
                            Console.WriteLine("Direita (1), Esquerda(2), Centro(3)");
                            Console.WriteLine("Escolha uma opção: ");
                            int opcao = int.Parse(Console.ReadLine());




                        }
                        break;


                    case 3:
                        if (quantidade[y] == 1)
                        {
                            Console.WriteLine("1 ponto" + cartas1[y]);


                        }
                        else if (quantidade[y] == 2)
                        {
                            Console.WriteLine("2 pontos" + cartas1[y]);

                        }
                        else if (quantidade[y] == 3)
                        {
                            Console.WriteLine("Falta");
                            Console.WriteLine("Passa a vez!" + cartas1[y]);


                        }

                        break;

                    case 4:
                        if (quantidade[y] == 1)
                        {
                            Console.WriteLine("1 ponto" + cartas1[y]);


                        }
                        else if (quantidade[y] == 2)
                        {
                            Console.WriteLine("2 pontos" + cartas1[y]);

                        }
                        else if (quantidade[y] == 3)
                        {
                            Console.WriteLine(cartas1[y]);
                            Console.WriteLine("Perde uma energia, no próximo cartão amarelo perderá duas energias, e passa a vês para o adversário.");


                        }

                        break;
                    case 5:
                        if (quantidade[y] == 1)
                        {
                            Console.WriteLine("0 pontos" + cartas1[y]);


                        }
                        else if (quantidade[y] == 2)
                        {
                            Console.WriteLine("0 pontos" + cartas1[y]);

                        }
                        else if (quantidade[y] == 3)
                        {
                            Console.WriteLine(cartas1[y]);
                            Console.WriteLine("O usuário perde duas energias, e passa a vês para o adversário.");


                        }

                        break;

                    case 6:
                        if (quantidade[y] == 1)
                        {
                            Console.WriteLine("2 pontos");


                        }
                        else if (quantidade[y] == 2)
                        {
                            Console.WriteLine("4 pontos");

                        }
                        else if (quantidade[y] == 3)
                        {
                            Console.WriteLine("Energia");
                            Console.WriteLine("O jogador ganha mais uma energia para jogar, e passa a vês para o adversário. ");


                        }



                        break;








                }




            }
































        }


    }






}

















