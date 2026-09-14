namespace Library;

public class Hechizo
{
    private int valorAtaque;
    private int valorDefensa;
    public Hechizo(int valorAtaque, int valorDefensa)
    {
        this.valorAtaque = valorAtaque;
        this.valorDefensa = valorDefensa;
    }
    public int ObtenerAtaque()
    {
        return this.valorAtaque;
    }
    public int ObtenerDefensa()
    {
        return this.valorDefensa;
    }
}