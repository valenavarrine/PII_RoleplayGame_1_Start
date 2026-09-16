using NUnit.Framework;
using Library;
using Ucu.Poo.RolePlayGame;

namespace Library.Tests
{
    [TestFixture]
    public class EnanoTests
    {
        // Prueba que Enano, su vida inicial sea de 200.
        [Test]
        public void Constructor_Enano_InicializaVidaEn200()
        {
            Enano enano = new Enano("Gimli");

            Assert.That(enano.ObtenerVida(), Is.EqualTo(200));
        }

        // Prueba el Enano y el funcionamiento de ataque/defensa recibiendo daño.
        [Test]
        public void RecibirAtaque_AtaqueMayorADefensa_DisminuyeVidaSegunDefensaBase()
        {
            Enano enano = new Enano("Gimli"); // Nace con 200 vida, 12 defensa base
            const int poderAtaque = 30;
            int vidaEsperada = 200 - (poderAtaque - 12);

            enano.RecibirAtaque(poderAtaque);

            Assert.That(enano.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }
    }
}