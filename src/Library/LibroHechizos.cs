namespace Library;

public class LibroDeHechizos : Item
{
    private List<Hechizo> hechizos;
    public LibroDeHechizos()
    {
        hechizos = new List<Hechizo>();
    }
    public void AgregarHechizo(Hechizo h)
    {
        hechizos.Add(h);
    }
    public void QuitarHechizo(Hechizo h)
    {
        hechizos.Remove(h);
    }
     public override int ObtenerAtaque()
    {
        int ataqueTotal = 0;
        foreach (Hechizo h in hechizos)
        {
            ataqueTotal += h.ObtenerAtaque();
        }
        return ataqueTotal;
    }
    public override int ObtenerDefensa()
    {
        int defensaTotal = 0;
        foreach (Hechizo h in hechizos)
        {
            defensaTotal += h.ObtenerDefensa();
        }
        return defensaTotal;
    }
}