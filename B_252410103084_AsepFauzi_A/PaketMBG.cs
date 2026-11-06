using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103084_AsepFauzi_A
{
    internal class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;

        public string IdPaket
        {
            get { return idPaket; }
            set { idPaket = value; }
        }

        public string NamaPaket
        {
            get { return namaPaket; }
            set { namaPaket = value; }
        }

        public int StokDapur
        {
            get { return stokDapur; }
            private set
            {
                if (value >= 0)
                    stokDapur = value;
            }
        }

        public PaketMBG(string id, string nama, int stok)
        {
            idPaket = id;
            namaPaket = nama;
            StokDapur = stok;
        }

        public bool KurangiStok(int jumlah)
        {
            if (jumlah <= 0 || jumlah > stokDapur)
            {
                return false;
            }

            stokDapur -= jumlah;
            return true;
        }

        public abstract int HitungBiaya(int jumlah);
    }
}
