using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103084_AsepFauzi_A
{
    internal class PaketReguler
    {
        public PaketReguler(string id, string nama, int stok)
       : base(id, nama, stok)
        {
        }

        public override int HitungBiaya(int jumlah)
        {
            return jumlah * 15000;
        }
    }
}
