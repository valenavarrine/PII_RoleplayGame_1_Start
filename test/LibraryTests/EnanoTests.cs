using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    // Tests para la clase Enano (Debe ser public para NUnit)
    public class EnanoTests
    {
        // Prueba que al construir un Enano, su vida inicial sea exactamente 200.
        [Test]
        public void Constructor_InicializaVidaEnDoscientos()
        {
            const int vidaEsperada = 200;

            Enano enano = new Enano("Gimli");

            Assert.That(enano.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }

        // Prueba que RecibirAtaque descuente de la vida la diferencia entre el poder del ataque y la defensa base del Enano.
        [Test]
        public void RecibirAtaque_PoderMayorQueDefensaBase_DisminuyeVidaEnLaDiferencia()
        {
            const int vidaInicial = 200;
            const int defensaBaseEnano = 12;
            const int poderAtaque = 30;
            int vidaEsperada = vidaInicial - (poderAtaque - defensaBaseEnano);

            Enano enano = new Enano("Gimli");

            enano.RecibirAtaque(poderAtaque);

            Assert.That(enano.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }
    }
}