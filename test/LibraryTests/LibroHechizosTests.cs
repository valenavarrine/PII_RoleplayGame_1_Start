using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;


namespace Ucu.Poo.RolePlayGame.Tests
{
// Tests para la clase LibroDeHechizos
    [TestFixture]
    public class LibroDeHechizosTests
    {
        // Prueba que un libro recién creado, sin hechizos, no aporte ataque.
        [Test]
        public void ObtenerAtaque_LibroSinHechizos_DevuelveCero()
        {
            LibroDeHechizos libro = new LibroDeHechizos();

            Assert.That(libro.ObtenerAtaque(), Is.EqualTo(0));
        }

        // Prueba que un libro recién creado, sin hechizos, no aporte defensa.
        [Test]
        public void ObtenerDefensa_LibroSinHechizos_DevuelveCero()
        {
            LibroDeHechizos libro = new LibroDeHechizos();

            Assert.That(libro.ObtenerDefensa(), Is.EqualTo(0));
        }

        /* Prueba que el poder de ataque del libro se calcule sumando el ataque
        de todos los hechizos que contiene, no como un valor fijo. */
        [Test]
        public void ObtenerAtaque_LibroConVariosHechizos_DevuelveSumaDeSusValoresDeAtaque()
        {
            int ataqueEsperado = 10 + 15 + 5;

            LibroDeHechizos libro = new LibroDeHechizos();
            libro.AgregarHechizo(new Hechizo(10, 0));
            libro.AgregarHechizo(new Hechizo(15, 0));
            libro.AgregarHechizo(new Hechizo(5, 0));

            Assert.That(libro.ObtenerAtaque(), Is.EqualTo(ataqueEsperado));
        }

        // Prueba que el poder de defensa del libro se calcule sumando la defensa de todos sus hechizos.
        [Test]
        public void ObtenerDefensa_LibroConVariosHechizos_DevuelveSumaDeSusValoresDeDefensa()
        {
            int defensaEsperada = 8 + 12;

            LibroDeHechizos libro = new LibroDeHechizos();
            libro.AgregarHechizo(new Hechizo(0, 8));
            libro.AgregarHechizo(new Hechizo(0, 12));

            Assert.That(libro.ObtenerDefensa(), Is.EqualTo(defensaEsperada));
        }

        /* Prueba que, al quitar un hechizo del libro, su valor de ataque
        deje de sumarse en el total. */
        [Test]
        public void QuitarHechizo_HechizoExistente_ObtenerAtaqueYaNoLoSuma()
        {
            Hechizo hechizoASacar = new Hechizo(20, 0);

            LibroDeHechizos libro = new LibroDeHechizos();
            libro.AgregarHechizo(hechizoASacar);
            libro.AgregarHechizo(new Hechizo(10, 0));

            libro.QuitarHechizo(hechizoASacar);

            Assert.That(libro.ObtenerAtaque(), Is.EqualTo(10));
        }
    }
}