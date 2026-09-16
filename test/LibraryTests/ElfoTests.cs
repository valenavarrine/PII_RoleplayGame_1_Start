using NUnit.Framework;
using Library;
using Ucu.Poo.RolePlayGame;

namespace Library.Tests
{
    [TestFixture]
    public class ElfoTests
    {
        // Prueba que Elfo, su vida inicial sea de 150.
        [Test]
        public void Constructor_Elfo_InicializaVidaEn150()
        {
            Elfo elfo = new Elfo("Legolas");

            Assert.That(elfo.ObtenerVida(), Is.EqualTo(150));
        }

        // Prueba que al invocar CurarA sobre un personaje dañado, este recupere su vida total.
        [Test]
        public void CurarA_PersonajeConDano_RestauraVidaAlMaximo()
        {
            Elfo elfo = new Elfo("Legolas");
            PersonajeDePrueba objetivo = new PersonajeDePrueba("Gimli", 200, 10, 0);

            // Simulamos daño directo en el objetivo
            objetivo.RecibirAtaque(50);
            Assert.That(objetivo.ObtenerVida(), Is.LessThan(200));

            elfo.CurarA(objetivo);

            Assert.That(objetivo.ObtenerVida(), Is.EqualTo(200));
        }
    }
}