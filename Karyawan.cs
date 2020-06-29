using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyawan2595.Induk
{
    //abstract class
    public abstract class Karyawan
    {
        //property
        public string nama { get; set; }
        public string nik { get; set; }
        public string jk { get; set; }

        //method abstract
        public abstract double gaji();

    }
}
