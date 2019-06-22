using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empleado empleado = new Empleado();
            Empleado empleado = new EmpleadoFullTime(12223311, "Juan", "Perez", 30000);
            Console.WriteLine("El sueldo de {0} es de {1}", empleado.Apellido, empleado.SueldoMensual());

            Empleado empleadoFL = new Freelancer(12223312, "Juan", "Lopez", 250, 80);
            Console.WriteLine("El sueldo de {0} es de {1}", empleadoFL.Apellido, empleadoFL.SueldoMensual());
        }

        /* static void MainClasesAbstractas
        {
            //A claseA = new A();
            //B claseB = new B();
            C claseC = new C();
            claseC.F();
            claseC.G();
            D claseD = new D();
            claseD.F();
        }*/
        
        /* static void MainCuenta()
        {
            //Main Coche();
            //CuentaCorriente miCuenta = new CuentaCorriente();
            CuentaCorriente.MetodoEstatico();
            //miCuenta.Deposito(200.55);
            //Console.WriteLine("El saldo de la cuenta es de: {0}", miCuenta.Saldo);
            //miCuenta.Deposito(200.55, 600);
            //Console.WriteLine("El saldo de la cuenta es de: {0}", miCuenta.Saldo);
            //miCuenta.Deposito(35.89F); //indicamos que es float.
            //Console.WriteLine("El saldo de la cuenta es de: {0}", miCuenta.Saldo);
            //miCuenta.Deposito(10);
            //Console.WriteLine("El saldo de la cuenta es de: {0}", miCuenta.Saldo);
            //miCuenta.Deposito(300L); //indicamos que es long.
            //Console.WriteLine("El saldo de la cuenta es de: {0}", miCuenta.Saldo);
        }*/

        /* static void Main Coche
        {
            //Coche miCoche = new Coche("AAA11AA", "Blanco", "Ford", "Fiesta");
            //Coche miCoche = new CocheInteligente("ABC222", "Azul", "Honda", "Civic");
            CocheInteligente miCoche = new CocheInteligente("ABC222", "Azul", "Honda", "Civic");

            Console.WriteLine("Los datos de mi coche son:");
            Console.WriteLine("Marca: {0}", miCoche.Marca);
            Console.WriteLine("Modelo: {0}", miCoche.Modelo);
            Console.WriteLine("Color: {0}", miCoche.Color);
            Console.WriteLine("Patente: {0}", miCoche.Patente);

            miCoche.Acelerar(100);
            Console.WriteLine("La velocidad actual es de: {0} Km/h", miCoche.Velocidad);
            //Console.Writeline("La velocidad actual es de: {0} Km/h", miCoche.Velocidad.ToString()); // Si hiciera falta convertir el tipo de dato a string.
            miCoche.Frenar(75);
            Console.WriteLine("La velocidad actual es de: {0} Km/h", miCoche.Velocidad);
            miCoche.Girar(45);

            miCoche.Estacionar();
            // no se puede modificar la velocidad, el campo es protected
            //miCoche.Velocidad = 80;
            //Console.Writeline("La velocidad actual es de: {0} Km/h", miCoche.Velocidad);
        }*/
    }
}
