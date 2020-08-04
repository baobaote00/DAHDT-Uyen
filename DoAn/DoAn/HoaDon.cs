using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    class HoaDon : KhachHang
    {
        //Fields
        private string _maHoaDon;
        private DateTime _ngayLapHoaDon;

        //Properties
        public string MaHoaDon
        {
            get
            {
                return _maHoaDon;
            }

            set
            {
                _maHoaDon = value;
            }
        }

        public DateTime NgayLapHoaDon
        {
            get
            {
                return _ngayLapHoaDon;
            }

            set
            {
                _ngayLapHoaDon = value;
            }
        }

        //Methods
        /// <summary>
        /// Phuong thuc khoi tao khong tham so
        /// </summary>
        public HoaDon() : base()
        {
            this._maHoaDon = "ma hoa don";
            this._ngayLapHoaDon = new DateTime();
        }

        /// <summary>
        /// Phuong thuc khoi tao co day du tham so
        /// </summary>
        /// <param name="mHD"></param>
        /// <param name="nLHD"></param>
        public HoaDon(string maHoaDon, DateTime ngayLapHoaDon, string tenKhachHang, string soCMND, string email, string diaChi, Ve[] soVe, ChuyenBay chuyenBay) : base(tenKhachHang,soCMND,email,diaChi,soVe,chuyenBay)
        {
            this._maHoaDon = maHoaDon;
            this._ngayLapHoaDon = ngayLapHoaDon;
        }
        ~HoaDon() { }
        //To string
        public override string toString()
        {
            string s = base.toString() + $"/nMa hoa don: {this._maHoaDon}\nNgay lap hoa don: {this._ngayLapHoaDon}";
            return s;
        }
        public override string toStringFull()
        {
            string s = base.toString() + $"/nMa hoa don: {this._maHoaDon}\nNgay lap hoa don: {this._ngayLapHoaDon}";
            return s;
        }
    }
}
