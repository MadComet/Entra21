﻿using System;
using System.Collections.Generic;

namespace AlbertoJPSantos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva seus códigos Aqui;)
            //Nome: Alberto José Pereira dos Santos

            //  opções_de_ações_no_estoque___________________________________________________
            //  |                                                                            |
            //  | x = 1 (mostra primeiro estoque  )     x = 2 (adiciona um item ao estoque)  |
            //  | x = 3 (retira um item do estoque)     x = 4 (mostra o estoque atual     )  |
            //  |____________________________________________________________________________|


            ///2º Mostra estoque ------------------------------------------------------------------
            ///

            int dia = 1;
            while (dia < 7)
            {
                Console.WriteLine("Dia " + dia + "\n");
                if (dia == 1)
                {
                    Console.WriteLine("Estoque Inicial\n");
                    Funcoes.Estoque1(1); Console.WriteLine("\n");
                    Funcoes.Estoque2(1); Console.WriteLine("\n");
                    Funcoes.Estoque3(1); Console.WriteLine("\n");
                    Funcoes.Estoque4(1); Console.WriteLine("\n");
                    Console.WriteLine("---------------------------------------------------------------------");
                }
                
                ///1º Recebe Carga e organizar estoque -------------------------------------------------
                ///

                Console.WriteLine("\nEntradas de produtos (por carga)\n");
                int cargasIn = Geradores.Qtd();
                List<string> entradas = new List<string>();
                for (int i = 0; i < cargasIn; i++)
                {
                    entradas = Geradores.GeraEntrada();
                    foreach (var item in entradas)
                    {
                        Console.Write(item);

                        if (item == "1")
                        {
                            Funcoes.Estoque1(2);
                        }
                        else if (item == "2")
                        {
                            Funcoes.Estoque2(2);
                        }
                        else if (item == "3")
                        {
                            Funcoes.Estoque3(2);
                        }
                        else
                        {
                            Funcoes.Estoque4(2);
                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");

                Console.WriteLine("Estoque após recebmento de todas as cargas \n");

                Funcoes.Estoque1(4); Console.WriteLine("\n");
                Funcoes.Estoque2(4); Console.WriteLine("\n");
                Funcoes.Estoque3(4); Console.WriteLine("\n");
                Funcoes.Estoque4(4); Console.WriteLine("\n");

                Console.WriteLine("Número de cargas despachadas: " + cargasIn + "\n");
                Console.WriteLine("---------------------------------------------------------------------");
                ///3º Envia carga ---------------------------------------------------------------------
                ///
                int cargasOut = Geradores.Qtd();
                Console.WriteLine("\nSaida de produtos (por carga)\n");
                for (int i = 0; i < cargasOut; i++)
                {
                    string saida = Geradores.OrdemDeServico();
                    Console.WriteLine(saida);
                    foreach (var item in saida)
                    {
                        if (item == '1')
                        {
                            Funcoes.Estoque1(3);
                        }
                        else if (item == '2')
                        {
                            Funcoes.Estoque2(3);
                        }
                        else if (item == '3')
                        {
                            Funcoes.Estoque3(3);
                        }
                        else
                        {
                            Funcoes.Estoque4(3);
                        }
                    }
                }
                Console.WriteLine();
                
                ///4º Mostra estoque atualizado ------------------------------------------------------
                ///
                Console.WriteLine("\nEstoque após envio de todas as cargas \n");

                Funcoes.Estoque1(4); Console.WriteLine("\n");
                Funcoes.Estoque2(4); Console.WriteLine("\n");
                Funcoes.Estoque3(4); Console.WriteLine("\n");
                Funcoes.Estoque4(4); Console.WriteLine("\n");

                Console.WriteLine("Número de cargas despachadas: " + cargasOut + "\n");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("\n\nfim do dia Dia " + dia + "\n");
                dia++;
                Console.WriteLine("\nPressione 'Enter' para Prossegir...\n");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.ReadKey();
            }
            Console.WriteLine("\nFim da Semana");
        }
    }
}
