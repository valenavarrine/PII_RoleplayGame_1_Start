using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ArmaTests
    {
        // Prueba que el valor de ataque recibido por el arma sea devuelto correctamente.
        [Test]
        public void ValorAtaqueValido_DevuelveAtaqueCorrecto()
        {
            const int valorAtaque = 15;

            Arma arma = new Arma(valorAtaque);

            Assert.That(arma.ObtenerAtaque(), Is.EqualTo(valorAtaque));
        }

        // Prueba que un arma tenga valor de defensa igual a cero.
        [Test]
        public void ArmaNoTieneDefensa_DevuelveCero()
        {
            Arma arma = new Arma(15);

            Assert.That(arma.ObtenerDefensa(), Is.EqualTo(0));
        }

        // Prueba que un arma pueda tener valor de ataque cero.
        [Test]
        public void ValorAtaqueCero_DevuelveCero()
        {
            Arma arma = new Arma(0);

            Assert.That(arma.ObtenerAtaque(), Is.EqualTo(0));
        }
    }
}
