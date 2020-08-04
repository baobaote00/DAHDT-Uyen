using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang kh1 = new KhachHang("Mai", "123", "123", "456");
            KhachHang kh2 = new KhachHang("Lai", "456", "123", "456");
            KhachHang kh3 = new KhachHang("Nam", "789", "123", "456");
            Console.WriteLine(kh1.toString());

            LinkedList<KhachHang> kh = new LinkedList<KhachHang>();
            kh.AddLast(kh1);
            kh.AddLast(kh2);
            kh.AddLast(kh3);
            string[] dskh = KhachHang.toStringArray(kh);

            using (StreamWriter sw = new StreamWriter(@"I:\CNTT\LapTrinhHuongDoiTuong\DoAn\test.txt"))
            {
                foreach (string s in dskh)
                {
                    sw.WriteLine(s);
                }
            }
            //string line = "";
            //using (StreamReader sr = new StreamReader(@"F:\CNTT\LapTrinhHuongDoiTuong\DoAn\test.txt"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            themKhachHang();
            inThongTinKhachHangTuFile();
            
        }

        public static void themKhachHang()
        {
            LinkedList<KhachHang> kh = new LinkedList<KhachHang>();
            //ho ten
            string tenKH;
            Console.Write("Ho ten: ");
            tenKH = Console.ReadLine();
            //so CMND
            string soCMND;
            Console.Write("So CMND: ");
            soCMND = Console.ReadLine();
            //email
            string email;
            Console.Write("Email: ");
            email = Console.ReadLine();
            //dia chi
            string diaChi;
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();

            //tao 1 khach hang
            KhachHang khachHang = new KhachHang(tenKH, soCMND, email, diaChi);
            // them khach hang vao file
            kh.AddLast(khachHang);
            string[] dskh = KhachHang.toStringArray(kh);
            using (StreamWriter sw = new StreamWriter(@"I:\CNTT\LapTrinhHuongDoiTuong\DoAn\test.txt",true))
            {
                foreach (string s in dskh)
                {
                    sw.WriteLine(s);
                }
            }
        }

        public static string[] ReadFile(string link)
        {
            try
            {
                //cái này xử lý trong list dể hơn á 
                List<string> kh = new List<string>();

                StreamReader streamReader = new StreamReader(link);
                string str;
                while ((str = streamReader.ReadLine()) != null)
                {
                    kh.Add(str);
                }
                streamReader.Close();
                return kh.ToArray();
            }
            catch
            {
                return null;
            }
        }
        static void inThongTinKhachHangTuFile()
        {
            foreach (var item in ReadFile(@"I:\CNTT\LapTrinhHuongDoiTuong\DoAn\test.txt"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
