using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karyawan2595.Induk;

namespace Karyawan2595.Anak
{
   public class Sales : Karyawan
    {
        public int JmlPenjualan { get; set; }
        public int Komisi { get; set; }
        public override double gaji()
        {
            return JmlPenjualan * Komisi;
        }
    }
}
