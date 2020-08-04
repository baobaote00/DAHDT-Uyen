using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    [Serializable()]
    class ChuyenBay
    {
        //Fields
        private string _maChuyenBay;
        private string _noiKhoiHanh;
        private string _noiDen;
        private DateTime _thoiGianKhoiHanh;
        private int _thoiGianBay;

        //Properties
        public string MaChuyenBay
        {
            get
            {
                return _maChuyenBay;
            }

            set
            {
                _maChuyenBay = value;
            }
        }

        public string NoiKhoiHanh
        {
            get
            {
                return _noiKhoiHanh;
            }

            set
            {
                _noiKhoiHanh = value;
            }
        }

        public string NoiDen
        {
            get
            {
                return _noiDen;
            }

            set
            {
                _noiDen = value;
            }
        }

        public DateTime ThoiGianKhoiHanh
        {
            get
            {
                return _thoiGianKhoiHanh;
            }

            set
            {
                _thoiGianKhoiHanh = value;
            }
        }

        public int ThoiGianBay
        {
            get
            {
                return _thoiGianBay;
            }

            set
            {
                _thoiGianBay = value;
            }
        }

        //Methods
        /// <summary>
        /// Phuong thuc khoi tao khong tham so
        /// </summary>
        public ChuyenBay()
        {
            this._maChuyenBay = "ma chuyen bay";
            this._noiKhoiHanh = "noi khoi hanh";
            this._noiDen = "noi den";
            this._thoiGianBay = 0;
            this._thoiGianKhoiHanh = new DateTime(2000, 1, 1);
        }
        /// <summary>
        /// Phuong thuc khoi tao co day du tham so
        /// </summary>
        /// <param name="mCB"></param>
        /// <param name="nKH"></param>
        /// <param name="nD"></param>
        /// <param name="tGB"></param>
        /// <param name="tGKH"></param>
        public ChuyenBay(string maChuyenBay, string noiKhoiHanh, string noiDen, int thoiGianBay, DateTime thoiGianKhoiHanh)
        {
            this._maChuyenBay = maChuyenBay;
            this._noiKhoiHanh = noiKhoiHanh;
            this._noiDen = noiDen;
            this._thoiGianBay = thoiGianBay;
            this._thoiGianKhoiHanh = thoiGianKhoiHanh;
        }
        ~ChuyenBay() { }
        //To string
        public string toString()
        {
            string str = $"Ma chuyen bay: {this._maChuyenBay}\nNoi khoi hanh: {this._noiKhoiHanh}\nNoi den: {this._noiDen}\nThoi gian khoi hanh: {this._thoiGianKhoiHanh}\nThoi gian bay: {this._thoiGianBay}";
            return str;
        }
    }
}
