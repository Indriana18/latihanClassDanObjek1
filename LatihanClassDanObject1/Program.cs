using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //membentuk ojek dari class mahasiswa 
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset nilai properties objek saya dan kamu
            saya.Nim = "12345";
            saya.Nama = "indri";
            saya.Ipk = "3.92f";

            kamu.Nim = "54321";
            kamu.Nama = "ana";
            kamu.Ipk = "3.70f";

            //memanggil method registrasi dan Isi Krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
