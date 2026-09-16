using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    // Clase auxiliar interna para simular objetivos de pruebas
    internal class PersonajeDePrueba : Personaje
    {
        public PersonajeDePrueba(string nombre, int vidaMaxima, int ataqueBase, int defensaBase)
            : base(nombre, vidaMaxima, ataqueBase, defensaBase)
        {
        }
    }


    public class MagoTests
    {
        // Prueba que al construir un Mago, su vida inicial sea exactamente 100.
        [Test]
        public void Constructor_InicializaVidaEnCien()
        {
            const int vidaEsperada = 100;

            Mago mago = new Mago("Gandalf");

            Assert.That(mago.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }

        // Prueba que al estudiar un nuevo hechizo con un LibroDeHechizos equipado, se incrementen las estadísticas base.
        [Test]
        public void Estudiar_ConLibroEquipado_AumentaEstadisticasBase()
        {
            const int ataqueHechizo = 15;
            const int defensaHechizo = 5;

            Mago mago = new Mago("Gandalf");
            LibroDeHechizos libro = new LibroDeHechizos();
            mago.AgregarItem(libro);

            Hechizo bolaDeFuego = new Hechizo("Bola de Fuego", ataqueHechizo, defensaHechizo);

            int ataqueInicial = mago.ObtenerAtaqueTotal();

            mago.Estudiar(bolaDeFuego);

            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(ataqueInicial + ataqueHechizo));
        }

        [Test]
        public void Estudiar_SinLibroEquipado_NoModificaEstadisticasBase()
        {
            Mago mago = new Mago("Gandalf");
            Hechizo bolaDeFuego = new Hechizo("Bola de Fuego", 15, 5);

            int ataqueInicial = mago.ObtenerAtaqueTotal();

            mago.Estudiar(bolaDeFuego);

            Assert.That(mago.ObtenerAtaqueTotal(), Is.EqualTo(ataqueInicial));
        }
    }
}