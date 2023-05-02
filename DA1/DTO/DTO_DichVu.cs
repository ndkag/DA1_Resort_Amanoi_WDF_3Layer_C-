using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DichVu
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal GiaTien { get; set; }

        public DTO_DichVu() { }
        public DTO_DichVu(string maDV,string tenDV, decimal giaTien)
        {
            MaDV = maDV; TenDV = tenDV; GiaTien = giaTien; 
        }

    }
}
