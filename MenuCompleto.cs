using System;
using System.Collections.Generic;

public class MenuCompleto : MenuComponent
{
    private string nome;
    private List<MenuComponent> secoes = new List<MenuComponent>();

    public MenuCompleto(string nome){
        this.nome = nome;
    }

    public override void AdicionarItem(MenuComponent item)
    {
        secoes.Add(item);
    }

    public override void Mostrar(){
        Console.WriteLine(nome);
        foreach (MenuComponent secao in secoes)
        {
            secao.Mostrar();
        }
    }
}