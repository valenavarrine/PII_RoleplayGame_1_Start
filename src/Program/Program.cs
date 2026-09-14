//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library;

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
            Mago undertaker = new Mago("undertaker");
            Arma guadaña = new Arma(50);
            Ropaje tunica = new Ropaje(10);
            undertaker.AgregarItem(guadaña);
            undertaker.AgregarItem(tunica);
    }
}
