using System;
using System.Collections.Generic;

public class Guiche
{

    private int id;
    private Queue<Senha> atendimentos;

    
    public Guiche()
    {
        atendimentos = new Queue<Senha>();
        id = 0;
    }

    
    public Guiche(int id)
    {
        atendimentos = new Queue<Senha>();
        this.id = id;
    }

    
    public bool Chamar(Queue<Senha> filaSenhas)
    {
        if (filaSenhas.Count > 0)
        {
            Senha proximaSenha = filaSenhas.Dequeue();
            atendimentos.Enqueue(proximaSenha);
            Console.WriteLine($"Guichê {id}: Chamando senha {proximaSenha.DadosCompletos()}");
            return true;
        }
        else
        {
            Console.WriteLine($"Guichê {id}: Não há senhas disponíveis para atendimento.");
            return false;
        }
    }


    public Queue<Senha> Atendimentos
    {
        get { return atendimentos; }
    }

    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}   
