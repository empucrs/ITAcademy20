class ArrayPilha : IPilha
{
    Object? [] pilha;
    int top;

    public ArrayPilha(){
        this.pilha=new Object[10];
        this.top=-1;
    }
    public object? topo{
        get{ 
            if(top>=0){
                top--;
                return this.pilha[top+1];
            }
            return null; 
        }
    }

    public object? desempilha()
    {
        if(top>=0)
            return pilha[top--];
        return null;
    }

    public void empilha(object? o)
    {
        if(top<pilha.Length){
            pilha[++top] = o;
        }
            
    }
}