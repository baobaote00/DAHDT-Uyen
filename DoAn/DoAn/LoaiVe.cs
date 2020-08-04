using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    class LoaiVe
    {
        //fields
        private string _maLoaiVe;
        private string _tenLoaiVe;

        //Properties
        public string MaLoaiVe
        {
            get
            {
                return _maLoaiVe;
            }

            set
            {
                _maLoaiVe = value;
            }
        }

        public string TenLoaiVe
        {
            get
            {
                return _tenLoaiVe;
            }

            set
            {
                _tenLoaiVe = value;
            }
        }

        //Methods
        /// <summary>
        /// Phuong thuc khoi tao khong tham so
        /// </summary>
        public LoaiVe()
        {
            this._maLoaiVe = "ma laoi ve";
            this._tenLoaiVe = "ten loai ve";
        }
        /// <summary>
        /// Phuong thuc khoi tao day du tham so
        /// </summary>
        /// <param name="mLV"></param>
        /// <param name="tLV"></param>
        public LoaiVe(string mLV, string tLV)
        {
            this._maLoaiVe = mLV;
            this._tenLoaiVe = tLV;
        }
        ~LoaiVe() { }
        //To string
        public string toString()
        {
            string str = $"Ma loai ve: {this._maLoaiVe}\nTen loai ve: {this._tenLoaiVe}";
            return str;
        }
    }
}
