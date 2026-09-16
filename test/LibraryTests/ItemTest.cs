using System;
using System.Collections;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    internal class ItemDePrueba : Item
    {
        public ItemDePrueba(int valorAtaque, int valorDefensa)
            : base(valorAtaque,valorDefensa)
        {
        }
    }

    // Tests para la clase Item
    public class ItemTests
    {
        // Prueba que el valor de ataque recibido al crear el Item sea devuelto correctamente.
        [Test]
        public void ObtenerAtaque_DevuelveValorAtaqueCorrecto()
        {
            const int valorAtaque = 25;
            Item item = new ItemDePrueba(valorAtaque, 10);
            Assert.That(item.ObtenerAtaque(), Is.EqualTo(valorAtaque));
        }

        // Prueba que el valor de defensa recibido al crear el Item sea devuelto correctamente.
        [Test]
        public void ObtenerDefensa_DevuelveValorDefensaCorrecto()
        {
            const int valorDefensa = 20;

            Item item = new ItemDePrueba(30,valorDefensa);

            Assert.That(item.ObtenerDefensa(), Is.EqualTo(valorDefensa));
        }
        //Prueba que un Item pueda tener valor de ataque 0.
        public void ObtenerAtaque_ConValorCero()
        {
            Item item = new ItemDePrueba(0,20);
            Assert.That(item.ObtenerAtaque(), Is.EqualTo(0));
        }
        //Prueba que un Item pueda tener valor de defensa 0.
        public void ObtenerDefensa_ConValorCero()
        {
            Item item = new ItemDePrueba(20,0);
            Assert.That(item.ObtenerDefensa(), Is.EqualTo(0));
        }
    }
}