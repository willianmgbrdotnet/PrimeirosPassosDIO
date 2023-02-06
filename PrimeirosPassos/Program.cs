﻿using System;

namespace PrimeirosPassos
{
    class Program
    {
        public static void Main(string[] args)
        {    
           Aluno[] alunos = new Aluno[5];
         
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        System.Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        System.Console.WriteLine("Informe a nota do aluno");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                        aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Por favor, digite um valor decimal para a nota");
                        }
                        break;
                    case "2":
                        //listar alunos
                        break;
                    case "3":
                        //calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opcao desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular media geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}