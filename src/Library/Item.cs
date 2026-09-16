using System;

namespace Ucu.Poo.RolePlayGame
{
    public abstract class Item 
    {
        private int valorAtaque;
        private int valorDefensa;

        public Item(int valorAtaque, int valorDefensa)
        {
            this.valorAtaque = valorAtaque;
            this.valorDefensa = valorDefensa;
        }    

        public virtual int ObtenerAtaque()
        {
            return this.valorAtaque;
        }

        public virtual int ObtenerDefensa()
        {
            return this.valorDefensa;
        }
    } 
}