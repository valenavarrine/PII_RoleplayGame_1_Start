using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    [TestFixture]
    public class TestClass
    {
         public class MagoTests
        {
            private Mago mago;
            private Elfo elfo;
            private Enano enano;

            private Arma baston;
            private Arma arco;
            private Ropaje chaleco;

            [SetUp]
            public void Setup()
            {
                mago = new Mago("Gandalf");
                baston = new Arma(20);
                mago.AgregarItem(baston);

                elfo = new Elfo("Legolas");
                arco = new Arma(30);
                elfo.AgregarItem(arco);

                enano = new Enano("Rat");
                chaleco = new Ropaje(10);
                enano.AgregarItem(chaleco);
            }

            [Test]
            public void AtaqueTotalDebeIncluirElBaston()
            {
                int ataque = mago.ObtenerAtaqueTotal();

                Assert.That(ataque, Is.EqualTo(30));
            }

            [Test]
            public void DefensaTotalDebeIncluirElChaleco()
            {
                int defensa = enano.ObtenerDefensaTotal();

                Assert.That(defensa, Is.EqualTo(22));
            }

            [Test]
            public void DebePoderQuitarElBaston()
            {
                mago.QuitarItem(baston);
                int ataque = mago.ObtenerAtaqueTotal();

                Assert.That(ataque, Is.EqualTo(10));
            }

            [Test]
            public void AtaqueAEnemigoDebeReducirSuVida()
            {
                mago.RealizarAtaque(enano);

                Assert.That(enano.ObtenerVida(), Is.EqualTo(182));
            }

            [Test]
            public void ElfoDebePoderCurarAlEnano()
            {
                mago.RealizarAtaque(enano);
                elfo.CurarA(enano);
                
                Assert.That(enano.ObtenerVida(), Is.EqualTo(200));
            }

            [Test]
            public void EstudiarDebeAumentarDefensaDelMago()
            {
                mago.Estudiar();

                Assert.That(mago.ObtenerDefensaTotal(), IsEqualTo(/    /));
            }
            [Test]
            public void EstudiarDebeAumentarAtaqueDelMago()
            {
                mago.Estudiar();

                Assert.That(mago.ObtenerAtaqueTotal(), IsEqualTo(/    /));
            }
            [Test]
            public void AtaqueMortalNoDebeDejarVidaNegativa()
            {
                Mago magoFuerte = new Mago("Sorton");
                Arma armaPoderosa = new Arma(500);
                magoFuerte.AgregarItem(armaPoderosa);
                Enano enano = new Enano("Gimli");
                magoFuerte.RealizarAtaque(enano);

                Assert.That(enano.ObtenerVida(), Is.EqualTo(0));
            }
        }
    }
}