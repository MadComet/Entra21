﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Desafio_AlbertoJPSantos.Classes;

//namespace Desafio_AlbertoJPSantos
//{
//    class exBlackJack
//    {
      
            
//            Console.WriteLine("");
//            Console.WriteLine("->Mostra baralho embaralhado");
//            cardDeck.Shuffle();
//            foreach (Card card in cardDeck.DeckOfCards)
//            {
//                Console.Write(card.Number + "-" + card.Suit + " | ");
//            }
//            Console.WriteLine("");
//            Console.WriteLine("->Pega primeira carta");
//            Card first = cardDeck.GoFish();
//            Console.WriteLine(first.Number + "-" + first.Suit);
//            Console.WriteLine("->Pega N cartas to topo");
//            List<Card> firstN = cardDeck.GoFish(4);
//            foreach (Card card in firstN)
//            {
//                Console.Write(card.Number + "-" + card.Suit + " | ");
//            }
//            Console.WriteLine("");
//            Console.WriteLine("->Remonta o baralho novamente");
//            cardDeck.RemountDeck();
//            foreach (Card card in cardDeck.DeckOfCards)
//            {
//                Console.Write(card.Number + "-" + card.Suit + " | ");
//            }
//            Console.WriteLine("");
//            Console.WriteLine("_________________________________________");
//            /*
//             * 3) Usando os tipos criados nos itens anteriores crie um jogo de sua escolha contanto que os seguintes itens sejam cumpridos:
//             *      a) Receber input de 1 jogador pelo console
//             *      b) Ter no mínimo uma condição de vitória e uma de derrota
//             *      É aceitavel que o programa termine ao atingir alguma condição de vitória/derrota
//             *      Enumere as regras do jogo
//             */
//            Console.WriteLine(" -- Blackjack -- ");
//            var blackjack = new Blackjack();
//            //REGRA: sistema pega uma carta do monte
//            Card cardBlackjack = blackjack.DeckCards.GoFish();
//            blackjack.SystemCard(cardBlackjack);
//            Console.WriteLine("Mesa Mostra uma carta: " + cardBlackjack.Number + "-" + cardBlackjack.Suit);
//            Console.WriteLine("Total da Mesa: " + blackjack.SumSystem);
//            //REGRA: Jogador pela primeira carta do monte
//            cardBlackjack = blackjack.DeckCards.GoFish();
//            blackjack.PlayerCard(cardBlackjack);
//            Console.WriteLine("Mesa Mostra uma carta: " + cardBlackjack.Number + "-" + cardBlackjack.Suit);
//            //REGRA: Jogador pela segunda carta do monte
//            cardBlackjack = blackjack.DeckCards.GoFish();
//            blackjack.PlayerCard(cardBlackjack);
//            Console.WriteLine("Mesa Mostra uma carta: " + cardBlackjack.Number + "-" + cardBlackjack.Suit);
//            Console.WriteLine("Total do Jogador: " + blackjack.SumPlayer);
//            bool continuarJogando = true;
//            do
//            {
//                //REGRA: jogador diz se quer ou não outra carta
//                Console.WriteLine("Deseja outra carta? 's' para sim ou qualquer tecla para não");
//                var entrada = Console.ReadKey();
//                Console.WriteLine("");
//                if (entrada.Key.ToString() == "s" || entrada.Key.ToString() == "S")
//                {
//                    cardBlackjack = blackjack.DeckCards.GoFish();
//                    blackjack.PlayerCard(cardBlackjack);
//                    Console.WriteLine("Proxima carta jogador: " + cardBlackjack.Number + "-" + cardBlackjack.Suit);
//                    Console.WriteLine("Total do Jogador: " + blackjack.SumPlayer);
//                    //REGRA: jogador fez mais que 21, não pode mais pegar carta
//                    if (blackjack.SumPlayer > 21)
//                    {
//                        continuarJogando = false;
//                    }
//                }
//                else
//                {
//                    continuarJogando = false;
//                }
//                Console.WriteLine("");
//            } while (continuarJogando);
//            //REGRA: Mesa não tem 17 é obrigado a pegar carta (Até 17 ou mais)
//            while (blackjack.SumSystem < 17)
//            {
//                cardBlackjack = blackjack.DeckCards.GoFish();
//                blackjack.SystemCard(cardBlackjack);
//                Console.WriteLine("Carta pega pela mesa: " + cardBlackjack.Number + "-" + cardBlackjack.Suit);
//                Console.WriteLine("Total da Mesa: " + blackjack.SumSystem);
//            }
//            Console.WriteLine("");
//            //REGRA: Jogador estourou 21 - Jogador Perdeu.
//            if (blackjack.SumPlayer > 21)
//            {
//                Console.WriteLine("Mesa ganhou - tente novamente");
//            }
//            else
//            {
//                //REGRA: Mesa estourou 21 - Jogador Ganhou.
//                if (blackjack.SumSystem > 21)
//                {
//                    Console.WriteLine("Você ganhou - Parabens");
//                }
//                else
//                {
//                    //REGRA: Mesa fez mais que Jogador - Jogador Perdeu.
//                    if (blackjack.SumPlayer > blackjack.SumSystem)
//                    {
//                        Console.WriteLine("Você ganhou - Parabens");
//                    }
//                    else
//                    {
//                        //REGRA: Jogador fez mais que Mesa - Jogador Ganhou.
//                        if (blackjack.SumPlayer < blackjack.SumSystem)
//                        {
//                            Console.WriteLine("Mesa ganhou - tente novamente");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Empate");
//                        }
//                    }
//                }
//            }
//            Console.WriteLine(""); Console.WriteLine("");
//            Console.WriteLine("Aperte qualquer tecla para sair!");
//            Console.ReadKey();
//        }
    
//    }
//}
