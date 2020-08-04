using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    class KhachHang
    {
        //Fields
        private string _tenKhachHang;
        private string _soCMND;
        private string _email;
        private string _diaChi;
        private Ve[] _soVe;
        private ChuyenBay _chuyenBay;

        //Properties
        public string TenKhachHang
        {
            get
            {
                return _tenKhachHang;
            }

            set
            {
                _tenKhachHang = value;
            }
        }

        public string SoCMND
        {
            get
            {
                return _soCMND;
            }

            set
            {
                _soCMND = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        internal Ve[] SoVe
        {
            get
            {
                return _soVe;
            }

            set
            {
                _soVe = value;
            }
        }

        internal ChuyenBay ChuyenBay
        {
            get
            {
                return _chuyenBay;
            }

            set
            {
                _chuyenBay = value;
            }
        }

        //Methods
        /// <summary>
        /// Phuong thuc khoi tao khong tham so
        /// </summary>
        public KhachHang()
        {
            this._tenKhachHang = "ten khach hang";
            this._soCMND = "so CMND";
            this._email = "email";
            this._diaChi = "dia chi";
            this._soVe = new Ve[0];
            this._chuyenBay = new ChuyenBay();
        }
        /// <summary>
        /// Phuong thuc khoi tao 4 tham so
        /// </summary>
        /// <param name="tenKhachHang"></param>
        /// <param name="soCMND"></param>
        /// <param name="email"></param>
        /// <param name="diaChi"></param>
        public KhachHang(string tenKhachHang, string soCMND, string email, string diaChi)
        {
            this._tenKhachHang = tenKhachHang;
            this._soCMND = soCMND;
            this._email = email;
            this._diaChi = diaChi;
        }
        /// <summary>
        /// Phuong thuc khoi tao co day du tham so
        /// </summary>
        /// <param name="tKH"></param>
        /// <param name="sCMND"></param>
        /// <param name="e"></param>
        /// <param name="dC"></param>
        /// <param name="sV"></param>
        /// <param name="cB"></param>
        public KhachHang(string tenKhachHang, string soCMND, string email, string diaChi, Ve[] soVe, ChuyenBay chuyenBay)
        {
            this._tenKhachHang = tenKhachHang;
            this._soCMND = soCMND;
            this._email = email;
            this._diaChi = diaChi;
            this._soVe = soVe;
            this._chuyenBay = chuyenBay;
        }
        ~KhachHang() { }
        //To string
        public virtual string toStringFull()
        {
            string v = "";
            for (int i = 0; i < this._soVe.Length; i++)
            {
                v += this._soVe[i].toString();
            }
            string cB = this._chuyenBay.toString();
            string s = $"Ten KH: {this._tenKhachHang}\nCMND: {this._soCMND}\nEmail: {this._email}\nDia chi: {this._diaChi}\nSo ve: {v}\nChuyen Bay: {cB}";
            return s;
        }
        public virtual string toString()
        {
            string s = $"Ten KH: {this._tenKhachHang}-CMND: {this._soCMND}-Email: {this._email}-Dia chi: {this._diaChi}";
            return s;
        }
        public static string[] toStringArray(LinkedList<KhachHang> khachHangs)
        {
            string[] arrStrings = new string[khachHangs.Count];
            int x = 0;
            for (LinkedListNode<KhachHang> i = khachHangs.First; i != null; i = i.Next)
            {
                arrStrings[x] = i.Value.toString();
                x++;
            }
            return arrStrings;
        }
    }
}
