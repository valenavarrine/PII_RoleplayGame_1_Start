namespace Library;

public class Mago : Personaje
{
    // El mago nace siempre con 100 de vida total, su ataque base es 10 y su defensa base es 5
    public Mago(string nombre) : base(nombre, 100, 10, 5)
    {
    }

    public void Estudiar(Hechizo nuevoHechizo)
    {
        // LibroDeHechizos se guarda como item
        foreach (Item item in this.Items)
        {
            if (item is LibroDeHechizos libro)
            {
                // Se agrega el hechizo al libro
                libro.AgregarHechizo(nuevoHechizo);

                // Punto 6: Aumenta la base del Mago al estudiar
                this.AumentarAtaqueBase(nuevoHechizo.Ataque);
                this.AumentarDefensaBase(nuevoHechizo.Defensa);

                Console.WriteLine($"{this.Nombre} nuevo hechizo: {nuevoHechizo.Nombre}");
                return;
            }
        }
        
        // Si no tenía un libro, no puede estudiar el hechizo
        Console.WriteLine($"{this.Nombre} necesita un Libro de Hechizos para poder estudiar.");
    }
}