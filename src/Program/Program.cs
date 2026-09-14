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
            Elfo Dobby = new Elfo("Dobby");
            Ropaje escudo = new Ropaje(valorDefensa: 20);
            Arma daga = new Arma(valorAtaque: 20);
        }
    }
}