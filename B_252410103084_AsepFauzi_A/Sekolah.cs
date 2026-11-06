using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103084_AsepFauzi_A
{
    internal class Sekolah
    {
        public string IdSekolah {  }
        public string NamaSekolah { }
        public int JumlahPaketDiterima {  }

        public Sekolah(string id, string nama, int jumlah)
        {
            IdSekolah = id;
            NamaSekolah = nama;
            JumlahPaketDiterima = jumlah;
        }

        public void TampilInfo()
        {
            Console.WriteLine("ID Sekolah : " + IdSekolah);
            Console.WriteLine("Nama Sekolah : " + NamaSekolah);
            Console.WriteLine("Paket Diterima : " + JumlahPaketDiterima);
        }
}
