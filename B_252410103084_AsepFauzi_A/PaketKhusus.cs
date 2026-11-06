using System;
using System.Collections.Generic;
using System.Text;

namespace B_252410103084_AsepFauzi_A
{
    internal class PaketKhusus
    {

        public string JenisDiet { get; set; }

        public PaketKhusus(string id, string nama, int stok, string diet)
            : base(id, nama, stok)
        {
            JenisDiet = diet;
        }

    }
}
