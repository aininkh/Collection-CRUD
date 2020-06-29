using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karyawan2595.Induk;

namespace Karyawan2595.Anak
{
    public class KaryawanHarian : Karyawan
    {
        public int JmlJamKerja { get; set; }
        public int UpahperJam { get; set; }

        public override double gaji()
        {
            return JmlJamKerja * UpahperJam;
        }
    }
}
