using System;

namespace POO
{
    // CocheInteligente hereda de la clase Coche, suma la funcionalidad de Estacionar, y tiene diferente aceleracion.
    public class CocheInteligente: Coche
    {
        public CocheInteligente(string patente, string color, string marca, string modelo)
        : base(patente, color, marca, modelo)
        {
            
        }
        public void Estacionar()
        {
            Console.WriteLine("Estacionando el coche en modo automático");
            velocidad = 0;
        }

        //Sobreescribo el metodo Acelerar, para que tenga distinto comportamiento que Coche. Para esto, el metodo debe ser virtual.
        public override void Acelerar(double cantidad)
        {
            Console.WriteLine("Accionando mecanismo avanzado de aceleración");
            Console.WriteLine("Incrementando la velocidad en: {0} Km/h", cantidad);
            velocidad += cantidad;
        }
    }
}