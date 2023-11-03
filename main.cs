using System;
using System.Collections.Generic;

public class CompositeMenu
{
    public static void Main(string[] args)
    {
        MenuComponent entrada1 = new MenuItem("Coxinha", "Salgado de massa recheada com frango", 5.99);
        MenuComponent pratoPrincipal1 = new MenuItem("Feijoada", "Prato tradicional brasileiro com feijão preto e carne de porco", 19.99);
        MenuComponent sobremesa1 = new MenuItem("Brigadeiro", "Doce de chocolate brasileiro", 3.99);

        MenuComponent entradas = new MenuSeccao("Entradas");
        entradas.AdicionarItem(entrada1);

        MenuComponent pratosPrincipais = new MenuSeccao("Pratos Principais");
        pratosPrincipais.AdicionarItem(pratoPrincipal1);

        MenuComponent sobremesas = new MenuSeccao("Sobremesas");
        sobremesas.AdicionarItem(sobremesa1);

        MenuComponent menuCompleto = new MenuCompleto("Cardápio Completo");
        menuCompleto.AdicionarItem(entradas);
        menuCompleto.AdicionarItem(pratosPrincipais);
        menuCompleto.AdicionarItem(sobremesas);

        menuCompleto.Mostrar();
    }
}