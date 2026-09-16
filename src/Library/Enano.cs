namespace Library;

public class Enano : Personaje
{
    // El enano nace siempre con 200 de vida que es su total, su ataque base es 12 y su defensa base es 12
    public Enano(string nombre) : base(nombre, 200, 12, 12)
    {
    }
}