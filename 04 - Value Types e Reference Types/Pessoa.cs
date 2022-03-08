public class Pessoa
{
    public int Idade { get; set; }
    public string  Nome { get; set; }
    public string Documento { get; set; }

    public Pessoa Clone() //metodo que clona os valores de p1 e 'armazena' em p2.
    {
        return new Pessoa() //nova instancia de pessoa
        {
            Documento = this.Documento, 
            Idade = this.Idade,
            Nome = this.Nome
        };
    }

}