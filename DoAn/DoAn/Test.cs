using DoAn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.json";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                LinkedList<KhachHang> ks = new LinkedList<KhachHang>();
                ks.AddLast(new KhachHang("uyen", "123", "baobaote@gmail.com", "123", new Ve[] { new Ve() }, new ChuyenBay()));
                ks.AddLast(new KhachHang("uyen", "123", "baobaote@gmail.com", "123", new Ve[] { new Ve() }, new ChuyenBay()));
                ks.AddLast(new KhachHang("uyen", "123", "baobaote@gmail.com", "123", new Ve[] { new Ve() }, new ChuyenBay()));
                ks.AddLast(new KhachHang("uyen", "123", "baobaote@gmail.com", "123", new Ve[] { new Ve() }, new ChuyenBay()));
                ks.AddLast(new KhachHang("uyen", "123", "baobaote@gmail.com", "123", new Ve[] { new Ve() }, new ChuyenBay()));

                LinkedList<KhachHang> ks1 = TestSerializable<KhachHang>.Deserializable(path);

                for (LinkedListNode<KhachHang> i = ks1.First; i != null; i = i.Next)
                {
                    Console.WriteLine(i.Value.toStringFull());
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
                }
            }
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
            using (StreamWriter sw = new StreamWriter(@"I:\CNTT\LapTrinhHuongDoiTuong\DoAn\test.txt", true))
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
