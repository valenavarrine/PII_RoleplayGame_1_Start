namespace Ucu.Poo.RolePlayGame {
    public class Elfo : Personaje
    {
        // El elfo nace siempre con 150 de vida total, su ataque base es 8 y su defensa base es 8
        public Elfo(string nombre) : base(nombre, 150, 8, 8)
        {
        }

        public void CurarA(Personaje objetivo)
        {
            if (objetivo != null)
            {
                objetivo.Curar();
            }
        }
    }
}