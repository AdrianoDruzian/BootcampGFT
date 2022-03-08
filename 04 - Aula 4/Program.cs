using static System.Console;
Numero a = new Numero(2);
Numero b = new Numero(2);

if(a.N == b.N)
{
    WriteLine("A e B são iguais");
}
else
{
    WriteLine("A e B são diferentes");
}

class Numero
{
    public int N { get; set; } //N é um valuetype
    public Numero(int n)
    {
        N = n;
    }
}