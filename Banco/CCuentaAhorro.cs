using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class CCuentaAhorro : CCuenta 
    {
        private double cuotaMantenimiento;

        public CCuentaAhorro() { }

        public CCuentaAhorro(string nom, string cue, double sal, double tipo, double mant) :
            base(nom, cue, sal, tipo)
        {
            cuotaMantenimiento = mant;
        }

        public double CuotaMantenimiento
        {
            get
            {
                return cuotaMantenimiento;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Cantidad negativa");
                    return;
                }
                cuotaMantenimiento = value;
            }
        }

        public new void Reintegro(double cantidad)
        {
            double saldo = this.Saldo;
            double tipoDeInteres = this.TipoDeInteres;

            if(tipoDeInteres >= 3.5)
            {
                if(saldo - cantidad < 1500)
                {
                    Console.WriteLine("Error: No dispone de esa cantidad");
                    return;
                }
            }
            base.Reintegro(cantidad);
        }

    }
    
}
