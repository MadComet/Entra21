﻿using Aula_OO.Heranca;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Aula_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            ///exc 01
            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Preencha esta pessoa");
            //pes.nome = Console.ReadLine();
            //pes.idade = int.Parse(Console.ReadLine());
            //pes.cpf = Console.ReadLine();
            //pes.endereco = Console.ReadLine();
            //Console.WriteLine("-----------//-------------");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.idade);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);

            ///exc 02
            //List<Cachorro> doginhos = new List<Cachorro>();

            ////preenche a lista
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o doginho");
            //    Cachorro cao = new Cachorro();
            //    cao.nome = Console.ReadLine();
            //    cao.nomeDoDono = Console.ReadLine();
            //    cao.idade = Convert.ToInt32(Console.ReadLine());
            //    doginhos.Add(cao);
            //}
            //Console.WriteLine("-----------//-----------");

            ////mostrar a lista, apenas cachorros velhos
            //foreach (var item in doginhos)
            //{
            //    if (item.idade > 6)
            //    {
            //        Console.WriteLine(item.nome);
            //        Console.WriteLine(item.nomeDoDono);
            //        Console.WriteLine(item.idade);
            //        Console.WriteLine("-----------//-----------");
            //    }
            //}
            //for (int i = 0; i < doginhos.Count; i++)
            //{
            //    if (doginhos[i].idade > 6)
            //    {
            //        Console.WriteLine(doginhos[i].nome);
            //        Console.WriteLine(doginhos[i].nomeDoDono);
            //        Console.WriteLine(doginhos[i].idade);
            //        Console.WriteLine("-----------//-----------");
            //    }

            ///exc 03
            ///
            //List<Pessoa> pes = new List<Pessoa>();
            //int maisVelhoH = 0, maisVelhaM = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Pessoa pessoa = new Pessoa();

            //    Console.Write("\nInsira o Nome: "); pessoa.nome = Console.ReadLine();
            //    Console.Write("Insira a idade: "); pessoa.idade = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Insira o Genero (masculino/feminino): "); pessoa.genero = Console.ReadLine();
            //    pessoa.genero = pessoa.genero.ToLower();

            //    if (pessoa.genero == "masculino")
            //    { 
            //        if(pessoa.idade > maisVelhoH)
            //        {
            //            maisVelhoH = pessoa.idade;
            //        }
            //    }
            //    if (pessoa.genero == "feminino")
            //    {
            //        if (pessoa.idade > maisVelhaM)
            //        {
            //            maisVelhaM = pessoa.idade;
            //        }
            //    }
            //    pes.Add(pessoa);
            //}

            //foreach (var item in pes)
            //{
            //    if (item.idade == maisVelhoH && item.genero == "masculino")
            //    {
            //        Console.WriteLine("\n\nO Homem mais velho é o " + item.nome + ", com " + item.idade + " anos de idade.");
            //    }
            //    if (item.idade == maisVelhaM && item.genero == "feminino")
            //    {
            //        Console.WriteLine("\nA mulher mais velha é a " + item.nome + ", com " + item.idade + " anos de idade.");
            //    }
            //}

            ///exc 04 -------------- não finalizado
            ///
            //List<Animais> animais = new List<Animais>();

            //for (int i = 0; i < 2; i++)
            //{
            //    Animais animal = new Animais();

            //    Console.Write("\nInsira o nome do animal: "); animal.nome = Console.ReadLine();
            //    Console.Write("Insira a idade: "); animal.idade = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Insira sua espécie: "); animal.genero = Console.ReadLine();
            //    Console.Write("Insira o tempo que ele está no Zoo em dias: "); animal.tempoZoo = Convert.ToInt32(Console.ReadLine());
            //    animais.Add(animal);
            //    for (int l = animais.Count - 1; l >= 0; l--)
            //    {
            //        for (int j = 1; j <= l; j++)
            //        {
            //            if (animal.idade[j - 1] > animal.idade[j])
            //            {
            //                var temp = animal.idade[j - 1];
            //                animal.idade[j - 1] = animal.idade[j];
            //                animal.idade[j] = temp;
            //            }
            //        }
            //    }
            //}
            //// fazer o sort manual

            //foreach (var item in animais)
            //{
            //    Console.WriteLine(item.nome + " " + item.idade + " " + item.especie + " " + item.tempoZoo);
            //}

            /// --------------- não finalizado

            ///Exc 05

            //----------------------------------------------------------------------------------------------

            //Exc 00 part 2

            ///Exec 01

            //Console.WriteLine("insira uma pessoa");
            //string nome, cpf, endereco;
            //int idade;

            //nome = Console.ReadLine();
            //cpf = Console.ReadLine();
            //endereco = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());

            //Pessoa pes = new Pessoa(nome,cpf,endereco,idade);
            //Console.WriteLine("----------//------------®");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);
            //Console.WriteLine(pes.idade);

            //string[] vetor = { "Julia", "89915788551", "Rua das missoes" };
            //Pessoa pes = new Pessoa(vetor, 37);
            //for (int i = 0; i < pes.valores.Length; i++)
            //{
            //    Console.WriteLine(pes.valores[i]);
            //}

            //Console.WriteLine(pes.valores[0]);
            //Console.WriteLine(pes.valores[1]);
            //Console.WriteLine(pes.valores[2]);

            ///Exec02

            //List<SerHumano> pessoas = new List<SerHumano>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira uma pessoa");
            //    string nome = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    // H = Homem | M = Mulher
            //    string genero = Console.ReadLine().ToLower();// Tudo o que o usario inserir ficará em letra minuscula
            //    SerHumano ser = new SerHumano(nome, idade, genero);
            //    pessoas.Add(ser);
            //}

            //int indiceHomi = -1, indiceMuie = -1;
            //int idadeHomi = -1, idadeMuie = -1;

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if (pessoas[i].genero == "m")
            //    {
            //        if (idadeMuie < pessoas[i].idade)
            //        {
            //            indiceMuie = i;
            //            idadeMuie = pessoas[i].idade;
            //        }
            //    }
            //    if (pessoas[i].genero == "h")
            //    {
            //        if (idadeHomi < pessoas[i].idade)
            //        {
            //            indiceHomi = i;
            //            idadeHomi = pessoas[i].idade;
            //        }
            //    }
            //    //switch (pessoas[i].genero)
            //    //{
            //    //    case "m":
            //    //        if (idadeMuie < pessoas[i].idade)
            //    //        {
            //    //            indiceMuie = i;
            //    //            idadeMuie = pessoas[i].idade;
            //    //        }
            //    //        break;
            //    //    case "h":
            //    //        if (idadeHomi < pessoas[i].idade)
            //    //        {
            //    //            indiceHomi = i;
            //    //            idadeHomi = pessoas[i].idade;
            //    //        }
            //    //        break;
            //    //    default:
            //    //        break;
            //    //}
            //}
            //Console.WriteLine("-----------//--------------®");
            //try
            //{
            //    Console.WriteLine("Mulher mais velha");
            //    Console.WriteLine(pessoas[indiceMuie].nome);
            //    Console.WriteLine(pessoas[indiceMuie].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Nao existe mulheres na lista");
            //}
            //Console.WriteLine("-----------//--------------®");
            //try
            //{
            //    Console.WriteLine("Homem mais velho");
            //    Console.WriteLine(pessoas[indiceHomi].nome);
            //    Console.WriteLine(pessoas[indiceHomi].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Nao existe homens na lista");
            //}

            ///Exc 03

            //List<Cachorro> cachorro = new List<Cachorro>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("\n\nInsira o nome do cachorro");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o nome do Dono");
            //    string nomeDoDono = Console.ReadLine();
            //    Console.WriteLine("Insira a Idade do Pet");
            //    int idade = int.Parse(Console.ReadLine());
            //    Cachorro cao = new Cachorro(nome, nomeDoDono, idade);
            //    cachorro.Add(cao);
            //}           
            //int cont =0;
            //for (int i = 0; i < cachorro.Count; i++)
            //{
            //    if (cachorro[i].idade >= 4)
            //    {
            //        Console.WriteLine("\nPet possui mais de 4 anos:");
            //        cont++;
            //        Console.WriteLine(cachorro[i].nome);
            //        Console.WriteLine(cachorro[i].nomeDoDono);
            //        Console.WriteLine(cachorro[i].idade);
            //    }
            //}
            //if (cont == 0)
            //{
            //    Console.WriteLine("\nNão Possuem cachorros com mais de 4 anos de idade");
            //}

            ///Exc 04
            ///

            //List<Estoque> estoque = new List<Estoque>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("\n\nInsira o nome do Produto");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o Preço");
            //    double preco = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Insira a Quantidade");
            //    int quantidade = int.Parse(Console.ReadLine());
            //    Estoque estq = new Estoque(nome, preco, quantidade);
            //    estoque.Add(estq);
            //}
            //BoobleSort(estoque);

            //Console.WriteLine("\nProdutos em estoque: \n");
            //for (int i = 0; i < estoque.Count; i++)
            //{
            //    Console.WriteLine("\nNome: " + estoque[i].nome);
            //    Console.WriteLine("Preço: " + estoque[i].preco);
            //    Console.WriteLine("Quantidade: " + estoque[i].quantidade);
            //}

            ///Exc 07
            ///

            //List<Alunos> alunos = new List<Alunos>();


            //for (int i = 0; i < 4; i++)
            //{
            //    double media = 0;
            //    string resultado;
            //    Console.WriteLine("\n\nInsira o nome do aluno");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira a Primeira Nota");
            //    double nota1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Insira a Segunda Nota");
            //    double nota2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Insira a Terceira Nota");
            //    double nota3 = Convert.ToInt32(Console.ReadLine());
            //    Alunos aluno = new Alunos(nome, nota1, nota2, nota3);
            //    media = NotaMedia(nota1, nota2, nota3);
            //    alunos.Add(aluno);

            //    Console.WriteLine("\n______________________\n");
            //    Console.WriteLine(alunos[i].nome);
            //    Console.WriteLine("Média " + media);
            //    if (media >= 7)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        resultado = "Aprovado";
            //        Console.WriteLine(resultado);
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        resultado = "Reprovado";
            //        Console.WriteLine(resultado);
            //        Console.ResetColor();
            //    }
            //    Console.WriteLine("______________________");
            //}

            /// Herança LISTA 2
            /// 
            /// Exc 001
            /// Exc 002
            /// Exc 003
            /// 

            Empresa emp = new Empresa();
            List<Funcionario> temp2 = new List<Funcionario>()
            {new Funcionario { Nome = "Jorge", Cargo = "Peão", Salario = 1350.24, Conta = "15547855", Saldo = -624.23, Senha = 1554 },
            new Funcionario { Nome = "Cleiton", Cargo = "Entregador", Salario = 1624.72, Conta = "35664855", Saldo = 800, Senha = 1337 },
            new Funcionario { Nome = "Dr. Hamilton", Cargo = "Gerente", Salario = 2215.56, Conta = "48855788", Saldo = 1542.75, Senha = 6522 }};

            //temp2.Add(new Funcionario { Nome = "Jorge", Cargo = "Peão", Salario = 1350.24, Conta = "15547855", Saldo = -624.23, Senha = 1554 });
            //temp2.Add(new Funcionario { Nome = "Cleiton", Cargo = "Entregador", Salario = 1624.72, Conta = "35664855", Saldo = 800, Senha = 1337 });
            //temp2.Add(new Funcionario { Nome = "Dr. Hamilton", Cargo = "Gerente", Salario = 2215.56, Conta = "48855788", Saldo = 1542.75, Senha = 6522 });
            emp.Funcionarios = temp2;


            //List<Funcionario> temp = new List<Funcionario>();
            //for (int i = 0; i < 3; i++) // relembrar de colocar 5
            //{
            //    PreencheFunc(temp);
            //}
            //emp.Funcionarios = temp;


            while (true)
            {
                Console.WriteLine("Olá, Seja bem vinda a casa dos Primos");
                Console.WriteLine("1- Aumento");
                Console.WriteLine("2- Demitir");
                Console.WriteLine("3- Fechamento");
                Console.WriteLine("4- Sair");
                int escolha = Convert.ToInt32(CR());
                if (escolha == 1)
                {
                    {
                        //foreach (var item in emp.Funcionarios)
                        //{
                        //    Console.WriteLine(item.Nome);
                        //}
                    }
                    Console.WriteLine("De qual deseja aumentar o salário?");
                    for (int i = 0; i < emp.Funcionarios.Count; i++)
                    {
                        Console.WriteLine("{0}- {1}", i + 1, emp.Funcionarios[i].Nome);
                    }
                    escolha = Convert.ToInt32(CR()) - 1;
                    Console.WriteLine("Quantos % de aumento");
                    double aumento = Convert.ToDouble(CR());
                    emp.Funcionarios[escolha].Salario += (emp.Funcionarios[escolha].Salario * (aumento / 100));
                    Console.Write("Conferindo");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write("."); Thread.Sleep(500);
                    }
                    Console.WriteLine("\n" + emp.Funcionarios[escolha].Salario);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("De qual deseja demitir?");
                    for (int i = 0; i < emp.Funcionarios.Count; i++)
                    {
                        Console.WriteLine("{0}- {1}", i + 1, emp.Funcionarios[i].Nome);
                    }
                    escolha = Convert.ToInt32(CR()) - 1;
                    emp.Funcionarios.RemoveAt(escolha);
                    Console.Clear();
                }
                else if (escolha == 3)
                {
                    /* Peão R$ 4.785,26
                     * Entregador R$ 5.324,82
                     * Gerente R$ 2.485,64 x qtd. de (Peão + Entregador)*/
                    double faturamento = 0;
                    foreach (var item in emp.Funcionarios)
                    {
                        if (item.Cargo == "Peão")
                        {
                            faturamento += 4785.26;
                        }
                        else if (item.Cargo == "Entregador")
                        {
                            faturamento += 5324.82;
                        }
                        else
                        {
                            foreach (var item2 in emp.Funcionarios)
                            {
                                if (item2.Cargo != "Gerente")
                                {
                                    faturamento += 2485.64;
                                }
                            }
                        }
                    }
                    emp.Saldo += faturamento;

                    for (int i = 0; i < emp.Funcionarios.Count; i++)
                    {
                        emp.Funcionarios[i].Saldo += emp.Funcionarios[i].Salario;
                        emp.Saldo -= emp.Funcionarios[i].Salario;
                        faturamento -= emp.Funcionarios[i].Salario;
                    }

                    if (faturamento < 0)
                    {
                        Console.WriteLine("VIXE, deu preju :(");
                        Console.WriteLine(faturamento);
                    }
                    else
                    {
                        Console.WriteLine("Deu lucro /o/");
                        Console.WriteLine(faturamento);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Obrigado por usar o Geretron 3000®");
                    break;
                }
                else
                {
                    Console.WriteLine("Opçãum inválída");
                }

            }

        }

        // Funções
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static void PreencheFunc(List<Funcionario> funcionarios)
        {
            Funcionario estagiario = new Funcionario();
            Console.WriteLine("informações pessoais");
            estagiario.Nome = Console.ReadLine();
            estagiario.Cargo = Console.ReadLine();
            estagiario.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dados bancários");
            estagiario.Conta = Console.ReadLine();
            estagiario.Saldo = Convert.ToInt32(Console.ReadLine());
            estagiario.Senha = Convert.ToInt32(Console.ReadLine());
            funcionarios.Add(estagiario);
        }


        public static void BoobleSort(List<Estoque> estoque)
        {
            for (int i = 0; i < estoque.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (estoque[j - 1].quantidade < estoque[j].quantidade)
                    {
                        Estoque temp = estoque[j];
                        estoque[j] = estoque[j - 1];
                        estoque[j - 1] = temp;
                    }
                }
            }
        }
        public static double NotaMedia(double nota1, double nota2, double nota3)
        {
            double media = 0;

            media = (nota1 + nota2 + nota3) / 3;

            return media;
        }




    }
}
