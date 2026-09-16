using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    internal class PersonajeDePrueba : Personaje
    {
        public PersonajeDePrueba(string nombre, int vidaMaxima, int ataqueBase, int defensaBase)
            : base(nombre, vidaMaxima, ataqueBase, defensaBase)
        {
        }
    }

    // Tests para la clase Personaje
    public class PersonajeTests
    {
        // Prueba que, al construir un personaje, su vida actual quede igual a la vida máxima recibida por parámetro.
        [Test]
        public void Constructor_VidaMaximaValida_InicializaVidaIgualAVidaMaxima()
        {
            const int vidaMaxima = 100;

            Personaje mago = new PersonajeDePrueba("Gandalf", vidaMaxima, 10, 5);

            Assert.That(mago.ObtenerVida(), Is.EqualTo(vidaMaxima));
        }

        // Prueba que RecibirAtaque descuente de la vida exactamente la diferencia entre el poder del ataque y la defensa total del personaje, no el poder bruto.
        [Test]
        public void RecibirAtaque_PoderMayorQueDefensaTotal_DisminuyeVidaEnLaDiferencia()
        {
            const int vidaInicial = 100;
            const int defensaBase = 5;
            const int poderAtaque = 20;
            int vidaEsperada = vidaInicial - (poderAtaque - defensaBase);

            Personaje mago = new PersonajeDePrueba("Gandalf", vidaInicial, 10, defensaBase);

            mago.RecibirAtaque(poderAtaque);

            Assert.That(mago.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }

        /* Prueba la colaboración entre dos personajes: al atacar, el
        atacante usa su ObtenerAtaqueTotal() y el objetivo pierde vida según su propia defensa.*/
        [Test]
        public void RealizarAtaque_ContraOtroPersonaje_DisminuyeVidaDelObjetivo()
        {
            const int vidaObjetivo = 80;
            const int ataqueAtacante = 20;
            const int defensaObjetivo = 5;
            int vidaEsperada = vidaObjetivo - (ataqueAtacante - defensaObjetivo);

            Personaje atacante = new PersonajeDePrueba("Gandalf", 100, ataqueAtacante, 0);
            Personaje objetivo = new PersonajeDePrueba("Gimli", vidaObjetivo, 5, defensaObjetivo);

            atacante.RealizarAtaque(objetivo);

            Assert.That(objetivo.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }
    }
}