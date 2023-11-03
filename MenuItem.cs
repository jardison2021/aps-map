using System;
public class MenuItem : MenuComponent
{
    private string nome;
    private string descricao;
    private double preco;

    public MenuItem(string nome, string descricao, double preco)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
    }

    public override void Mostrar()
    {
        Console.WriteLine($"{nome} - {descricao} - R${preco:F2}");
    }
}