﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.OperasiMatematika
{
    public class Kalkulator
    {
        public double Tambah(double a, double b)
        {
            return a+b;
        }

        public double Kurang(double a, double b)
        {
            return a - b;
        }

        public double Kali(double a, double b)
        {
            return a * b;
        }

        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                return double.PositiveInfinity;
            }
            else
            {
                return a / b;
            }
        }
        public void TampilkanHasil(string operasi, double hasil)
        {
            Console.WriteLine($"Hasil operasi {operasi}: {hasil}");
        }
    }
}
