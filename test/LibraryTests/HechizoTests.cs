using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;


namespace Ucu.Poo.RolePlayGame.Tests
{
    // Tests para la clase Hechizo
    [TestFixture]
    public class HechizoTests
    {
        // Prueba que ObtenerAtaque devuelva el valor de ataque recibido por el constructor.
        [Test]
        public void ObtenerAtaque_HechizoConValorPositivo_DevuelveValorDelConstructor()
        {
            const int valorAtaque = 15;

            Hechizo hechizo = new Hechizo(valorAtaque, 5);

            Assert.That(hechizo.ObtenerAtaque(), Is.EqualTo(valorAtaque));
        }

        // Prueba que ObtenerDefensa devuelva el valor de defensa recibido por el constructor.
        [Test]
        public void ObtenerDefensa_HechizoConValorPositivo_DevuelveValorDelConstructor()
        {
            const int valorDefensa = 5;

            Hechizo hechizo = new Hechizo(15, valorDefensa);

            Assert.That(hechizo.ObtenerDefensa(), Is.EqualTo(valorDefensa));
        }

        // Prueba que un hechizo puramente defensivo tenga su valor de ataque en cero.
        [Test]
        public void ObtenerAtaque_HechizoSoloDefensivo_DevuelveCero()
        {
            Hechizo hechizo = new Hechizo(0, 10);

            Assert.That(hechizo.ObtenerAtaque(), Is.EqualTo(0));
        }
    }
}