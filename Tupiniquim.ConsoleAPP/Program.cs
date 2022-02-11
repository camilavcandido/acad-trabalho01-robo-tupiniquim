using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("¨¨Projeto Tupiniquim¨¨");
                Console.ResetColor();
                Console.WriteLine("Comandos:" + "\n Coordenadas = X e Y" + "\n Direcao = N, S, L ou O " +
                    "\n M = o robo avança +1 casa na direção que está" +
                    "\n E = o robo vira 90º a esquerda \n D = o robo vira 90º a direita ");
                Console.WriteLine("** digite todos em letra minuscula");
                //delimita área
                Console.Write("_Delimite a área a ser analisada. Coordenadas X e Y: ");
                string[] area = Console.ReadLine().Split(' ');
                int areaX = int.Parse(area[0]);
                int areaY = int.Parse(area[1]);

                //robo 01 - posicao inicial
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ROBO 01");
                Console.ResetColor();
                Console.Write("_Defina a posição inicial do Robo 01. X, Y e sua Direção: ");
                string[] posicaoInicialRobo01 = Console.ReadLine().Split(' ');
                int xRobo01 = int.Parse(posicaoInicialRobo01[0]);
                int yRobo01 = int.Parse(posicaoInicialRobo01[1]);
                char direcaoRobo01 = char.Parse(posicaoInicialRobo01[2]);
                Console.WriteLine("Posição Inicial do Robo 01 = " + xRobo01 + " " + yRobo01 + " " + direcaoRobo01);

                //comandos
                Console.Write("_Defina o comando que o robo 01 deve executar: ");
                string strComandoRobo01 = Console.ReadLine();
                char[] comandoRobo01 = strComandoRobo01.ToCharArray();

                //condicoes
                for (int i = 0; i < comandoRobo01.Length; i++)
                {
                    if (direcaoRobo01 == 'n')
                    {
                        if (comandoRobo01[i] == 'm')
                        {
                            yRobo01++;
                            if (yRobo01 > areaY)
                            {
                                yRobo01--;
                            }
                            continue;

                        }
                        else if (comandoRobo01[i] == 'e')
                        {
                            direcaoRobo01 = 'o';
                        }
                        else if (comandoRobo01[i] == 'd')
                        {
                            direcaoRobo01 = 'l';

                        }
                        continue;
                    }
                    if (direcaoRobo01 == 'o')
                    {
                        if (comandoRobo01[i] == 'm')
                        {
                            xRobo01--;
                            if (xRobo01 > areaX)
                            {
                                xRobo01--;
                            }
                            continue;

                        }
                        else if (comandoRobo01[i] == 'e')
                        {
                            direcaoRobo01 = 's';
                        }
                        else if (comandoRobo01[i] == 'd')
                        {
                            direcaoRobo01 = 'n';
                        }
                        continue;

                    }
                    if (direcaoRobo01 == 's')
                    {
                        if (comandoRobo01[i] == 'm')
                        {
                            yRobo01--;
                            if (yRobo01 > areaY)
                            {
                                yRobo01--;
                            }
                            continue;

                        }
                        else if (comandoRobo01[i] == 'e')
                        {
                            direcaoRobo01 = 'o';
                        }
                        else if (comandoRobo01[i] == 'd')
                        {
                            direcaoRobo01 = 'l';
                        }
                        continue;

                    }
                    if (direcaoRobo01 == 'l')
                    {
                        if (comandoRobo01[i] == 'm')
                        {
                            xRobo01++;
                            if (xRobo01> areaX)
                            {
                                xRobo01--;
                            }

                            continue;

                        }
                        else if (comandoRobo01[i] == 'e')
                        {
                            direcaoRobo01 = 'n';
                        }
                        else if (comandoRobo01[i] == 'd')
                        {
                            direcaoRobo01 = 's';
                        }
                        continue;

                    }

                }

                //robo 02 - posicao inicial
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("ROBO 02");
                Console.ResetColor();
                Console.Write(" _Defina a posição inicial do Robo 02. X, Y e sua Direção: ");
                string[] posicaoInicialRobo02 = Console.ReadLine().Split(' ');
                int xRobo02 = int.Parse(posicaoInicialRobo02[0]);
                int yRobo02 = int.Parse(posicaoInicialRobo02[1]);
                char direcaoRobo02 = char.Parse(posicaoInicialRobo02[2]);
                Console.WriteLine("Posição Inicial do Robo 02 = " + xRobo02 + " " + yRobo02 + " " + direcaoRobo02);

                //comandos
                Console.Write("_Defina o comando que o robo 02 deve executar: ");
                string strComandoRobo02 = Console.ReadLine();
                char[] comandoRobo02 = strComandoRobo02.ToCharArray();

                //condicoes
                for (int i = 0; i < comandoRobo02.Length; i++)
                {
                    if (direcaoRobo02 == 'n')
                    {
                        if (comandoRobo02[i] == 'm')
                        {
                            yRobo02++;
                            if (yRobo02 > areaY)
                            {
                                yRobo02--;
                            }
                            continue;

                        }
                        else if (comandoRobo02[i] == 'e')
                        {
                            direcaoRobo02 = 'o';
                        }
                        else if (comandoRobo02[i] == 'd')
                        {
                            direcaoRobo02 = 'l';
                        }
                        continue;
                    }
                    if (direcaoRobo02 == 'o')
                    {
                        if (comandoRobo02[i] == 'm')
                        {
                            xRobo02--;
                            if (xRobo02 > areaX)
                            {
                                xRobo02--;
                            }
                            continue;
                        }
                        else if (comandoRobo02[i] == 'e')
                        {
                            direcaoRobo02 = 's';
                        }
                        else if (comandoRobo02[i] == 'd')
                        {
                            direcaoRobo02 = 'n';
                        }
                        continue;

                    }
                    if (direcaoRobo02 == 's')
                    {
                        if (comandoRobo02[i] == 'm')
                        {
                            yRobo02--;
                            if (yRobo02 > areaY)
                            {
                                yRobo02--;
                            }
                            continue;
                        }
                        else if (comandoRobo02[i] == 'e')
                        {
                            direcaoRobo02 = 'o';
                        }
                        else if (comandoRobo02[i] == 'd')
                        {
                            direcaoRobo02 = 'l';
                        }
                        continue;
                    }
                    if (direcaoRobo02 == 'l')
                    {
                        if (comandoRobo02[i] == 'm')
                        {
                            xRobo02++;
                            if (xRobo02 > areaX)
                            {
                                xRobo02--;
                            }
                            continue;
                        }
                        else if (comandoRobo02[i] == 'e')
                        {
                            direcaoRobo02 = 'n';
                        }
                        else if (comandoRobo02[i] == 'd')
                        {
                            direcaoRobo02 = 's';
                        }
                        continue;

                    }

                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-> Posição final do Robo 01 = " + xRobo01 + " " + yRobo01 + " " + direcaoRobo01);
                Console.WriteLine("-> Posição final do Robo 02 = " + xRobo02 + " " + yRobo02 + " " + direcaoRobo02);
                Console.ResetColor();


                Console.WriteLine("Digite 1 para realizar outra análise ou 0 para encerrar");
                string respostaContinuar = Console.ReadLine();
                if (respostaContinuar == "1")
                {
                    continuar = true;
                }
                else if (respostaContinuar == "0")
                {
                    continuar = false;
                }

            }
        }
    }
}
