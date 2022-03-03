// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Revisao
{
    class Program
    {
        static void Main(string[] agrs) //Metodo
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario(); //Le o que o usuário informou

            while (opcaoUsuario.ToUpper() != "X") //ToUpper - Transforma em Maiusculo
            {
                switch(opcaoUsuario)
                {   
                    case "1":
                        Console.WriteLine("Informe o nome do Aluno: ");
                        var aluno = new Aluno(); //instancia o objeto aluno
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Inform a Nota do Aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)) // tenta converter String para Decimal
                        {
                         aluno.Nota = nota;   
                        }

                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                    //TODO: Adicionar Aluno
                    break;

                    case "2":
                        foreach(var a in alunos) //Para cada A (Aluno) no meu Array (Alunos) passa o nome e nota
                        {
                            //if(!a.Nome.Equals("")) //! = não. Então se nome não é vazio
                            if(!string.IsNullOrEmpty(a.Nome)) //se nome for nao for nulo
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                    }
                    //TODO: Listar Alunos
                    break;

                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i< alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome)) 
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitogeral;
                        if(mediaGeral <2)
                        {
                            conceitogeral = Conceito.E;
                        }

                        else if( mediaGeral <4)
                        {
                            conceitogeral = Conceito.D;
                        }

                        
                        else if( mediaGeral <6)
                        {
                            conceitogeral = Conceito.C;
                        }

                        
                        else if( mediaGeral <8)
                        {
                            conceitogeral = Conceito.B;
                        }

                        else
                        {
                            conceitogeral = Conceito.A;
                        }
                        Console.WriteLine($"Media Geral: {mediaGeral} - Conceito: {conceitogeral}");

                    //Calcular Media Geral
                    break;

                    default:
                        throw new ArgumentOutOfRangeException("Valor inserido não existe"); //Valor fora do range
                }
                opcaoUsuario = ObterOpcaoUsuario(); //Le o que o usuário informou
            }  
        }
         private static string ObterOpcaoUsuario() //Dentro da Classe, não dentro do metodo
            {
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Inserir novo aluno");
                Console.WriteLine("2- Listar alunos");
                Console.WriteLine("3- Calcular média geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                Console.WriteLine();
                return opcaoUsuario;
            }
    }
}