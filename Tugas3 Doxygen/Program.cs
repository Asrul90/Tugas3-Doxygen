using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirCafeApk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* mencetak aplikasi dan menampilkan menu minuman menggunakan ConsoleWritline. ConsoleWritline adalah perintah yang di 
            gunakan untuk menampilkan karakter yang di tulis tetapi dalam baris yang lain. Untuk contohnya sebagai berikut */
            Console.WriteLine("\t\t=============================================================================\n");
            Console.WriteLine("\t\t                         Nota Transaksi                                      ");
            Console.WriteLine("\t\t                           BIBLE CAFE                                        ");
            Console.WriteLine("\t\t                  JL.Timoho No.6 Kota Yogyakarta                           ");
            Console.WriteLine("\t\t                         08183-4683-8764                                      ");
            Console.WriteLine("\t\t============================================================================\n\n");
            Console.WriteLine("DRINK MENU\n");
            Console.WriteLine("1. Chocolatte               : Rp. 12000");
            Console.WriteLine("2. GreenTea                 : Rp. 14000");
            Console.WriteLine("3. Cappoccino               : Rp. 19000");
            Console.WriteLine("4. Taro                     : Rp. 12000");
            Console.WriteLine("5. Red Valvet               : Rp. 20000");

            Console.WriteLine("FOOD MENU\n");
            Console.WriteLine("1. Mie Ayam                 : Rp. 13000");
            Console.WriteLine("2. Nasi Uduk                : Rp. 25000");
            Console.WriteLine("3. Bakso                    : Rp. 28000");
            Console.WriteLine("4. Sate Ayam                : Rp. 18000");
            Console.WriteLine("5. Oseng Ayam               : Rp. 12000");

            Console.WriteLine("SNACK MENU\n");
            Console.WriteLine("1. Dimsum                   : Rp. 15000");
            Console.WriteLine("2. Keripik Ubi              : Rp. 18000");
            Console.WriteLine("3. Stick Kentang            : Rp. 20000");
            Console.WriteLine("4. Pisang Goreng            : Rp. 13000");
            Console.WriteLine("5. Mendoan                  : Rp. 25000");

            Console.WriteLine("DESSERT MENU\n");
            Console.WriteLine("1. Yiaourti                 : Rp.  7000");
            Console.WriteLine("2. Blakava                  : Rp. 10000");
            Console.WriteLine("3. Karidopita               : Rp. 12000");
            Console.WriteLine("4. Sakolata                 : Rp. 14000");
            Console.WriteLine("5. Granita                  : Rp. 18000");

            //looping input jumlah dengan memakai kondisi do while
            int JML;
            do
            {
                Console.WriteLine("Maukkan Jumlah Menu item");
                JML = int.Parse(Console.ReadLine());
            }
            while (JML <= 0 || JML > 10);

            //looping dengan memakai kombinasi Array. akan mencetak inputan nama menu item and price menu
            string[] nama = new string[JML];
            int[] Price = new int[JML];
            int total = 0;
            int bayar, kembali;

            for (int i = 0; i < JML; i++)
            {
                do
                {
                    Console.WriteLine("\nMasukkan nama menu item ke-" + (i + 1));
                    nama[i] = Console.ReadLine();
                }
                while (nama[i].Length <= 0 || nama[i].Length >= 20);

                do
                {
                    Console.WriteLine("Masukkan price menu item ke-" + (i + 1));
                    Price[i] = int.Parse(Console.ReadLine());

                    //kondisi user harus input price menu item antara 7000-100000
                }
                while (Price[i] <= 7000 || Price[i] >= 100000);
            }
            //deklarasi
            //string adalah tipe data yang menampung kumpulan karakter sepeerti contoh di bawah
            string NamaKasir;
            string NamaPembeli;
            string Date;
            String Jam;

            //Untuk contoh codingan di bawah beerfungsi untuk memanggil data string Di atas menggunakan console write
            Console.Write("\n\nNama Kasir : ");
            NamaKasir = Console.ReadLine();

            Console.Write("Nama Pembeli : ");
            NamaPembeli = Console.ReadLine();

            Date = DateTime.Now.ToString("dd/MM/yyy");

            Jam = DateTime.Now.ToString("hh : mm : ss");

            //Menampilkan Menu yang dipesan
            Console.Write("Tanggal Transaksi : " + Date);
            Console.Write("\nJam Transaksi : " + Jam);
            Console.WriteLine("\nMenu yang dibeli");
            Console.WriteLine("=====================================");
            for (int i = 0; i < JML; i++)
            {
                Console.WriteLine((i + 1) + "." + nama[i] + " " + Price[i]);
            }

            foreach (int i in Price)
            {
                total += i;
            }

            //menampilkan jumlah total harga
            Console.WriteLine("================================");
            Console.WriteLine("total            " + total);


            {
                Console.Write("\n Uang yang dibayarkan : ");
                bayar = int.Parse(Console.ReadLine());

                //Uang kembali dari uang bayar yang telah diinput user
                kembali = bayar - total;

                //jika uang bayar lebih kecil dari total jumlah harga
                if (bayar < total)
                {
                    Console.WriteLine("Maaf uang anda kurang");
                    Console.WriteLine("===============================");
                }
                //Jika uang bayar lebih dari jumlah total harga
                else
                {
                    Console.WriteLine("\n\n Uang kembalian anda Rp. " + kembali + ",00");
                }
            }
            while (bayar < total) ;

            //acknowledgments
            Console.WriteLine("\n\n\t\t                 Selamat Menikmati                                    ");
            Console.WriteLine("\n\t            Terimakasih Sudah Datang di Caffe Bible                       ");
            Console.ReadLine();

        }
    }
}
