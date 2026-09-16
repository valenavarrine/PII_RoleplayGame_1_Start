//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Runtime.Intrinsics.Arm;
<<<<<<< HEAD
=======
using Library;
>>>>>>> especies

namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main(string[] args)
        {
            Mago mago = new Mago("Gandalf el Gris");
            Arma varaMagica = new Arma(valorAtaque: 25);
            Ropaje túnicaAstral = new Ropaje(valorDefensa: 15);

            Mago undertaker = new Mago("undertaker");
            Arma guadaña = new Arma(50);
            Ropaje tunica = new Ropaje(10);
            Elfo Dobby = new Elfo("Dobby");
            Ropaje escudo = new Ropaje(valorDefensa: 20);
            Arma daga = new Arma(valorAtaque: 20);
            Mago Voldemort = new Mago("El volde");
            Arma lapizMagico = new Arma(valorAtaque: 77);
            Ropaje capaMagica = new Ropaje(valorDefensa: 55);
        }
    }
}