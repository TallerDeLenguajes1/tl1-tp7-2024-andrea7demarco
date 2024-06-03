namespace EspacioCalculadora;

public class Calculadora{ 
    private double valor; //atributo privado 

    public Calculadora() //constructor 
    {
        valor=0;
    }

    public double Resultado { get => valor;} //prop ,definir get


    public void Suma(double sumando)   //metodo
    {
        valor+=sumando;
    }

    public void Resta(double sustraendo)
    {
        valor-=sustraendo;
    }

    public void Multiplicacion(double factor)
    {
        valor*=factor;
    }

    public void Division(double divisor)
    {   
        valor/=divisor;
    }

    public void Limpiar()
    {
        valor=0;
    }






}