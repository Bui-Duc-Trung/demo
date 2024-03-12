using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class QLThuCung
    {
        List<ThuCung> thuCungs {  get; set; }
        public QLThuCung()
        {
            thuCungs = new List<ThuCung>();
        }
        public void AddThuCung (string ten, string tenloai, string giong,  string mausac)
        {
            ThuCung thuCung = new ThuCung()
            {
                Ten = ten,
                TenLoai = tenloai,
                Giong = giong,
                MauSac = mausac
            };
            thuCungs.Add(thuCung);
        }
    }
}
