using System;

public class Senha
{
   
    private int id;
    private DateTime dataGerac;
    private DateTime horaGerac;
    private DateTime dataAtend;
    private DateTime horaAtend;

   
    public Senha(int id)
    {
        this.id = id;
        this.dataGerac = DateTime.Now.Date;
        this.horaGerac = DateTime.Now;
    }

    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public DateTime DataGerac
    {
        get { return dataGerac; }
    }

    public DateTime HoraGerac
    {
        get { return horaGerac; }
    }

    public DateTime DataAtend
    {
        get { return dataAtend; }
        set { dataAtend = value; }
    }

    public DateTime HoraAtend
    {
        get { return horaAtend; }
        set { horaAtend = value; }
    }

    public string DadosParciais()
    {
        return $"{Id}-{DataGerac:dd/MM/yyyy}-{HoraGerac:HH:mm}";
    }

    
    public string DadosCompletos()
    {
        return $"{Id}-{DataGerac:dd/MM/yyyy}-{HoraGerac:HH:mm}-{DataAtend:dd/MM/yyyy}-{HoraAtend:HH:mm}";
    }
}