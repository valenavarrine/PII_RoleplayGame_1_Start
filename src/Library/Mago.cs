namespace Ucu.Poo.RolePlayGame
{


    public class Mago : Personaje
    {
        // El mago nace siempre con 100 de vida total, su ataque base es 10 y su defensa base es 5
        public Mago(string nombre) : base(nombre, 100, 10, 5)
        {
        }

       public void Estudiar()
        {
            AumentarAtaqueBase(5);
            AumentarDefensaBase(5);
        }
    }
    
}