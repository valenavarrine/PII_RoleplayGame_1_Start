using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class RopajeTests
    {
        // Prueba que el valor de defensa recibido por el ropaje sea devuelto correctamente.
        [Test]
        public void ValorDefensaValido_DevuelveDefensaCorrecta()
        {
            const int valorDefensa = 25;

            Ropaje ropaje = new Ropaje(valorDefensa);

            Assert.That(ropaje.ObtenerDefensa(), Is.EqualTo(valorDefensa));
        }

        // Prueba que un ropaje tenga valor de ataque igual a cero.
        [Test]
        public void RopajeNoTieneAtaque_DevuelveCero()
        {
            Ropaje ropaje = new Ropaje(25);

            Assert.That(ropaje.ObtenerAtaque(), Is.EqualTo(0));
        }

        // Prueba que un ropaje pueda tener valor de defensa cero.
        [Test]
        public void ValorDefensaCero_DevuelveCero()
        {
            Ropaje ropaje = new Ropaje(0);

            Assert.That(ropaje.ObtenerDefensa(), Is.EqualTo(0));
        }
    }
}