using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Adriano";
p1.Idade = 29;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua Bororos",
    CEP = "000000",
    Numero = 1275,
    Cidade = "Tupã",
};

WriteLine("Fim");