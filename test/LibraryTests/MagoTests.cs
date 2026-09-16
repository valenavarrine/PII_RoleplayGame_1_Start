using NUnit.Framework;
using Library;
using Ucu.Poo.RolePlayGame;

namespace Library.Tests
{
    [TestFixture]
    public class MagoTests
    {
        // Prueba que  Mago, este se construya con 100 de vida inicial.
        [Test]
        public void Constructor_Mago_InicializaVidaEn100()
        {
            Mago mago = new Mago("Gandalf");

            Assert.That(mago.ObtenerVida(), Is.EqualTo(100));
        }

        // Prueba que  LibroDeHechizos equipado y estudiar  nuevo hechizo, el Mago aumente su ataque y defensa base.
        [Test]
        public void Estudiar_ConLibroEquipado_AumentaEstadisticasBase()
        {
            Mago mago = new Mago("Gandalf");
            LibroDeHechizos libro = new LibroDeHechizos();
            mago.AgregarItem(libro); // O mago.Equipar(libro) según su implementación de Personaje

            Hechizo bolaDeFuego = new Hechizo("Bola de Fuego", 15, 5);

            // Mago ataca a un objetivo sin defensa para calcular el ataque previo
            PersonajeDePrueba objetivo = new PersonajeDePrueba("Objetivo", 200, 0, 0);
            int ataquePrevio = mago.ObtenerAtaqueTotal();

            mago.Estudiar(bolaDeFuego);

            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(ataquePrevio + 15));
        }

        // Prueba que Mago NO posee LibroDeHechizos entre  ítems, el método Estudiar no modifica estadísticas.
        [Test]
        public void Estudiar_SinLibroEquipado_NoModificaEstadisticasBase()
        {
            Mago mago = new Mago("Gandalf");
            Hechizo bolaDeFuego = new Hechizo("Bola de Fuego", 15, 5);

            int ataquePrevio = mago.ObtenerAtaqueTotal();

            mago.Estudiar(bolaDeFuego);

            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(ataquePrevio));
        }
    }
}