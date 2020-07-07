using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class CCuenta
    {
        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInteres;

        public CCuenta() { }

        public CCuenta(string nom, string cue, double sal, double tipo)
        {
            Nombre = nom;
            Cuenta = cue;
            Ingreso(sal);
            TipoDeInteres = tipo;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length == 0)
                {
                    System.Console.WriteLine("Error: Cadena vacía");
                    return;
                }
                nombre = value;
            }
        }

        public string Cuenta
        {
            get
            {
                return cuenta;
            }
            set
            {
                if (value.Length == 0)
                {
                    System.Console.WriteLine("Error: Cuenta no válida");
                    return;
                }
                cuenta = value;
            }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Ingreso(double cantidad)
        {
            if (cantidad < 0)
            {
                System.Console.WriteLine("Error: Cantidad negativa");
                return;
            }
            saldo =+ cantidad;
        }

        public void Reintegro(double cantidad)
        {
            if (saldo - cantidad < 0)
            {
                System.Console.WriteLine("Error: no dispone de saldo");
                return;
            }
            saldo =- cantidad;
        }

        public double TipoDeInteres
        {
            get
            {
                return tipoDeInteres;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Error: tipo no válido");
                    return;
                }
                tipoDeInteres = value;
            }
        }
    }

}