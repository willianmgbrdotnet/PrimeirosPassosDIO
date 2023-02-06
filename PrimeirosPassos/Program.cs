using System;

namespace PrimeirosPassos
{
    class Program
    {
        public static void Main(string[] args)
        {    
           Aluno[] alunos = new Aluno[5];
           var indiceAluno = 0;
         
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
                        alunos[indiceAluno] = aluno;
                        indiceAluno ++;

                        break;
                    case "2":
                        foreach(var posicaoNoArrayAlunos in alunos)
                        {
                            //Formula melhorada para eliminar campos nulos
                            if(!string.IsNullOrEmpty(posicaoNoArrayAlunos.Nome))
                                {
                                System.Console.WriteLine("O Aluno: {0} obteve a Nota: {1}.", posicaoNoArrayAlunos.Nome, posicaoNoArrayAlunos.Nota);
                                }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var quantidadeAlunos = 0;

                        for(int i = 0; i < alunos.Length; i++)
                        {
                            //Se o nome na posicao do array aluno nao for nulo ou vazio, 
                            //a nota do aluno no array sera somada a nota total.
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                quantidadeAlunos++;
                            }
                        }
                        //Calculo da Media fora do "for"
                        //Dentro do "for", apenas a soma das notas
                        var mediaGeral = notaTotal / quantidadeAlunos;
                        //Implementacao de Enum
                        EConceito conceitoGeral;
                        
                        if(mediaGeral <= 2)
                        {
                            conceitoGeral = EConceito.E;
                        }
                        else if(mediaGeral <= 4)
                        {
                            conceitoGeral = EConceito.D;
                        }
                        else if(mediaGeral <= 6)
                        {
                            conceitoGeral = EConceito.C;
                        }
                        else if(mediaGeral <= 8)
                        {
                            conceitoGeral = EConceito.B;
                        }
                        else
                        {
                            conceitoGeral = EConceito.A;
                        }
                        Console.WriteLine("Media Geral: {0} e Conceito: {1}", mediaGeral, conceitoGeral);

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                System.Console.WriteLine();

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