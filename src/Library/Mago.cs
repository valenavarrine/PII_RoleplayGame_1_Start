namespace Library;

public class Mago : Personaje
{
    // El mago nace siempre con 100 de vida total su ataque base es 10 su defensabase es 5
    public Mago(string nombre) : base(nombre, 100, 10, 5)
    {
    }

    public void Estudiar()
    {
        // Lógica para estudiar
    }
}


