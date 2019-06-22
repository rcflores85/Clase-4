using System;

namespace POO
{
    public class CuentaCorriente
    {
        protected double saldo = 0;

        public double Saldo
        {
            get{ return saldo; }
        }

        public bool Extraccion(double cantidad)
        {
            if (cantidad <= 0) return false;
            this.saldo -= cantidad;
            return true;
        }

        public bool Deposito(double cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con double como argumento");
            this.saldo += cantidad;
            return true;
        }

        public bool Deposito(double cantidad, double otraCantidad)
        {
            Console.WriteLine("Ejecutando Deposito con double y otraCantidad con double como argumento");
            this.saldo += cantidad + otraCantidad;
            return true;
        }

        public bool Deposito(float cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con float como argumento");
            this.saldo += cantidad;
            return true;
        }

        public static void MetodoEstatico()
        {
            Console.WriteLine("Constante con valor: {0}", constante);
            Console.WriteLine("LLamando metodo sin instanciar la clase");
        }

        const int constante = 5;
    }
}