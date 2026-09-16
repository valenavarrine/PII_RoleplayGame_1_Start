//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

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
        }
    }
}