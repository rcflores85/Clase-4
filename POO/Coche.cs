using System;

namespace POO
{
    public class Coche
    {
        public string Patente;
        public string Marca;
        public string Modelo;
        public string Color;
        protected double velocidad; // = 0; Lo ideal es inicializar en el constructor.
        // protected para que no pueda ser modificado de afuera.

        public Coche (
            string patente,
            string marca,
            string modelo,
            string color)
        {
            this.Patente = patente;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.velocidad = 0;
        }

        public double Velocidad
        {
            get{return velocidad;}
        }

        // Es virtual, para que pueda sobreescribirse el metodo.
        public virtual void Acelerar (double cantidad)
        {
            Console.WriteLine("Incrementando la velocidad en: {0} Km/h", cantidad);
            //Console.Writeline($"Incrementando la velocidad en: {cantidad} Km/h"); Otra manera de hacer lo mismo que arriba.
            this.velocidad += cantidad;
        }

        public void Girar (double cantidad)
        {
            Console.WriteLine("Girando el coche en: {0} grados", cantidad);
        }
        public void Frenar (double cantidad)
        {
            Console.WriteLine("Reduciendo la velocidad en: {0} Km/h", cantidad);
            this.velocidad -= cantidad;
        }
    }
}