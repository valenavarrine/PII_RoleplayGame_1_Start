using System;
using NUnit.Framework;
using Ucu.Poo.RolePlayGame;

namespace Ucu.Poo.RolePlayGame.Tests
{
    // Clase auxiliar interna para simular objetivos de curación
    internal class PersonajeDePrueba : Personaje
    {
        public PersonajeDePrueba(string nombre, int vidaMaxima, int ataqueBase, int defensaBase)
            : base(nombre, vidaMaxima, ataqueBase, defensaBase)
        {
        }
    }

    public class ElfoTests
    {
        // Prueba que al construir un Elfo, su vida inicial sea exactamente 150.
        [Test]
        public void Constructor_InicializaVidaEnCientoCincuenta()
        {
            const int vidaEsperada = 150;

            Elfo elfo = new Elfo("Legolas");

            Assert.That(elfo.ObtenerVida(), Is.EqualTo(vidaEsperada));
        }

        // Prueba que al ejecutar la habilidad CurarA sobre un personaje dañado, este recupere la totalidad de su vida inicial.
        [Test]
        public void CurarA_PersonajeConDano_RestauraVidaAlMaximo()
        {
            const int vidaMaximaObjetivo = 200;
            const int danoRecibido = 50;

            Elfo elfo = new Elfo("Legolas");
            Personaje objetivo = new PersonajeDePrueba("Objetivo", vidaMaximaObjetivo, 10, 0);

            objetivo.RecibirAtaque(danoRecibido);

            elfo.CurarA(objetivo);

            Assert.That(objetivo.ObtenerVida(), Is.EqualTo(vidaMaximaObjetivo));
        }
    }
}