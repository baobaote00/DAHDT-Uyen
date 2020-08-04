using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    [Serializable]
    class Ve
    {
        //Fields
        private string _maVe;
        private string _tinhTrangVe;
        private string _soGhe;
        private DateTime _ngayDat;
        private double _tienVe;
        private LoaiVe _loaiVe;

        //Properties
        public string MaVe
        {
            get
            {
                return _maVe;
            }

            set
            {
                _maVe = value;
            }
        }

        public string TinhTrangVe
        {
            get
            {
                return _tinhTrangVe;
            }

            set
            {
                _tinhTrangVe = value;
            }
        }

        public string SoGhe
        {
            get
            {
                return _soGhe;
            }

            set
            {
                _soGhe = value;
            }
        }

        public DateTime NgayDat
        {
            get
            {
                return _ngayDat;
            }

            set
            {
                _ngayDat = value;
            }
        }

        public double TienVe
        {
            get
            {
                return _tienVe;
            }

            set
            {
                _tienVe = value;
            }
        }

        internal LoaiVe LoaiVe
        {
            get
            {
                return _loaiVe;
            }

            set
            {
                _loaiVe = value;
            }
        }

        //Methods
        /// <summary>
        /// Phuong thuc khoi tao khong tham so
        /// </summary>
        public Ve()
        {
            this._maVe = "ma ve";
            this._tinhTrangVe = "tinh trang ve";
            this._soGhe = "so ghe";
            this._ngayDat = new DateTime(2000, 1, 1);
            this._tienVe = 0.0;
            this._loaiVe = new LoaiVe();
        }
        /// <summary>
        /// Phuong thuc khoi tao day du tham so
        /// </summary>
        /// <param name="maVe"></param>
        /// <param name="tinhTrangVe"></param>
        /// <param name="soGhe"></param>
        /// <param name="ngayDat"></param>
        /// <param name="tienVe"></param>
        /// <param name="loaiVe"></param>
        public Ve(string maVe, string tinhTrangVe, string soGhe, DateTime ngayDat, double tienVe, LoaiVe loaiVe)
        {
            this._maVe = maVe;
            this._tinhTrangVe = tinhTrangVe;
            this._soGhe = soGhe;
            this._ngayDat = ngayDat;
            this._tienVe = tienVe;
            this._loaiVe = loaiVe;
        }
        ~Ve() { }
        //To string
        public string toString()
        {
            string loaiVe = this.LoaiVe.toString();
            string str = $"Ma ve: {this._maVe}\nTinh trang ve: {this._tinhTrangVe}\nSo ghe: {this._soGhe}\nNgay dat: {this._ngayDat}\nTien ve: {this._tienVe}\nLoai ve: {loaiVe}";
            return str;
        }
    }
}
