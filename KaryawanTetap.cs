using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karyawan2595.Induk;

namespace Karyawan2595.Anak
{
    public class KaryawanTetap : Karyawan
    {
        public double gajibulanan { get; set; }
        public override double gaji()
        {
            return gajibulanan;
        }
    }
}
