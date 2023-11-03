using System;
using System.Collections.Generic;

public class MenuSeccao : MenuComponent
{
    private string nome;
    private List<MenuComponent> itens = new List<MenuComponent>();

    public MenuSeccao(string nome)
    {
        this.nome = nome;
    }

    public override void AdicionarItem(MenuComponent item)
    {
        itens.Add(item);
    }

    public override void Mostrar()
    {
        Console.WriteLine(nome);
        foreach (MenuComponent item in itens)
        {
            item.Mostrar();
        }
    }
}