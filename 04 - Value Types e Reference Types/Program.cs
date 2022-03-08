using static System.Console; // Usando o System.Console pode usar somente o WriteLine, não precisa ser Console.WriteLine mais
public class Program
{
    static void Demo7()
    {
        List<StructPessoa> pessoas = new List<StructPessoa>()
        {
            new StructPessoa(){Nome = "Adriano"},
            new StructPessoa(){Nome = "Jose"},
            new StructPessoa(){Nome = "Maria"},
            new StructPessoa(){Nome = "Fabiana"},
            new StructPessoa(){Nome = "Eduardo"},
        };

        WriteLine("Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if(encontrado)
        {
            WriteLine("Pessoa localizada");
        }
        else
        {
            WriteLine("Pessoa não localizada");
        }
    }
    /*static void Demo6()
    {
        int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar");
        var numero = int.Parse(ReadLine());

        var idxEncontrado = EncontrarNumero(numeros,numero); //chama o metodo, passa a lista (numeros), e o numero que foi digitado(numero)

        if(idxEncontrado >= 0) //em vez de retornar o -1 igual está no  metodo, faz a verificação, se for <=0 traz uma mensagem
        {
            WriteLine($"O número digitado está na posição: {idxEncontrado}");
        }   

        else
        {
            WriteLine("O número digitado não foi encontrado");
        }
    }*/
    static void Demo5()
    {
        int[] pares = new int[]{0,2,4,6,8}; //metodo para alterar para o prox numero impar , so somar mais 1
        MudarParaImpar(pares); 
        WriteLine($"Os Impares:  {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Adriano";
        TrocarNome(nome, "Jose");
        WriteLine($"Novo nome é: {nome}");
    }

    static void Demo3()
    {
        {
            StructPessoa p1 = new StructPessoa //nao precisa dar new em scruct
                {
                Documento = "1234",
                Idade = 30,
                Nome = "Adriano"
                };

            var p2 = p1;
            p1 = TrocarNome(p1, "João");
            WriteLine($@"
            Nome do P1: {p1.Nome}
            Nome do P2: {p2.Nome}
            ");
        }   
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa(); //instanciando p1 como classe pessoa... eu acho - Reference Type
        p1.Nome = "Adriano";
        p1.Idade = 29;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();
        
        TrocarNome(p1, "Ricardo"); //Ricardo - Foi referenciado o Ricardo - ReferenceType
        WriteLine($@"
        O nome de P1 é: {p1.Nome} 
        O nome de P2 é: {p2.Nome} 
        "); //Adriano - Criado uma nova instancia e 'pegou' o nome de p1.nome que era Adriano.
    }
    static void Demo1()
    {
        int a= 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variavel A é: {a}"); //Toda essa estrutura é um jeito angito. Hoje o modo é mais clean.
    }
    static int Adicionar20(int x) //isso é um metodo Demo1()
    {
        return x+20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo) //Demo2()
    {
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo) //sobrecarga de metodo, mesmo nome. Demo3()
    {
        p1.Nome = nomeNovo;
        return p1;
    }
        
    static void TrocarNome(string nome, string nomeNovo) //Demo4()
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares) //Demo5()
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i]=pares[i]+1;
        }
    }
    //Demo6() -  Não consegui fazer funcionar
    /*static int EncontrarNumero(int[] numeros, int numero) //isso é um método. Passou o array Numeros e o valor que vou digitar a variavel numero 
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            {
                return i;
            }

            return -1; //se passar pelo if e não encontrar o numero vai retornar -1.
        }
    }*/

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa) //Demo7() List - Não vai funcionar pq está adaptado para Struct
    {
        foreach (var item in pessoas)
        {
            if(item.Nome == pessoa.Nome) //comparando string com string
            {
                return true;
            }
        }
        return false;
    }

    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa) //Demo7() Struct
    {
        foreach (var item in pessoas)
        {
            if(item.Equals(pessoa)) 
            {
                return true;
            }
        }
        return false;
    }
        public static void Main()
    {

    }

}