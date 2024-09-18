using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            ClassAndObject.Perpustakaan.Buku book = new 
                ClassAndObject.Perpustakaan.Buku("The Object-Oriented Thought Process", 
                                                 "Matt Weisfeld", 2013);

            book.TampilkanInfo();

            // Kendaraan
            ClassAndObject.Kendaraan.Mobil car = new
                ClassAndObject.Kendaraan.Mobil("Honda", "Jazz", 2020);

            car.TampilkanSpesifikasi();

            // Laptop
            ClassAndObject.TokoLaptop.Laptop laptop = new
                 ClassAndObject.TokoLaptop.Laptop("ASUS", "Intel Core i7", 16, 512);

            laptop.TampilkanSpesifikasi();


            // Sepeda
            ClassAndObject.TokoSepeda.Sepeda bicy = new
                ClassAndObject.TokoSepeda.Sepeda("BMX", "General", 6);

            bicy.TampilkanInformasi();

            // Kalkulator
            ClassAndObject.OperasiMatematika.Kalkulator calc = new
                ClassAndObject.OperasiMatematika.Kalkulator();

            // Operasi Matematika
            double penjumlahan = calc.Tambah(2, 4);
            calc.TampilkanHasil("Penjumlahan: ", penjumlahan);

            double pengurangan = calc.Kurang(24, 16);
            calc.TampilkanHasil("Pengurangan: ", pengurangan);

            double perkalian = calc.Kali(25, 4);
            calc.TampilkanHasil("Perkalian: ", perkalian);

            double pembagian = calc.Bagi(10, 2);
            calc.TampilkanHasil("Pembagian: ", pembagian);
        }
    }
}
