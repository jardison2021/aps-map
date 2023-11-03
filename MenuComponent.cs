using System;

public abstract class MenuComponent
{
    public abstract void Mostrar();

    public virtual void AdicionarItem(MenuComponent item)
    {
        throw new NotSupportedException("Operação não suportada");
    }
}