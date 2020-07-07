using System;
using System.Collections.Generic;
using System.Text;


namespace Banco
{


    class Test
    {
        public static void Main(string[] args)
        {
            CCuentaAhorro cuenta01 = new CCuentaAhorro("Un nombre", "Una cuenta", 6000, 3.5, 0.60);
            

            

            
            cuenta01.Reintegro(cuenta01.CuotaMantenimiento);
            cuenta01.Ingreso(6000);
            cuenta01.Reintegro(1000);

            Console.WriteLine(cuenta01.Nombre);
            Console.WriteLine(cuenta01.Cuenta);
            Console.WriteLine(cuenta01.Saldo);
            Console.WriteLine(cuenta01.TipoDeInteres);
            
        }
    }

}