using System;
class Lista
{
    private Produto[] array;
    private int n;

    public Lista(int tamanho)
    {
        array = new Produto[tamanho+1];
        n = 0;
    }
  
    public void InserirFim(Produto x)
    {
        if (n >= array.Length)
        {
            throw new Exception("Erro ao inserir!");
        }
        array[n] = x;
        n++;
    }

    public Produto RemoverItem(string nome)
    {
        Produto resp;
        int pos = 0;

        if (n == 0)
        {
            throw new Exception("Erro ao remover!");
        }
        for (int i = 0; i < n; i++)
        {
            if (array[i].Nome== nome)
            {
                resp = array[i];
                pos = i;
                n--;
                return resp;
            }
        }
        for (int i = pos; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return null;
    }

    public bool Pesquisar(string nome)
    {
        for (int i = 0; i < n; i++)
        {
            if (array[i].Nome == nome)
            {
                return true;
            }
        }

        return false;
    }
    public void Mostrar()
    {
        Console.Write("[ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("]");
    }


}