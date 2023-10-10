using System;
class Produto
{
    private string nome;
    private int quant;
    private double preco;

    public Produto(string nome, int quant, double preco)
    {
        this.nome = nome;
        this.quant = quant;
        this.preco = preco;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Quant
    {
        get { return quant; }
        set { quant = value; }
    }

    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }

    public override String ToString()
    {
        return "[nome=" + nome + ", quantidade=" + quant + ", preço=" + preco + "]";
    }
}