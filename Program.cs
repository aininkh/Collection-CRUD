using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karyawan2595.Anak;
using Karyawan2595.Induk;

namespace Karyawan2595
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas 9-CRUD";
            int pil;
            List<Karyawan> listkaryawan = new List<Karyawan>();
            do
            {
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomor Menu [1..4] : ");
                pil = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pil)
                {
                    case 1:
                         Console.WriteLine("Tambah Data Karyawan");
                        Console.Write("Jenis Karyawan[1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                        int pilihan = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch(pilihan)
                        {

                            case 1:
                                KaryawanTetap karyawantetap = new KaryawanTetap();

                            Console.Write("NIK : ");
                            karyawantetap.nik = Console.ReadLine();

                            Console.Write("Nama : ");
                            karyawantetap.nama = Console.ReadLine();

                            Console.Write("Gaji Bulanan : ");
                            karyawantetap.gajibulanan=Convert.ToDouble(Console.ReadLine());

                            listkaryawan.Add(karyawantetap);

                                break;

                            case 2:
                                KaryawanHarian karyawanharian = new KaryawanHarian();

                                Console.Write("NIK : ");
                                karyawanharian.nik = Console.ReadLine();

                                Console.Write("Nama : ");
                                karyawanharian.nama = Console.ReadLine();

                                Console.Write("Jumlah Jam Kerja : ");
                                karyawanharian.JmlJamKerja = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Upah Per Jam : ");
                                karyawanharian.UpahperJam = Convert.ToInt32(Console.ReadLine());

                                listkaryawan.Add(karyawanharian);

                                break;

                            case 3:
                                Sales sales = new Sales();

                                Console.Write("NIK : ");
                                sales.nik = Console.ReadLine();

                                Console.Write("Nama : ");
                                sales.nama = Console.ReadLine();

                                Console.Write("Jumlah Jual : ");
                                sales.JmlPenjualan = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Komisi : ");
                                sales.Komisi = Convert.ToInt32(Console.ReadLine());

                                listkaryawan.Add(sales);

                                break;

                            default:
                                Console.WriteLine("Menu Yang Anda Masukkan Tidak Tersedia");

                                break;

                        }
                        break;

                    case 2:
                        int no = -1, hapus = -1;
                        Console.WriteLine("Hapus Data Karyawan\n");
                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();

                        foreach (Karyawan karyawan in listkaryawan)
                        {
                            no++;
                            if(karyawan.nik == nik)
                            {
                                hapus = no;
                            }
                        }

                        if(hapus != -1)
                        {
                            listkaryawan.RemoveAt(hapus);
                            Console.WriteLine("\nData Berhasil dihapus");
                        }
                        else
                        {
                            Console.WriteLine("\nData NIK tidak ditemukan");
                        }
                        break;

                    case 3:
                        int nourut = 0;
                        string jenis = "";
                        Console.WriteLine("Data Karyawan\n");

                        foreach(Karyawan karyawan in listkaryawan)
                        {
                            if (karyawan is KaryawanTetap)
                            {
                                jenis = "Karyawan Tetap";
                            }
                            else if (karyawan is KaryawanHarian)
                            {
                                jenis = "Karyawan Harian";
                            }
                            else
                            {
                                jenis = "Sales";
                            }
                            nourut++;
                            Console.WriteLine("{0}. NIK : {1}, Nama : {2}, Gaji : {3}, {4}", nourut, karyawan.nik, karyawan.nama, karyawan.gaji(), jenis);
                        }

                        if(nourut<1)
                        {
                            Console.WriteLine("Data Karyawan Kosong");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Terimakasih");
                        break;

                    default:
                        Console.WriteLine("Menu Yang Anda Masukkan Tidak Tersedia");
                        break;

                }

                Console.WriteLine("\n\nTekan Enter untuk kembali ke Menu");
                Console.ReadKey();

            }
            while (pil != 4);
        }
    }
}
