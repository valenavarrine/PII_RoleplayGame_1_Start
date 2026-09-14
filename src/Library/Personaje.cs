using System;
using System.Collections.Generic;
using System.Linq; // para poder usar Sum()

namespace Ucu.Poo.RolePlayGame
{
    public abstract class Personaje
    {
        private string nombre {get; }
        private int vida {get; }
        private int vidaMaxima {get; }
        private int ataqueBase;
        private int defensaBase;
        private List<Item> items = new List<Item>();

        protected Personaje(string nombre, int vidaMaxima, int ataqueBase, int defensaBase)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));
            if (vidaMaxima <= 0)
                throw new ArgumentException("La vida máxima debe ser positiva.", nameof(vidaMaxima));
            if (ataqueBase < 0)
                throw new ArgumentException("El ataque base no puede ser negativo.", nameof(ataqueBase));
            if (defensaBase < 0)
                throw new ArgumentException("La defensa base no puede ser negativa.", nameof(defensaBase));

            this.nombre = nombre;
            this.vidaMaxima = vidaMaxima;
            this.vida = vidaMaxima;
            this.ataqueBase = ataqueBase;
            this.defensaBase = defensaBase;
        }

        public void AgregarItem(Item item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));
            this.items.Add(item);
        }

        public void QuitarItem(Item item)
        {
            this.items.Remove(item);
        }
        public int ObtenerAtaqueTotal()
        {
            return this.ataqueBase + this.items.Sum(item => item.ObtenerAtaque());
        }

        public int ObtenerDefensaTotal()
        {
            return this.defensaBase + this.items.Sum(item => item.ObtenerDefensa());
        }

        public void RecibirAtaque(int poder)
        {
            if (poder < 0)
                throw new ArgumentException("El poder de ataque no puede ser negativo.", nameof(poder));

            int danio = Math.Max(poder - ObtenerDefensaTotal(), 0);
            this.vida = Math.Max(this.vida - danio, 0);
        }

        public void Curar()
        {
            this.vida = this.vidaMaxima;
        }

        // Un personaje ataca a otro usando su propio ataque total
        public void RealizarAtaque(Personaje objetivo)
        {
            if (objetivo is null)
                throw new ArgumentNullException(nameof(objetivo));

            objetivo.RecibirAtaque(this.ObtenerAtaqueTotal());
        }

        protected void AumentarAtaqueBase(int cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.", nameof(cantidad));

            this.ataqueBase += cantidad;
        }

        protected void AumentarDefensaBase(int cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.", nameof(cantidad));

            this.defensaBase += cantidad;
        }
    }
}