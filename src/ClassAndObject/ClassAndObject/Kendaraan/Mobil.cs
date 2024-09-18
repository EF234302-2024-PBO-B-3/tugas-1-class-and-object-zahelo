﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk { get; set; }
        public string Model { get; set; }
        public int TahunProduksi { get; set; }

        // Konstruktor
        public Mobil(string merk, string model, int tahunProduksi)
        {
            Merk = merk;
            Model = model;
            TahunProduksi = tahunProduksi;
        }

        // Metode untuk menampilkan spesifikasi mobil
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }
    }
}
