//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Runtime.Intrinsics.Arm;

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
            Mago Harry = new Mago("Harry el potter");
            Arma lapizMagico = new Arma(valorAtaque: 75);
            Ropaje capaMagica = new Ropaje(valorDefensa: 50); 
        }
    }
}
